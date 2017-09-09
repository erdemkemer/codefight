namespace Solutions
{
    public class Palindrome
    {
        public bool CheckPalindrome(string inputString) {
            if (string.IsNullOrEmpty(inputString))
                return false;
            int startIndex = 0, endIndex = inputString.Length -1;
            while(startIndex <= endIndex)
            {
                if (inputString[startIndex] != inputString[endIndex])
                    return false;
                
                startIndex++;
                endIndex--;
            }
            return true;
        }
    }
}