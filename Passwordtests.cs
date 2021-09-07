using System;
using Xunit;
using Lesson;
namespace XunitTests
{
    public class PasswordTests
    {
        [Theory]
        [InlineData("AbcdE123@$#!", true)]
        [InlineData("Avfds@$#54334@$", true)]
        [InlineData("hectorasdioufghsuo@F$#dfgduh22", true)]
        
       
        public void CheckStrongPassWord(string pass, bool expected)
        {
            //Act
            var actual = Password.IsStrong(pass);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("AbcdEA123@$#!", true)]
        [InlineData("aaaAAAffff", true)]
        public void HasCapital(string pass, bool expected)
        {
            //Act
            var actual = Password.HasCapital(pass);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("AbcdEA123@$#!", true)]
        [InlineData("aaaAAAffff", true)]
        public void HasLower(string pass, bool expected)
        {
            //Act
            var actual = Password.HasLower(pass);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("AbcdE234A123@$#!", true)]
        [InlineData("aa234aAAAffff", true)]
        public void HasDigit(string pass, bool expected)
        {
            //Act
            var actual = Password.HasDigit(pass);
            //Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("AbcdE234A123@$#!", true)]
        [InlineData("aa234aA$$$AAffff", true)]
        //[InlineData("||", true)]
       // [InlineData("\n", true)]
        
        public void HasSymbol(string pass, bool expected)
        {
            //Act
            var actual = Password.IsStrong(pass);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("abcdjsds", true)]
        [InlineData("asdasdddd", true)]
        public void HasProperLength(string pass, bool expected)
        {
            //Act
            var actual = Password.HasProperLength(pass);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}