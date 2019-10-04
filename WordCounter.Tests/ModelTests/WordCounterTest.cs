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
            Assert.AreEqual("Can only search for a single word. Please try again.", testCounter.CheckValidity("I own a Cat.", "cat dog"));
        }

        [TestMethod]
        public void CountRepeats_IgnoreCase_1()
        {
            Assert.AreEqual(1, testCounter.CountRepeats("Cat", "cat"));
        }

        [TestMethod]
        public void CountRepeats_CompareSingleWord_0()
        {
            Assert.AreEqual(0, testCounter.CountRepeats("dog", "cat"));
        }

        [TestMethod]
        public void CountRepeats_SingleWordPresentInSentence_2()
        {
            Assert.AreEqual(2, testCounter.CountRepeats("I own a cat and you own a cat", "cat"));
        }

        [TestMethod]
        public void CountRepeats_RemovePunctuation_2()
        {
            Assert.AreEqual(2, testCounter.CountRepeats("I own a cat and you own a cat.", "cat"));
        }
    }
}