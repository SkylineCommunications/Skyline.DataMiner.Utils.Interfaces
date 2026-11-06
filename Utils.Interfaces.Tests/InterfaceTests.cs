namespace Skyline.DataMiner.Utils.Interfaces.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Skyline.DataMiner.Utils.Interfaces;

    [TestClass]
    public class InterfaceTests
    {
        #region CalculateUtilization
        [TestMethod]
        public void CalculateUtilization_FullDuplex()
        {
            double expected = 40;
            double result = Interface.CalculateUtilization(1500, 2000, 5000, DuplexStatus.FullDuplex);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateUtilization_HalfDuplex()
        {
            double expected = 70;
            double result = Interface.CalculateUtilization(1500, 2000, 5000, DuplexStatus.HalfDuplex);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateUtilization_InvalidDuplexStatus_NA()
        {
            double expected = -1;
            double result = Interface.CalculateUtilization(1500, 2000, 0, DuplexStatus.NotInitialized);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateUtilization_InvalidDuplexStatus_Unknown()
        {
            double expected = -1;
            double result = Interface.CalculateUtilization(1500, 2000, 0, DuplexStatus.Unknown);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateUtilization_InvalidInputRate()
        {
            double expected = -1;
            double result = Interface.CalculateUtilization(-1, 2000, 5000, DuplexStatus.FullDuplex);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateUtilization_InvalidOutputRate()
        {
            double expected = -1;
            double result = Interface.CalculateUtilization(1500, -1, 5000, DuplexStatus.FullDuplex);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateUtilization_InvalidSpeed()
        {
            double expected = -1;
            double result = Interface.CalculateUtilization(1500, 2000, 0, DuplexStatus.FullDuplex);

            Assert.AreEqual(expected, result);
        }
        #endregion

        #region HasDiscontinuity
        [TestMethod]
        public void HasDiscontinuity_False()
        {
            bool expected = false;
            bool result = Interface.HasDiscontinuity("0", "0");

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void HasDiscontinuity_True()
        {
            bool expected = true;
            bool result = Interface.HasDiscontinuity("0", "1");

            Assert.AreEqual(expected, result);
        }
        #endregion
    }
}
