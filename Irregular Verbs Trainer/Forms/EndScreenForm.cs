using IVT.Tools;
using System;
using System.Drawing;
using System.Windows.Forms;
using IVT.Objects;
namespace IVT.Forms
{
    public partial class EndScreenForm : Form
    {
        private double AverageSpeed;
        private DateTime Date;
        private TimeSpan Duration;
        private int MinimumVerbs;
        private AnswerMode Mode;
        private double ObjectiveSpeed;
        private bool ObjectiveWon;
        private int Score;
        private bool TimeOver;
        private TimeSpan TimerObjectiveTime;
        private int TotalVerbs;
        private double WinPercentage;
        private int WonVerbs;
        private VerbAnswer[] VerbAnswers;
        private string ListName;

        public EndScreenForm(int score, int wonVerbs, int totalVerbs, TimeSpan duration, VerbAnswer[] verbAnswers, DateTime date, string listName)
        {
            InitializeComponent();

            Mode = AnswerMode.Normal;
            Score = score;
            WonVerbs = wonVerbs;
            TotalVerbs = totalVerbs;
            Duration = duration;
            VerbAnswers = verbAnswers;
            Date = date;
            ListName = listName;

            if (TotalVerbs != 0)
            {
                WinPercentage = WonVerbs * 100 / TotalVerbs;
            }
            else
            {
                WinPercentage = 0;
            }
            AverageSpeed = WonVerbs / Duration.TotalMinutes;

            scoreBtn.Text = "Final score: " + score;
            if (Score >= 20)
            {
                scoreBtn.ForeColor = Color.Green;
            }
            else if (Score >= 0)
            {
                scoreBtn.ForeColor = Color.Orange;
            }
            else
            {
                scoreBtn.ForeColor = Color.Red;
            }
            scoreBtn.Image = Properties.Resources.flame16;
            winPercentageLbl.Text = "Win Percentage: " + WinPercentage + "%";
            wonOutOfTotalLbl.Text = WonVerbs + " verb" + StringTool.AddSOrNot(WonVerbs) + " won out of " + TotalVerbs;
            averageSpeedLbl.Text = "Average Speed: " + Math.Round(AverageSpeed, 2).ToString() + " verbs/minute";
            totalTimeLbl.Text = "Total time: " + Duration.ToString(@"hh\:mm\:ss");

            AddToHistorical();
        }

        public EndScreenForm(int score, bool objectiveWon, bool timeOver, int wonVerbs, int totalVerbs, int minimumVerbs, TimeSpan timerObjectiveTime,
            TimeSpan duration, VerbAnswer[] verbAnswers, DateTime date, string listName)
        {
            InitializeComponent();

            Score = score;
            Mode = AnswerMode.Timer;
            ObjectiveWon = objectiveWon;
            TimeOver = timeOver;
            WonVerbs = wonVerbs;
            TotalVerbs = totalVerbs;
            Duration = duration;
            MinimumVerbs = minimumVerbs;
            TimerObjectiveTime = timerObjectiveTime;
            VerbAnswers = verbAnswers;
            Date = date;
            ListName = listName;

            ObjectiveSpeed = MinimumVerbs / TimerObjectiveTime.TotalMinutes;

            if (TotalVerbs != 0)
            {
                WinPercentage = WonVerbs * 100d / TotalVerbs;
            }
            else
            {
                WinPercentage = 0;
            }
            AverageSpeed = WonVerbs / Duration.TotalMinutes;

            if (TimeOver)
            {
                titleLbl.Text = "Time over!";
                statsTitleLbl.Text = "Stats";
                statsTitleLbl.Location = new Point(statsTitleLbl.Location.X + 19, statsTitleLbl.Location.Y);
            }

            if (ObjectiveWon)
            {
                scoreBtn.Text = "Against the Watch:" + Environment.NewLine + "Objective reached!";
                scoreBtn.ForeColor = Color.Green;
            }
            else
            {
                scoreBtn.Text = "Against the Watch:" + Environment.NewLine + "Objective failed.";
                scoreBtn.ForeColor = Color.Red;
            }
            scoreBtn.Image = null;
            scoreBtn.TextAlign = ContentAlignment.MiddleCenter;

            winPercentageLbl.Text = "Win Percentage: " + Math.Round(WinPercentage, 1) + "%";
            wonOutOfTotalLbl.Text = WonVerbs + " verb" + StringTool.AddSOrNot(WonVerbs) + " won out of " + TotalVerbs + ", objective was " + MinimumVerbs;
            averageSpeedLbl.Text = "Average Speed: " + Math.Round(AverageSpeed, 2).ToString() + " verbs/minute";
            totalTimeLbl.Text = "Speed objective: " + Math.Round(ObjectiveSpeed, 2).ToString() + " verbs/minute";

            AddToHistorical();
        }

        private void AddToHistorical()
        {
            HistoryManager.AddTrainingHistory(new TrainingHistory(AverageSpeed,
                Date,
                Duration,
                ListName,
                MinimumVerbs,
                Mode,
                ObjectiveSpeed,
                ObjectiveWon,
                Score,
                TimeOver,
                TimerObjectiveTime,
                TotalVerbs,
                WinPercentage,
                WonVerbs,
                VerbAnswers));
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MoreBtn_Click(object sender, EventArgs e)
        {
            DetailedStatsForm detailedStatsForm = new DetailedStatsForm(new TrainingHistory(AverageSpeed,
                Date,
                Duration,
                ListName,
                MinimumVerbs,
                Mode,
                ObjectiveSpeed,
                ObjectiveWon,
                Score,
                TimeOver,
                TimerObjectiveTime,
                TotalVerbs,
                WinPercentage,
                WonVerbs,
                VerbAnswers));
            Point location = this.PointToScreen(Point.Empty);
            detailedStatsForm.Location = new Point(location.X + (this.Width / 2) - (detailedStatsForm.Width / 2),
                location.Y + (this.Height / 2) - (detailedStatsForm.Height / 2) - 30);

            detailedStatsForm.ShowDialog();
        }
    }
}