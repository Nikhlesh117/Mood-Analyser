using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (message.Contains("Sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
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
