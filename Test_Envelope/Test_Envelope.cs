using System;
using EnvelopeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Envelope
{
    [TestClass]
    public class Test_Envelope
    {
        [TestMethod]
        public void Test_DiagonalFit_success()
        {
            Envelope envelope = new Envelope();
            Assert.AreEqual(true, envelope.DiagonalFit(4.8, 5, 4.8, 2));
        }

        [TestMethod]
        public void Test_DiagonalFit_fail()
        {
            Envelope envelope = new Envelope();
            Assert.AreEqual(false, envelope.DiagonalFit(4.8, 5, 5, 2));
        }
        
    }
}
