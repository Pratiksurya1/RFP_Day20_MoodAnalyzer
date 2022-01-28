using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    
    internal class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string message)
        {
            this.message = message; 
        }

        public string AnalyzeMood()
        {
            try 
            {
                if (message.Equals(String.Empty))
                    throw new NullMoodException(NullMoodException.UserException.NullMoodException, "Mood should not be empty");

                else if (message.ToLower().Contains("happy"))
                    return "happy";
                else
                    return "sad";
            }
            catch (NullReferenceException)
            {
                return "happy";
            }
        }
    }
}
