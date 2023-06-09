using MoodAnaliyer;
using NUnit.Framework.Internal;

namespace MoodAnaliyerNUnitTest
{
    public class Tests
    {
        MoodAnalyzer mood = new MoodAnalyzer();
        [Test]
        public void GiveSadMood()
        {
            string expected = "Sad";
            string actual = mood.AnalyzeMood("I am Sad Mood");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GiveHappyMood()
        {
            string expected = "Happy";
            string actual = mood.AnalyzeMood("I am any Mood");
            Assert.AreEqual(expected, actual);
        }
        
    
        [Test]
        public void ReturnGiveSadMoodConstructor()
        {
            MoodAnalyzer moody = new MoodAnalyzer("I am Sad Mood");
            string expected = "Sad";
            string actual = moody.AnalyzeMood();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReturnGiveHappyMoodConstructor()
        {
            MoodAnalyzer moody = new MoodAnalyzer("I am any Mood");
            string expected = "Happy";
            string actual = moody.AnalyzeMood();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Null_Return_Using_Custom_Exception()
        {

            MoodAnalyzer moody = new MoodAnalyzer(null);
            try
            {
                string result = moody.AnalyzeMood();

            }
            catch(MoodAnalyizerCustomException e)
            { 
                Assert.AreEqual("Null Input",e.Message);
            }
        }

        public void Empty_Return_Using_Custom_Exception()
        {
            MoodAnalyzer moody = new MoodAnalyzer(string.Empty);
            try
            {
                string result = moody.AnalyzeMood();

            }
            catch (MoodAnalyizerCustomException e)
            {
                Assert.AreEqual("Null Input", e.Message);
            }
        }
    }
}