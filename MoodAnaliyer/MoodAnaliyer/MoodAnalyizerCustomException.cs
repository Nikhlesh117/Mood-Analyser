using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnaliyer
{
    public class MoodAnalyizerCustomException : Exception
    {
        public enum MoodAnalyzeEnum
        {
            NULL_MOOD,EMPTY_MOOD
        }
        public MoodAnalyzeEnum enumOje;
        public MoodAnalyizerCustomException(MoodAnalyzeEnum enumOje, string message) : base(message)
        {
            this.enumOje = enumOje;
        }

    }
}
