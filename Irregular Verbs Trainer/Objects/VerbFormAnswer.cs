using System;
using System.Collections.Generic;

namespace IVT.Objects
{
    [Serializable]
    public class VerbFormAnswer
    {
        private bool _answeredCorrectly = false;

        public VerbFormAnswer(bool notAnswerable = false)
        {
            NotAnswerable = notAnswerable;
        }

        public bool AnsweredCorrectly
        {
            get
            {
                return _answeredCorrectly;
            }
            set
            {
                if (NotAnswerable)
                {
                    throw new Exception("Trying to set 'ansered correctly' to a non answerable verb form.");
                }

                _answeredCorrectly = value;
            }
        }

        public bool NotAnswerable { get; private set; }
        public List<string> WrongAnswers { get; private set; } = new List<string>();

        public void AddWrongAnswer(string wrongAnswer)
        {
            if (NotAnswerable)
            {
                throw new Exception("Trying to add a wrong answer to a non answerable verb form.");
            }

            WrongAnswers.Add(wrongAnswer);
        }
    }
}