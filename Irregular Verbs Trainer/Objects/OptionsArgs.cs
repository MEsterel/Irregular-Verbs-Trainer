using System;

namespace IVT.Objects
{
    public class OptionsArgs
    {
        private VerbsAppartionMode apparitionMode;
        private int availableChances;
        private bool infinitiveGap;
        private int lostRemovePoints;
        private AnswerMode mode;
        private int passedRemovePoints;
        private bool ppGap;
        private bool preteritGap;
        private bool randomGaps;
        private int timerNumberOfVerbs;
        private TimeSpan timerTiming;
        private bool translationGap;
        private int wonAddPoint;

        public OptionsArgs(AnswerMode mode,
            int timerNumberOfVerbs, TimeSpan timerTiming,
            bool infinitiveGap, bool preteritGap, bool ppGap, bool translationGap, bool randomGaps,
            VerbsAppartionMode apparitionMode,
            int availableChances,
            int wonAddPoint,
            int lostRemovePoints,
            int passedRemovePoints)
        {
            this.mode = mode;
            this.timerNumberOfVerbs = timerNumberOfVerbs;
            this.timerTiming = timerTiming;
            this.infinitiveGap = infinitiveGap;
            this.preteritGap = preteritGap;
            this.ppGap = ppGap;
            this.translationGap = translationGap;
            this.randomGaps = randomGaps;
            this.apparitionMode = apparitionMode;
            this.availableChances = availableChances;
            this.wonAddPoint = wonAddPoint;
            this.lostRemovePoints = lostRemovePoints;
            this.passedRemovePoints = passedRemovePoints;
        }

        public VerbsAppartionMode ApparitionMode { get => apparitionMode; set => apparitionMode = value; }
        public int AvailableChances { get => availableChances; set => availableChances = value; }
        public bool InfinitiveGap { get => infinitiveGap; set => infinitiveGap = value; }
        public int LostRemovePoints { get => lostRemovePoints; set => lostRemovePoints = value; }
        public AnswerMode Mode { get => mode; set => mode = value; }
        public int PassedRemovePoints { get => passedRemovePoints; set => passedRemovePoints = value; }
        public bool PpGap { get => ppGap; set => ppGap = value; }
        public bool PreteritGap { get => preteritGap; set => preteritGap = value; }
        public bool RandomGaps { get => randomGaps; set => randomGaps = value; }
        public int TimerNumberOfVerbs { get => timerNumberOfVerbs; set => timerNumberOfVerbs = value; }
        public TimeSpan TimerTiming { get => timerTiming; set => timerTiming = value; }
        public bool TranslationGap { get => translationGap; set => translationGap = value; }
        public int WonAddPoint { get => wonAddPoint; set => wonAddPoint = value; }
    }
}