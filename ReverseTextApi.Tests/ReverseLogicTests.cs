using Xunit;

namespace ReverseTextApi.Tests
{
    public class ReverseLogicTests
    {
        [Fact]
        public void ReverseText_ShouldReturnReversedString()
        {
            
            var input = "hello world";
            var expected = "dlrow olleh";

            
            var actual = new string(input.Reverse().ToArray());

            
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseText_EmptyString_ShouldReturnEmptyString()
        {
            var input = "";
            var expected = "";
            var actual = new string(input.Reverse().ToArray());
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseText_SingleCharacter_ShouldReturnSameCharacter()
        {
            var input = "A";
            var expected = "A";
            var actual = new string(input.Reverse().ToArray());
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseText_SpecialCharacters_ShouldReverseCorrectly()
        {
            var input = "!@#";
            var expected = "#@!";
            var actual = new string(input.Reverse().ToArray());
            Assert.Equal(expected, actual);
        }
    }
}
