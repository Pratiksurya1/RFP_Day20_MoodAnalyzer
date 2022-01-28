using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnalyser moodAnalyser;
        public string message = " I am in happy Mood";
        [TestInitialize]
        public void SetUp()
        {
            moodAnalyser = new MoodAnalyser(message);
        }
        [TestMethod]
        public void TestHappyMood()
        {
            string expected = "happy";

            string actual = moodAnalyser.AnalyzeMood();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSadMood()
        {
            string expected = "sad";
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in sad Mood");
            string actual = moodAnalyser.AnalyzeMood();
            Assert.AreEqual(expected, actual);
        }
    }
}