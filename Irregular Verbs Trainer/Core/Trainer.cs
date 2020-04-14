using IVT.Events;
using IVT.Objects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Timers;

namespace IVT.Core
{
    public class Trainer : IDisposable
    {
        private bool disposed = false;
        private Stopwatch durationSW;
        private int lostVerbs = 0;
        private int points = 0;
        private int wonVerbs = 0;
        private VerbAnswer runningVerbAnswer;
        private Timer remainingTimerCheckerTimer;

        /// <summary>
        /// Initiate a Trainer instance wit given dictionnary of verbs and train Parameters.
        /// Once initiated, Trainer will automatically prepare the next verbs queue.
        /// </summary>
        public Trainer(Dictionary<string, Verb> dict, OptionsArgs param)
        {
            durationSW = new Stopwatch();
            remainingTimerCheckerTimer = new Timer(100);
            remainingTimerCheckerTimer.Elapsed += RemainingTimerCheckerTimer_Elapsed;

            Dict = dict;
            Parameters = param;

            RunningVerbIndex = -1;
        }

        private void RemainingTimerCheckerTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (TimerRemainingTime.TotalMilliseconds <= 100)
            {
                TimerModeTimeOver();
            }
        }

        public DateTime StartDate { get; private set; }

        /// <summary>
        /// Dictionary of used verbs : string (infinitive), verb (complete verb object)
        /// </summary>
        public Dictionary<string, Verb> Dict { get; private set; }

        public TimeSpan Duration
        {
            get
            {
                return durationSW.Elapsed;
            }
        }

        public int Flames { get; private set; }

        public bool LastTrainEndedTimeOver { get; private set; }
        public int LostVerbs { get => lostVerbs; private set { lostVerbs = value; TotalVerbs = LostVerbs + WonVerbs; } }

        public OptionsArgs Parameters { get; private set; }

        public int Points
        {
            get => points;
            private set
            {
                points = value;
                if (TotalVerbs != 0)
                {
                    Flames = Points * 100 / (TotalVerbs * Parameters.WonAddPoint);
                }
                else
                {
                    Flames = 0;
                }
            }
        }

        public int RemainingChances { get; private set; }
        public int RunningVerbIndex { get; private set; }

        public bool TimerObjectiveWon { get; private set; } = false;
        public TimeSpan TimerRemainingTime
        {
            get
            {
                return Parameters.TimerTiming - durationSW.Elapsed;
            }
        }

        public int TotalVerbs { get; private set; } = 0;
        public List<VerbAnswer> VerbAnswers { get; private set; } = new List<VerbAnswer>();

        public bool TrainerRunning { get; private set; } = false;

        /// <summary>
        /// Keys of verbs queuing
        /// </summary>
        public string[] VerbQueue { get; private set; }

        public int WonVerbs
        {
            get => wonVerbs;
            private set
            {
                wonVerbs = value;
                TotalVerbs = LostVerbs + WonVerbs;
                if (Parameters.Mode == AnswerMode.Timer && WonVerbs >= Parameters.TimerNumberOfVerbs)
                {
                    TimerObjectiveWon = true;
                }
                else
                {
                    TimerObjectiveWon = false;
                }
            }
        }

