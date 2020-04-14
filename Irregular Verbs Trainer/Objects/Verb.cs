using System;

namespace IVT.Objects
{
    [Serializable]
    public class Verb
    {
        private string infinitive;
        private string presentPerfect;
        private string preterit;
        private string translation;

        public Verb(string infinitive, string preterit, string presentPerfect, string translation)
        {
            this.infinitive = infinitive;
            this.preterit = preterit;
            this.presentPerfect = presentPerfect;
            this.translation = translation;
        }

        public string Infinitive { get => infinitive; set => infinitive = value; }
        public string PresentPerfect { get => presentPerfect; set => presentPerfect = value; }
        public string Preterit { get => preterit; set => preterit = value; }
        public string Translation { get => translation; set => translation = value; }
    }
}