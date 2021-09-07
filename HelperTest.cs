using System;
using Xunit;
using Lesson;

namespace xUnitTests
{
    public class HelperTest
    {
        [Fact]
        public void Claculate_Percentage_Test_Valid_5000_500_10()
        {
            //--Arrange
            string target = "5000";
            string real = "500";
            decimal expected = 10M;

            //--Act
            var actual = Helper.CalculatePercentageGuardFailFast(target, real);

            //--Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Claculate_Percentage_Test_TargetIsNotNumeric()
        {
            //--Arrange
            string target = "one";
            string real = "2000";

            //--Act
           ArgumentException ex = Assert.Throws<ArgumentException>(  ()=> Helper.CalculatePercentageGuardFailFast(target,real)  );

            //--Assert
            Assert.Equal("Target must be Numeric", ex.Message);
        }


        [Theory]
        [InlineData("5000", "500", 10)]
        [InlineData("10000", "1000", 10)]
        [InlineData("500", "50", 10)]
        [InlineData("500", "500", 100)]
        [InlineData("1000", "200", 20)]
        public void Calculate_Percentage_ValidTheory(string target, string real, decimal expected)
        {
            //--Act
            var actual = Helper.CalculatePercentageGuardFailFast(target, real);

            //--Assert
            Assert.Equal(expected, actual);
        }
    }
}
