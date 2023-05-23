using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MoodAnaliyer.MoodAnalyizerCustomException;

namespace MoodAnaliyer
{
    public class MoodAnalyzer
    {
        string message;
        public MoodAnalyzer()
        {

        }
        public MoodAnalyzer (string message)
        {
            this.message = message;
        }
        public string AnalyzeMood(string message)
        {
            if(message.Equals(String.Empty))
            {
                throw new MoodAnalyizerCustomException(MoodAnalyzeEnum.EMPTY_MOOD, "Empty Input");
            }
            try
            {
                if (this.message.Contains("Sad"))

                    return "Sad";
                else

                    return "Happy";
            }
            catch(NullReferenceException) 
            {
                throw new MoodAnalyizerCustomException(MoodAnalyzeEnum.NULL_MOOD, "Null Input");
            }
        }
        public string AnalyzeMood()
        {
            if (message.Contains("Sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }
    }
}
