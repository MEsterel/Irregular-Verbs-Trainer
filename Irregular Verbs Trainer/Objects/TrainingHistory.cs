using System;
using System.Collections.Generic;
using System.Configuration;

namespace IVT.Objects
{
    [Serializable]
    public class TrainingHistory
    {
        public double AverageSpeed { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Duration { get; set; }
        public string ListName { get; set; }
        public int MinimumVerbs { get; set; }
        public AnswerMode Mode { get; set; }
        public double ObjectiveSpeed { get; set; }
        public bool ObjectiveWon { get; set; }
        public int Score { get; set; }
        public bool TimeOver { get; set; }
        public TimeSpan TimerObjectiveTime { get; set; }
        public int TotalVerbs { get; set; }
        public VerbAnswer[] VerbAnswers { get; set; }
        public double WinPercentage { get; set; }
        public int WonVerbs { get; set; }

        public TrainingHistory(double averageSpeed,
            DateTime date,
            TimeSpan duration,
            string listName,
            int minimumVerbs,
            AnswerMode mode,
            double objectiveSpeed,
            bool objectiveWon,
            int score,
            bool timeOver,
            TimeSpan timerObjectiveTime,
            int totalVerbs,
            double winPercentage,
            int wonVerbs,
            VerbAnswer[] verbAnswers)
        {
            AverageSpeed = averageSpeed;
            Date = date;
            Duration = duration;
            ListName = listName;
            MinimumVerbs = minimumVerbs;
            Mode = mode;
            ObjectiveSpeed = objectiveSpeed;
            ObjectiveWon = objectiveWon;
            Score = score;
            TimeOver = timeOver;
            TimerObjectiveTime = timerObjectiveTime;
            TotalVerbs = totalVerbs;
            WinPercentage = winPercentage;
            WonVerbs = wonVerbs;
            VerbAnswers = verbAnswers;
        }
    }
}