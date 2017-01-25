using FluentAssertions;
using Palindrome;
using Xunit;

namespace CheckerTests
{
    public class PalindromeTesterTests
    {
        [Theory]
        [InlineData("civic")]
        [InlineData("deified")]
        [InlineData("deleveled")]
        [InlineData("devoved")]
        [InlineData("hannah")]
        [InlineData("kayak")]
        [InlineData("level")]
        [InlineData("reviver")]
        public void IsPalindromeWord_ShouldReturnTrue_GivenAValidWord(string word)
        {
            //arrange
            PalindromeTester tester = new PalindromeTester();

            //act
            bool result = tester.IsPalindromeWord(word);

            //assert
            result.Should().BeTrue($"because {word} is a palindrome");
        }

        [Theory]
        [InlineData("civiC")]
        [InlineData("deifieD")]       
        [InlineData("Hannah")]
        [InlineData("leveled")]        
        public void IsPalindromeWord_ShouldReturnFalse_GivenAValidPalidrome(string word)
        {
            //arrange
            PalindromeTester tester = new PalindromeTester();

            //act
            bool result = tester.IsPalindromeWord(word);

            //assert
            result.Should().BeFalse($"because {word} is not a palindrome");
        }

        [Theory]
        [InlineData("A man, a plan, a canal: Panama.")]
        [InlineData("A Toyota. Race fast, safe car. A Toyota.")]
        [InlineData("Cigar? Toss it in a can. It is so tragic.")]
        [InlineData("Murder for a jar of red rum.")]
        public void IsPalindromeSentence_ShouldReturnTrue_GivenAValidSentence(string sentence)
        {
            //arrange
            PalindromeTester tester = new PalindromeTester();

            //act
            bool result = tester.IsPalindromeSentence(sentence);

            //assert
            result.Should().BeTrue($"because {sentence} is a palindrome");
        }
    }
}
