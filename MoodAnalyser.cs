using System;

namespace TestProject2
{
    internal class MoodAnalyser
    {
        public MoodAnalyser()
        {
        }

        public MoodAnalyser(string message)
        {
            Message = message;
        }

        public string Message { get; }

        internal void AnalyzeMood()
        {
            throw new NotImplementedException();
        }
    }
}