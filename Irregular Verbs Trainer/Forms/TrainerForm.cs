using IVT.Core;
using IVT.Events;
using IVT.Objects;
using IVT.Tools;
using IVT.Xml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace IVT.Forms
{
    public partial class TrainerForm : Form
    {
        private ActionBtnMode actionMode;
        private List<TextBox> allAnswerTxt = new List<TextBox>();
        private List<Label> allCorrectionLbl = new List<Label>();
        private Trainer trainer;
        private System.Timers.Timer parallelTimerModeTimer = new System.Timers.Timer(10);
        private Stopwatch stopwatch = new Stopwatch();

        public TrainerForm()
        {
            InitializeComponent();
            EventLinker.ScoreUpdate += EventLinker_ScoreUpdate;
            EventLinker.TimerModeTimerStarted += EventLinker_TimerModeTimerStarted;
            EventLinker.TimerModeTimerStopped += EventLinker_TimerModeTimerStopped;
            EventLinker.TimerModeTimeOver += EventLinker_TimerModeTimeOver;
            parallelTimerModeTimer.Elapsed += ParallelTimerModeTimer_Elapsed;

            allAnswerTxt.AddRange(new TextBox[] { infinitiveAnswerTxt, preteritAnswerTxt, ppAnswerTxt, translationAnswerTxt });
            allCorrectionLbl.AddRange(new Label[] { infinitiveCorrectionLbl, preteritCorrectionLbl, ppCorrectionLbl, translationCorrectionLbl });

            if (!File.Exists(Properties.Settings.Default.verbsFilePath) && Properties.Settings.Default.verbsFilePath != "")
            {
                MessageBox.Show(this, "Your last file \"" + Path.GetFileName(Properties.Settings.Default.verbsFilePath)
                    + "\" could not be found. Relocate it or create a new one trough the Edit window.", this.Text + " - File could not be located",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Properties.Settings.Default.verbsFilePath = "";
                Properties.Settings.Default.Save();
            }

            UpdateLoadedFileLbl();

            ResetTraining();

            UpdateWindowMode();

            BlockAnswer(Gaps.All);
        }

        private delegate void EventLinker_TimerModeTimeOverDelegate(object sender, EventArgs e);
        private void EventLinker_TimerModeTimeOver(object sender, EventArgs e)
        {
            if (InvokeRequired) // En cas d'appel de cette fonction depuis un autre thread
            {
                Invoke(new EventLinker_TimerModeTimeOverDelegate(this.EventLinker_TimerModeTimeOver), sender, e);
                return;
            }

            parallelTimerModeTimer.Stop();

            scoreLbl.Text = "     Remaining time: " + trainer.Parameters.TimerTiming.ToString();
            scoreLbl.ForeColor = Color.Black;

            ClearAnswerAndCorrection();

            ChangeActionBtnMode(ActionBtnMode.Start);

            BlockAnswer(Gaps.All);



            ShowEndScreen();
        }

        private void EventLinker_TimerModeTimerStopped(object sender, EventArgs e)
        {
            parallelTimerModeTimer.Stop();
            scoreLbl.Text = "     Remaining time: " + trainer.Parameters.TimerTiming.ToString();
        }

        private void EventLinker_TimerModeTimerStarted(object sender, EventArgs e)
        {
            parallelTimerModeTimer.Start();
        }

        private delegate void ParallelTimerModeTimer_ElapsedDelegate(object sender, System.Timers.ElapsedEventArgs e);
        private void ParallelTimerModeTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new ParallelTimerModeTimer_ElapsedDelegate(ParallelTimerModeTimer_Elapsed), sender, e);
                return;
            }
            
            if (trainer.WonVerbs >= trainer.Parameters.TimerNumberOfVerbs)
            {
                scoreLbl.ForeColor = Color.Green;
            }
            else if (trainer.TimerRemainingTime.TotalSeconds > 30)
            {
                scoreLbl.ForeColor = Color.Black;
            }
            else if (trainer.TimerRemainingTime.TotalSeconds > 10)
            {
                scoreLbl.ForeColor = Color.Orange;
            }
            else
            {
                scoreLbl.ForeColor = Color.Red;
            }
            
            if (trainer.TimerRemainingTime.TotalSeconds <= 10)
                scoreLbl.Text = "     Remaining time: " + trainer.TimerRemainingTime.ToString(@"hh\:mm\:ss\,ff");
            else
                scoreLbl.Text = "     Remaining time: " + trainer.TimerRemainingTime.ToString(@"hh\:mm\:ss");
        }

        private delegate void EventLinker_ScoreUpdateDelegate(object sender, EventArgs e);

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            Point location = this.PointToScreen(Point.Empty);
            aboutForm.Location = new Point(location.X + (this.Width / 2) - (aboutForm.Width / 2),
                location.Y + (this.Height / 2) - (aboutForm.Height / 2) - 30);

            aboutForm.ShowDialog();
        }

        private void ActionBtn_Click(object sender, EventArgs e)
        {
            if (actionMode == ActionBtnMode.Start)
            {
                StartTraining();
            }
            else if (actionMode == ActionBtnMode.Correction)
            {
                CheckAndCorrectUserAnswer();
            }
            else if (actionMode == ActionBtnMode.Next)
            {
                NextQuestion();
            }
            else if (actionMode == ActionBtnMode.Finish)
            {
                StopTraining();
                ShowEndScreen();
            }
        }

        private void AnswerTxt_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox txtBox = (TextBox)sender;

            if (e.KeyCode == Keys.Enter && actionMode != ActionBtnMode.Start)
            {
                List<TextBox> remainingTxt = layoutPanel.Controls.OfType<TextBox>().Where(x => (x.TabIndex > txtBox.TabIndex && x.ReadOnly == false)).ToList();
                if (remainingTxt.Count() == 0)
                {
                    actionBtn.Focus();
                    ActionBtn_Click(null, null);
                }
                else
                {
                    SendKeys.Send("{TAB}");
                }
            }
        }

        private void AnswerTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (actionMode == ActionBtnMode.Start)
            {
                MessageBox.Show(this, "Press the \"Start!\" button to start training.", this.Text + " - Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actionBtn.Focus();
                e.Handled = true;
                return;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void BlockAnswer(params Gaps[] gapsArg)
        {
            foreach (Gaps gap in gapsArg)
            {
                switch (gap)
                {
                    case Gaps.All:
                        allAnswerTxt.ForEach(x => { x.ReadOnly = true; x.TabStop = false; });
                        break;

                    case Gaps.Infinitive:
                        infinitiveAnswerTxt.ReadOnly = true;
                        infinitiveAnswerTxt.TabStop = false;
                        break;

                    case Gaps.Preterit:
                        preteritAnswerTxt.ReadOnly = true;
                        preteritAnswerTxt.TabStop = false;
                        break;

                    case Gaps.PresentPerfect:
                        ppAnswerTxt.ReadOnly = true;
                        ppAnswerTxt.TabStop = false;
                        break;

                    case Gaps.Translation:
                        translationAnswerTxt.ReadOnly = true;
                        translationAnswerTxt.TabStop = false;
                        break;
                }
            }
        }

        private void ChangeActionBtnMode(ActionBtnMode mode)
        {
            switch (mode)
            {
                case ActionBtnMode.Start:
                    actionBtn.Image = Properties.Resources.power16;
                    actionBtn.Text = "Start!";
                    passBtn.Enabled = false;
                    stopBtn.Enabled = false;
                    break;

                case ActionBtnMode.Next:
                    actionBtn.Image = Properties.Resources.next16;
                    actionBtn.Text = "Next";
                    passBtn.Enabled = false;
                    stopBtn.Enabled = true;
                    break;

                case ActionBtnMode.Correction:
                    actionBtn.Image = Properties.Resources.okay16;
                    actionBtn.Text = "Correction";
                    passBtn.Enabled = true;
                    stopBtn.Enabled = true;
                    break;

                case ActionBtnMode.Finish:
                    actionBtn.Image = Properties.Resources.end16;
                    actionBtn.Text = "Finish";
                    passBtn.Enabled = false;
                    stopBtn.Enabled = false;
                    break;
            }

            actionMode = mode;
        }

        /// <summary>
        /// Checks the user answer and returns true if no errors were made.
        /// </summary>
        private bool CheckAndCorrectUserAnswer()
        {
            if (allAnswerTxt.Where(x => x.ReadOnly == false && String.IsNullOrWhiteSpace(x.Text) == true).Count() > 0)
            {
                MessageBox.Show(this, "Please complete all the gaps.", this.Text + " - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (trainer.TrainerRunning)
                    allAnswerTxt.First(x => !x.ReadOnly && String.IsNullOrWhiteSpace(x.Text)).Focus();
                return false;
            }

            Verb userVerbAnswer = new Verb(infinitiveAnswerTxt.Text,
                preteritAnswerTxt.Text,
                ppAnswerTxt.Text,
                translationAnswerTxt.Text);

            Dictionary<Gaps, string> correctionDict = trainer.CheckUserAnswer(userVerbAnswer);

            if (correctionDict.Count() > 0 && trainer.RemainingChances >= 0)
            {
                allAnswerTxt.First(x => x.ReadOnly == false).Focus();
                return false;
            }

            allAnswerTxt.ForEach(x => { if (!x.ReadOnly) { x.ForeColor = Color.Green; } });

            if (correctionDict.Count == 0)
            {
                if (trainer.RunningVerbIndex == trainer.VerbQueue.Count() - 1)
                {
                    ChangeActionBtnMode(ActionBtnMode.Finish);
                }
                else
                {
                    ChangeActionBtnMode(ActionBtnMode.Next);
                }
                actionBtn.Focus();
                return true;
            }

            foreach (Gaps gap in correctionDict.Keys)
            {
                if (gap == Gaps.Infinitive)
                {
                    infinitiveAnswerTxt.Font = new Font(new FontFamily("Segoe UI"), 9.75f, FontStyle.Strikeout);
                    infinitiveAnswerTxt.ForeColor = Color.Red;
                    infinitiveCorrectionLbl.Text = correctionDict[gap];
                }
                else if (gap == Gaps.Preterit)
                {
                    preteritAnswerTxt.Font = new Font(new FontFamily("Segoe UI"), 9.75f, FontStyle.Strikeout);
                    preteritAnswerTxt.ForeColor = Color.Red;
                    preteritCorrectionLbl.Text = correctionDict[gap];
                }
                else if (gap == Gaps.PresentPerfect)
                {
                    ppAnswerTxt.Font = new Font(new FontFamily("Segoe UI"), 9.75f, FontStyle.Strikeout);
                    ppAnswerTxt.ForeColor = Color.Red;
                    ppCorrectionLbl.Text = correctionDict[gap];
                }
                else if (gap == Gaps.Translation)
                {
                    translationAnswerTxt.Font = new Font(new FontFamily("Segoe UI"), 9.75f, FontStyle.Strikeout);
                    translationAnswerTxt.ForeColor = Color.Red;
                    translationCorrectionLbl.Text = correctionDict[gap];
                }
            }

            if (trainer.RunningVerbIndex == trainer.VerbQueue.Count() - 1)
            {
                ChangeActionBtnMode(ActionBtnMode.Finish);
            }
            else
            {
                ChangeActionBtnMode(ActionBtnMode.Next);
            }
            actionBtn.Focus();
            return false;
        }

        private void ClearAnswerAndCorrection()
        {
            allAnswerTxt.ForEach(x => { x.Text = ""; x.ForeColor = Color.Black; x.Font = new Font(new FontFamily("Segoe UI"), 9.75f); });

            allCorrectionLbl.ForEach(x => { x.Text = ""; });

            scoreStateLbl.Text = "";
        }

        private void EditVerbsBtn_Click(object sender, EventArgs e)
        {
            EditVerbsForm editVerbsForm = new EditVerbsForm();
            Point location = this.PointToScreen(Point.Empty);
            editVerbsForm.Location = new Point(location.X + (this.Width / 2) - (editVerbsForm.Width / 2),
                location.Y + (this.Height / 2) - (editVerbsForm.Height / 2) - 30);
            editVerbsForm.ShowDialog();

            ResetTraining();

            UpdateLoadedFileLbl();
        }

        private void EventLinker_ScoreUpdate(object sender, EventArgs e)
        {
            if (InvokeRequired) // En cas d'appel de cette fonction depuis un autre thread
            {
                Invoke(new EventLinker_ScoreUpdateDelegate(this.EventLinker_ScoreUpdate), sender, e);
                return;
            }

            ScoreUpdateEventArgs args = (ScoreUpdateEventArgs)e;

            // Make 4 spaces at the end of the score label for flame picture
            if (trainer.Parameters.Mode == AnswerMode.Normal)
            {
                if (args.TotalVerbs == 0)
                {
                    scoreLbl.Text = "Score: 0    ";
                }
                else
                {
                    scoreLbl.Text = "Score: " + trainer.Flames + "    ";
                }

                if (trainer.Flames >= 20 | args.TotalVerbs == 0)
                {
                    scoreLbl.ForeColor = Color.Black;
                }
                else if (trainer.Flames > 0)
                {
                    scoreLbl.ForeColor = Color.DarkOrange;
                }
                else if (trainer.Flames <= 0)
                {
                    scoreLbl.ForeColor = Color.Red;
                }
            }

            if (args.LastMistakesNumber == -1)
            {
                scoreStateLbl.Text = "";
            }
            else if (args.LastMistakesNumber == 0)
            {
                scoreStateLbl.Text = "Well done!";
                scoreStateLbl.Font = new Font(new FontFamily("Segoe UI Semibold"), 9.75f);
                scoreStateLbl.ForeColor = Color.Green;
            }
            else
            {
                if (args.RemainingChances > -1)
                {
                    scoreStateLbl.Text = args.LastMistakesNumber + " verb form" + StringTool.AddSOrNot(args.LastMistakesNumber)
                        + " " + StringTool.IsOrAre(args.LastMistakesNumber) + " incorrect. ("
                    + args.RemainingChances + " chance" + StringTool.AddSOrNot(args.RemainingChances) + " left)";
                    scoreStateLbl.Font = new Font(new FontFamily("Segoe UI Semibold"), 9.75f);
                    scoreStateLbl.ForeColor = Color.Red;
                }
                else
                {
                    scoreStateLbl.Text = args.LastMistakesNumber + " verb form" + StringTool.AddSOrNot(args.LastMistakesNumber)
                        + " " + StringTool.IsOrAre(args.LastMistakesNumber) + " incorrect.";
                    scoreStateLbl.Font = new Font(new FontFamily("Segoe UI Semibold"), 9.75f);
                    scoreStateLbl.ForeColor = Color.Red;
                }
            }
        }

        private void FocusFirstUnfilledGap()
        {
            allAnswerTxt.Where(x => x.ReadOnly == false).First().Focus();
        }

        private void FreeAnswer(params Gaps[] gapsArg)
        {
            foreach (Gaps gap in gapsArg)
            {
                switch (gap)
                {
                    case Gaps.All:
                        allAnswerTxt.ForEach(x => { x.ReadOnly = false; x.TabStop = true; });
                        break;

                    case Gaps.Infinitive:
                        infinitiveAnswerTxt.ReadOnly = false;
                        infinitiveAnswerTxt.TabStop = true;
                        break;

                    case Gaps.Preterit:
                        preteritAnswerTxt.ReadOnly = false;
                        preteritAnswerTxt.TabStop = true;
                        break;

                    case Gaps.PresentPerfect:
                        ppAnswerTxt.ReadOnly = false;
                        ppAnswerTxt.TabStop = true;
                        break;

                    case Gaps.Translation:
                        translationAnswerTxt.ReadOnly = false;
                        translationAnswerTxt.TabStop = true;
                        break;
                }
            }
        }

        private void FreeUnfilledGaps()
        {
            if (infinitiveAnswerTxt.Text == "")
            {
                FreeAnswer(Gaps.Infinitive);
            }

            if (preteritAnswerTxt.Text == "")
            {
                FreeAnswer(Gaps.Preterit);
            }

            if (ppAnswerTxt.Text == "")
            {
                FreeAnswer(Gaps.PresentPerfect);
            }

            if (translationAnswerTxt.Text == "")
            {
                FreeAnswer(Gaps.Translation);
            }
        }

        private OptionsArgs GatherParamsToOptionArgs()
        {
            return new OptionsArgs(Properties.Settings.Default.answerMode,
                Properties.Settings.Default.timerModeNumberOfVerbs,
                Properties.Settings.Default.timerModeTiming,
                Properties.Settings.Default.infinitiveGap,
                Properties.Settings.Default.preteritGap,
                Properties.Settings.Default.ppGap,
                Properties.Settings.Default.translationGap,
                Properties.Settings.Default.randomGaps,
                Properties.Settings.Default.verbApparitionMode,
                Properties.Settings.Default.availableChances,
                Properties.Settings.Default.wonAddPoints,
                Properties.Settings.Default.lostRemovePoints,
                Properties.Settings.Default.passedRemovePoints);
        }

        private void LoadedFileLbl_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.verbsFilePath != "")
            {
                Process.Start(Path.GetDirectoryName(Properties.Settings.Default.verbsFilePath));
            }
        }

        private void NextQuestion()
        {
            ClearAnswerAndCorrection();

            ParseVerbFilledGaps(trainer.GetNextVerb());

            FreeUnfilledGaps();

            ChangeActionBtnMode(ActionBtnMode.Correction);

            if (trainer.VerbQueue.Count() - 1 == trainer.RunningVerbIndex) // If last verb
            {
                passBtn.Enabled = false;
            }

            FocusFirstUnfilledGap();
        }

        private void OptionsBtn_Click(object sender, EventArgs e)
        {
            OptionsTrainForm optionsTrainForm = new OptionsTrainForm();
            Point location = this.PointToScreen(Point.Empty);
            optionsTrainForm.Location = new Point(location.X + (this.Width / 2) - (optionsTrainForm.Width / 2),
                location.Y + (this.Height / 2) - (optionsTrainForm.Height / 2) - 30);

            if (optionsTrainForm.ShowDialog() == DialogResult.OK)
            {
                ResetTraining();
            }

            UpdateWindowMode();
        }

        /// <summary>
        /// Parse given verbs forms and block them for the user to fill remaining gaps
        /// </summary>
        private void ParseVerbFilledGaps(Dictionary<Gaps, string> filledGaps)
        {
            foreach (Gaps gap in filledGaps.Keys)
            {
                switch (gap)
                {
                    case Gaps.Infinitive:
                        infinitiveAnswerTxt.Text = filledGaps[gap];
                        BlockAnswer(Gaps.Infinitive);
                        break;

                    case Gaps.Preterit:
                        preteritAnswerTxt.Text = filledGaps[gap];
                        BlockAnswer(Gaps.Preterit);
                        break;

                    case Gaps.PresentPerfect:
                        ppAnswerTxt.Text = filledGaps[gap];
                        BlockAnswer(Gaps.PresentPerfect);
                        break;

                    case Gaps.Translation:
                        translationAnswerTxt.Text = filledGaps[gap];
                        BlockAnswer(Gaps.Translation);
                        break;
                }
            }
        }

        private void PassBtn_Click(object sender, EventArgs e)
        {
            trainer.PassRunningVerb();

            NextQuestion();
        }

        private void ResetTraining()
        {
            passBtn.Enabled = false;

            ChangeActionBtnMode(ActionBtnMode.Start);

            ClearAnswerAndCorrection();

            BlockAnswer(Gaps.All);
        }

        private void ScoreLbl_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.answerMode == AnswerMode.Normal)
            {
                toolTip1.Show("The more flames you have, the best you are! (100 flames max.)", scoreLbl);
            }
            else
            {
                toolTip1.Show("In \"Against the Clock\" mode, the training ends when time is over or if you did all the verbs in the list.", scoreLbl);
            }
        }

        private void ShowEndScreen()
        {
            EndScreenForm endScreenForm;
            if (trainer.Parameters.Mode == AnswerMode.Normal)
            {
                endScreenForm = new EndScreenForm(trainer.Flames, trainer.WonVerbs, trainer.TotalVerbs, trainer.Duration, trainer.VerbAnswers.ToArray(),
                    trainer.StartDate, Path.GetFileName(Properties.Settings.Default.verbsFilePath));
            }
            else
            {
                endScreenForm = new EndScreenForm(trainer.Flames, trainer.TimerObjectiveWon, trainer.LastTrainEndedTimeOver, trainer.WonVerbs, trainer.TotalVerbs,
                    trainer.Parameters.TimerNumberOfVerbs, trainer.Parameters.TimerTiming, trainer.Duration, trainer.VerbAnswers.ToArray(), trainer.StartDate,
                    Path.GetFileName(Properties.Settings.Default.verbsFilePath));
            }
            
            Point location = this.PointToScreen(Point.Empty);
            endScreenForm.Location = new Point(location.X + (this.Width / 2) - (endScreenForm.Width / 2),
                location.Y + (this.Height / 2) - (endScreenForm.Height / 2) - 30);

            endScreenForm.ShowDialog();
        }

        private void StartTraining()
        {
            if (Properties.Settings.Default.verbsFilePath == "")
            {
                MessageBox.Show(this, "Please create a list of irregular verbs and save it using the \"Edit Verbs List\" button.", this.Text + " - Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                editVerbsBtn.Focus();
                return;
            }

            if (trainer != null)
            {
                trainer.Dispose();
            }
            trainer = new Trainer(XmlEditor.ReadDictionnaryInFile(Properties.Settings.Default.verbsFilePath), GatherParamsToOptionArgs());

            ClearAnswerAndCorrection();

            trainer.Start();

            NextQuestion();
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            StopTraining();
            ShowEndScreen();
        }

        private void StopTraining()
        {
            trainer.Stop();

            ClearAnswerAndCorrection();

            ChangeActionBtnMode(ActionBtnMode.Start);

            BlockAnswer(Gaps.All);

            if (Properties.Settings.Default.answerMode == AnswerMode.Timer)
            {
                scoreLbl.ForeColor = Color.Black;
                scoreLbl.Text = "     Remaining time: " + Properties.Settings.Default.timerModeTiming.ToString();
            }
        }

        private void UpdateLoadedFileLbl()
        {
            loadedFileLbl.Text = "Loaded list file: ";

            if (Properties.Settings.Default.verbsFilePath == "")
            {
                loadedFileLbl.Text += "None";
            }
            else
            {
                loadedFileLbl.Text += Path.GetFileName(Properties.Settings.Default.verbsFilePath);
            }
        }

        private void UpdateWindowMode()
        {
            if (Properties.Settings.Default.answerMode == AnswerMode.Normal)
            {
                scoreLbl.Image = Properties.Resources.flame16;
                scoreLbl.ImageAlign = ContentAlignment.MiddleRight;
                scoreLbl.Text = "Score: 0    ";
                toolTip1.SetToolTip(scoreLbl, "The more flames you have, the best you are! (100 flames max.)");
            }
            else if (Properties.Settings.Default.answerMode == AnswerMode.Timer)
            {
                scoreLbl.Image = Properties.Resources.clock16;
                scoreLbl.ImageAlign = ContentAlignment.MiddleLeft;
                scoreLbl.Text = "     Remaining time: " + Properties.Settings.Default.timerModeTiming;
                toolTip1.SetToolTip(scoreLbl, "In \"Against the Clock\" mode, the training ends when time is over or if you did all the verbs in the list.");
            }
        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            Point location = this.PointToScreen(Point.Empty);
            historyForm.Location = new Point(location.X + (this.Width / 2) - (historyForm.Width / 2),
                location.Y + (this.Height / 2) - (historyForm.Height / 2) - 30);

            historyForm.ShowDialog();
        }
    }
}