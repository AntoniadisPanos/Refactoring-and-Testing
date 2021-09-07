using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson;
using System;

namespace Ms_Unit_Test
{
    [TestClass]
    public class HelperTests
    {
        [TestMethod]
        public void Calculate_Percentage_TestValid_5000_500_Expected_10()
        {
            //--Arrange
            string target = "5000";
            string real = "500";
            decimal expected = 10M;  //Expected Valid Result

            //--Act
           var actual = Helper.CalculatePercentageGuardFailFast(target, real);

            //-Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_Percentage_TestValid_1000_500_Expected_50()
        {
            //--Arrange
            string target = "1000";
            string real = "500";
            decimal expected = 50M;  //Expected Valid Result

            //--Act
            var actual = Helper.CalculatePercentageGuardFailFast(target, real);

            //-Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_Percentage_TestValid_50_0_Expected_0()
        {
            //--Arrange
            string target = "50";
            string real = "0";
            decimal expected = 0M;  //Expected Valid Result

            //--Act
            var actual = Helper.CalculatePercentageGuardFailFast(target, real);

            //-Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_Percentage_TestValid_15000_15000_Expected_100()
        {
            //--Arrange
            string target = "15000";
            string real = "15000";
            decimal expected = 100M;  //Expected Valid Result

            //--Act
            var actual = Helper.CalculatePercentageGuardFailFast(target, real);

            //-Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_Percentage_TestValid_6_7_Expected_116_666()
        {
            //--Arrange
            string target = "6";
            string real = "7";
            decimal expected = 116.666M;  //Expected Valid Result

            //--Act
            var actual = Helper.CalculatePercentageGuardFailFast(target, real);

            //-Assert
            Assert.AreEqual((double)expected, (double)actual, 0.001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_Percentage_Test_GoalIsNotNumeric_ONE_2000()
        {
            //--Arange
            string target = "one";
            string real = "2000";

            //--Act

            try
            {
                var actual = Helper.CalculatePercentageGuardFailFast(target, real);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Target must be Numeric", ex.Message);
                throw;
            }
        }
    }
}