        /// <summary>
        /// Checks user answer and update score. Score updates when answer is correct or there are no chances left.
        /// </summary>
        public Dictionary<Gaps, string> CheckUserAnswer(Verb userVerbAnswer)
        {
            if (!TrainerRunning)
            {
                throw new Exception("Trying to get next verb of training though the Trainer was not Started.");
            }

            if (RunningVerbIndex < 0)
            {
                throw new Exception("Running verb index inferior to 0. Was the Trainer correctly Started?");
            }

            Verb runningVerb = Dict[VerbQueue[RunningVerbIndex]];
            int errors = 0;
            Dictionary<Gaps, string> correctionDict = new Dictionary<Gaps, string>();

            // Fill correction dict with correction
            if (Regex.Replace(userVerbAnswer.Infinitive.ToLower(), @"\s+", " ").Trim() != runningVerb.Infinitive.ToLower())
            {
                correctionDict.Add(Gaps.Infinitive, runningVerb.Infinitive);
                runningVerbAnswer.AddWrongAnswer(Gaps.Infinitive, userVerbAnswer.Infinitive);
                errors++;
            }
            else if (!runningVerbAnswer.InfinitiveAnswer.NotAnswerable)
            {
                runningVerbAnswer.AnsweredCorrectly(Gaps.Infinitive, userVerbAnswer.Infinitive);
            }

            if (Regex.Replace(userVerbAnswer.Preterit.ToLower(), @"\s+", " ").Trim() != runningVerb.Preterit.ToLower())
            {
                correctionDict.Add(Gaps.Preterit, runningVerb.Preterit);
                runningVerbAnswer.AddWrongAnswer(Gaps.Preterit, userVerbAnswer.Preterit);
                errors++;
            }
            else if (!runningVerbAnswer.PreteritAnswer.NotAnswerable)
            {
                runningVerbAnswer.AnsweredCorrectly(Gaps.Preterit, userVerbAnswer.Preterit);
            }

            if (Regex.Replace(userVerbAnswer.PresentPerfect.ToLower(), @"\s+", " ").Trim() != runningVerb.PresentPerfect.ToLower())
            {
                correctionDict.Add(Gaps.PresentPerfect, runningVerb.PresentPerfect);
                runningVerbAnswer.AddWrongAnswer(Gaps.PresentPerfect, userVerbAnswer.PresentPerfect);
                errors++;
            }
            else if (!runningVerbAnswer.PresentPerfectAnswer.NotAnswerable)
            {
                runningVerbAnswer.AnsweredCorrectly(Gaps.PresentPerfect, userVerbAnswer.PresentPerfect);
            }

            if (Regex.Replace(userVerbAnswer.Translation.ToLower(), @"\s+", " ").Trim() != runningVerb.Translation.ToLower())
            {
                correctionDict.Add(Gaps.Translation, runningVerb.Translation);
                runningVerbAnswer.AddWrongAnswer(Gaps.Translation, userVerbAnswer.Translation);
                errors++;
            }
            else if (!runningVerbAnswer.TranslationAnswer.NotAnswerable)
            {
                runningVerbAnswer.AnsweredCorrectly(Gaps.Translation, userVerbAnswer.Translation);
            }

            // Update score
            if (errors == 0)
            {
                WonVerbs++;
                Points += Parameters.WonAddPoint;
                EventLinker.RaiseScoreUpdate(Points, TotalVerbs, WonVerbs, LostVerbs, Parameters.WonAddPoint, 0, -1);
            }
            else
            {
                if (RemainingChances > 0)
                {
                    RemainingChances--;
                }
                else if (RemainingChances == 0)
                {
                    RemainingChances = -1;
                    LostVerbs++;
                    Points -= Parameters.LostRemovePoints;
                }
                EventLinker.RaiseScoreUpdate(Points, TotalVerbs, WonVerbs, LostVerbs, -Parameters.LostRemovePoints, errors, RemainingChances);
            }

            return correctionDict;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Returns the next filled verb forms, leaving ones for the user to answer according to parameters.
        /// </summary>
        /// <returns></returns>
        public Dictionary<Gaps, string> GetNextVerb()
        {
            if (!TrainerRunning)
            {
                throw new Exception("Trying to get nex verb of training though the Trainer was not Started.");
            }

            if (runningVerbAnswer != null)
            {
                runningVerbAnswer.StopSW();
            }

            RunningVerbIndex++;

            List<Gaps> nonAnswerableGaps = new List<Gaps>();
            Dictionary<Gaps, string> filledGaps = new Dictionary<Gaps, string>();
            if (!Parameters.RandomGaps) // If filled Gaps chosen
            {
                if (Parameters.InfinitiveGap)
                {
                    filledGaps.Add(Gaps.Infinitive, Dict[VerbQueue[RunningVerbIndex]].Infinitive);
                    nonAnswerableGaps.Add(Gaps.Infinitive);
                }

                if (Parameters.PreteritGap)
                {
                    filledGaps.Add(Gaps.Preterit, Dict[VerbQueue[RunningVerbIndex]].Preterit);
                    nonAnswerableGaps.Add(Gaps.Preterit);
                }

                if (Parameters.PpGap)
                {
                    filledGaps.Add(Gaps.PresentPerfect, Dict[VerbQueue[RunningVerbIndex]].PresentPerfect);
                    nonAnswerableGaps.Add(Gaps.PresentPerfect);
                }

                if (Parameters.TranslationGap)
                {
                    filledGaps.Add(Gaps.Translation, Dict[VerbQueue[RunningVerbIndex]].Translation);
                    nonAnswerableGaps.Add(Gaps.Translation);
                }
            }
            else // If filled gaps random
            {
                Random rdm = new Random();

                int i = rdm.Next(0, 3); // Number of filled gaps 0 -> 2 (1 gap to 3)

                for (int j = 0; j <= i; j++)
                {
                    int k = rdm.Next(0, 4); // Id of the filled gap 0 -> 3 (0:Infinitive to 3:Translation)
                    Gaps tempGap = (Gaps)k; // Convert int Id to Gaps enum

                    if (filledGaps.Keys.Contains(tempGap)) // If filled gap already chosen...
                    {
                        j--; // ... cancel this tun.
                    }
                    else // ... else add it.
                    {
                        filledGaps.Add(tempGap, GetVerbGapForm(tempGap, Dict[VerbQueue[RunningVerbIndex]]));
                        nonAnswerableGaps.Add(tempGap);
                    }
                }
            }

            RemainingChances = Parameters.AvailableChances;
            runningVerbAnswer = new VerbAnswer(Dict[VerbQueue[RunningVerbIndex]], nonAnswerableGaps);
            VerbAnswers.Add(runningVerbAnswer);

            runningVerbAnswer.StartSW();
            return filledGaps;
        }

        public void PassRunningVerb()
        {
            runningVerbAnswer.StopSW();

            LostVerbs++;            

            Points -= Parameters.PassedRemovePoints;

            EventLinker.RaiseScoreUpdate(Points, TotalVerbs, WonVerbs, LostVerbs, -Parameters.PassedRemovePoints, 0, -1);
        }

        /// <summary>
        /// Starts the trainer (and timer if Timer Mode enabled)
        /// </summary>
        public void Start()
        {
            durationSW.Reset();

            MakeNewQueue();

            ResetScore();

            TrainerRunning = true;

            if (Parameters.Mode == AnswerMode.Timer)
            {
                remainingTimerCheckerTimer.Start();
                EventLinker.RaiseTimerModeTimerStarted(TimerRemainingTime);
            }

            StartDate = DateTime.Now;
            durationSW.Start();
        }

        public void Stop()
        {
            if (runningVerbAnswer != null)
            {
                runningVerbAnswer.StopSW();
            }

            LastTrainEndedTimeOver = false;
            durationSW.Stop();
            TrainerRunning = false;
            if (Parameters.Mode == AnswerMode.Timer)
            {
                remainingTimerCheckerTimer.Stop();
                EventLinker.RaiseTimerModeTimerStopped(TimerRemainingTime);
            }            
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                //
                remainingTimerCheckerTimer.Dispose();
            }

            // Free any unmanaged objects here.
            //
            disposed = true;
        }

