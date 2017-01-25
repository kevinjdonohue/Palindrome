using System.Text;

namespace Palindrome
{
    public class PalindromeTester
    {
        public bool IsPalindromeWord(string word)
        {
            int endIndex = word.Length - 1;

            for (int i = 0; i < word.Length / 2; i++)
            {
                char startCharacter = word[i];
                char endCharacter = word[endIndex - i];

                if (startCharacter != endCharacter)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsPalindromeSentence(string sentence)
        {
            return IsPalindromeWord(CleanSentenceAndConvertToAWord(sentence));
        }

        private string CleanSentenceAndConvertToAWord(string sentence)
        {
            StringBuilder candidate = new StringBuilder();

            foreach (char currentCharacter in sentence)
            {
                if (char.IsLetterOrDigit(currentCharacter))
                {
                    candidate.Append(char.ToLower(currentCharacter));
                }
            }
            return candidate.ToString();
        }
    }
}
