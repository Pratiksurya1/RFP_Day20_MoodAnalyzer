using System;

namespace MoodAnalyser
{
    internal class MoodAnalyserAttribute : Attribute
    {
        private string v;

        public MoodAnalyserAttribute(string v)
        {
            this.v = v;
        }
    }
}