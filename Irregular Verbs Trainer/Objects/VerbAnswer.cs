using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace IVT.Objects
{
    [Serializable]
    public class VerbAnswer
    {
        public Verb InitialVerb { get; set; }
        public VerbFormAnswer InfinitiveAnswer { get; private set; }
        public VerbFormAnswer PreteritAnswer { get; private set; }
        public VerbFormAnswer PresentPerfectAnswer { get; private set; }
        public VerbFormAnswer TranslationAnswer { get; private set; }
        public bool Passed { get; private set; } = false;
        public bool TimerRunning
        {
            get
            {
                return verbElapsedTimeSW.IsRunning;
            }
        }

        public TimeSpan VerbElapsedTime { get; private set; } = new TimeSpan(0, 0, 0);

        [NonSerialized]
        private Stopwatch verbElapsedTimeSW;

        public VerbAnswer(Verb initialVerb, List<Gaps> nonAnswerableGaps)
        {
            verbElapsedTimeSW = new Stopwatch();

            InitialVerb = initialVerb;

            InfinitiveAnswer = new VerbFormAnswer(nonAnswerableGaps.Contains(Gaps.Infinitive));
            PreteritAnswer = new VerbFormAnswer(nonAnswerableGaps.Contains(Gaps.Preterit));
            PresentPerfectAnswer = new VerbFormAnswer(nonAnswerableGaps.Contains(Gaps.PresentPerfect));
            TranslationAnswer = new VerbFormAnswer(nonAnswerableGaps.Contains(Gaps.Translation));
        }

        public void StartSW()
        {
            verbElapsedTimeSW.Start();
        }

        public void StopSW()
        {
            verbElapsedTimeSW.Stop();
            VerbElapsedTime = verbElapsedTimeSW.Elapsed;
        }

        /// <summary>
        /// Stops SW and set this verb answer's 'passed' value to true.
        /// </summary>
        public void VerbPassed()
        {
            StopSW();
            Passed = true;
        }

        public void AddWrongAnswer(Gaps gap, string wrongAnswer)
        {
            switch (gap)
            {
                case Gaps.Infinitive:
                    InfinitiveAnswer.AddWrongAnswer(wrongAnswer);
                    break;
                case Gaps.Preterit:
                    PreteritAnswer.AddWrongAnswer(wrongAnswer);
                    break;
                case Gaps.PresentPerfect:
                    PresentPerfectAnswer.AddWrongAnswer(wrongAnswer);
                    break;
                case Gaps.Translation:
                    TranslationAnswer.AddWrongAnswer(wrongAnswer);
                    break;
                case Gaps.All:
                    throw new Exception("Cannot add a wrong answer to all verb forms.");
            }
        }

        public void AnsweredCorrectly(Gaps gap, string goodAnswer)
        {
            switch (gap)
            {
                case Gaps.Infinitive:
                    InfinitiveAnswer.AnsweredCorrectly = true;
                    break;
                case Gaps.Preterit:
                    PreteritAnswer.AnsweredCorrectly = true;
                    break;
                case Gaps.PresentPerfect:
                    PresentPerfectAnswer.AnsweredCorrectly = true;
                    break;
                case Gaps.Translation:
                    TranslationAnswer.AnsweredCorrectly = true;
                    break;
                case Gaps.All:
                    throw new Exception("Cannot 'answer correctly' to all verb forms.");
            }
        }
    }
}
