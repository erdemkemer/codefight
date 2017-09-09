using System.Reflection.Metadata;

namespace FizzBuzz
{
    public class FizzbuzzManager
    {
        public string GetFizzbuzz(int i)
                 {
            var response = "";

            if (i % 3 == 0)
                response += "Fizz";

            if (i % 5 == 0)
                response += "Buzz";

            if (string.IsNullOrEmpty(response))
                response = i.ToString();

            return response;
        }
    }
}