        private string GetVerbGapForm(Gaps gap, Verb vb)
        {
            switch (gap)
            {
                case Gaps.Infinitive:
                    return Dict[vb.Infinitive].Infinitive;

                case Gaps.Preterit:
                    return Dict[vb.Infinitive].Preterit;

                case Gaps.PresentPerfect:
                    return Dict[vb.Infinitive].PresentPerfect;

                case Gaps.Translation:
                    return Dict[vb.Infinitive].Translation;
            }

            return null;
        }

        /// <summary>
        /// Make a new queue in VerbQueue with Parameters rules and list of verbs.
        /// </summary>
        private void MakeNewQueue()
        {
            if (Parameters.ApparitionMode == VerbsAppartionMode.Ascendant)
            {
                VerbQueue = Dict
                        .Keys
                        .OrderBy(x => x)
                        .ToArray();
            }
            else if (Parameters.ApparitionMode == VerbsAppartionMode.Descendent)
            {
                VerbQueue = Dict
                        .Keys
                        .OrderByDescending(x => x)
                        .ToArray();
            }
            else if (Parameters.ApparitionMode == VerbsAppartionMode.Random)
            {
                List<string> tempQueue = new List<string>();
                List<string> keys = Dict.Keys.ToList();
                var randomizer = new Random();
                // Pluck them out randomly
                for (int i = Dict.Count; i > 0; i--)
                {
                    int r = randomizer.Next(0, i);
                    tempQueue.Add(keys[r]);
                    keys.RemoveAt(r);
                }

                VerbQueue = tempQueue.ToArray();
            }
        }

        private void ResetScore()
        {
            WonVerbs = 0;
            LostVerbs = 0;
            Points = 0;

            VerbAnswers.Clear();

            EventLinker.RaiseScoreUpdate(Points, TotalVerbs, WonVerbs, LostVerbs, 0, -1, -1);
        }

        private void TimerModeTimeOver()
        {
            if (runningVerbAnswer != null)
            {
                runningVerbAnswer.StopSW();
            }

            LastTrainEndedTimeOver = true;

            durationSW.Stop();

            remainingTimerCheckerTimer.Stop();
            EventLinker.RaiseTimerModeTimeOver(TimerRemainingTime);

            TrainerRunning = false;
        }

        private void TimerRemainingTimeTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (TimerRemainingTime.TotalSeconds <= 0)
            {
                TimerModeTimeOver();
            }
        }
    }
}