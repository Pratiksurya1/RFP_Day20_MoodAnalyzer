using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class NullMoodException : Exception
    {
    public enum UserException
    {
        NullMoodException
    }

    UserException type;
        public NullMoodException(UserException type, String message) : base(message)
        {
            this.type = type;
        }
    } 
}
