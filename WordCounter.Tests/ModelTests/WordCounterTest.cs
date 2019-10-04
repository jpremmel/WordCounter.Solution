using Microsoft.VisualStudio.TestTools.UnitTesting;
using SentenceTools;

namespace SentenceTools.Test
{
    [TestClass]
    public class RepeatCounterTest
    {
        RepeatCounter testCounter = new RepeatCounter();

        [TestMethod]
        public void CountRepeats_SingleWordSearch_TryAgain()
        {
            Assert.AreEqual(-1, testCounter.CountRepeats("I own a Cat.", "cat dog"));
        }

        [TestMethod]
        public void CountRepeats_IgnoreCase_1()
        {
            Assert.AreEqual(1, testCounter.CountRepeats("Cat", "cat"));
        }
    }
}