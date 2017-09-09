using System.Text;

namespace CodeFight
{
    public class IsCryptSolution
    {
        public bool isCryptSolution(string[] crypt, char[][] solution)
        {
            var res1 = calculateIntegerValue(crypt[0], solution);
            var res2 = calculateIntegerValue(crypt[1], solution);
            var sln = calculateIntegerValue(crypt[2], solution);

            var art = long.Parse(res1) + long.Parse(res2) == long.Parse(sln);
            var res1Leading0 = res1.Length == 1 || !res1.StartsWith("0");
            var res2Leading0 = res2.Length == 1 || !res2.StartsWith("0");
            var resultLeading0 = sln.Length == 1 || !sln.StartsWith("0");
            return art && res1Leading0 && res2Leading0 && resultLeading0;
        }

        private string calculateIntegerValue(string word, char[][] dictionary)
        {
            var sb = new StringBuilder();
            foreach (var chr in word)
            foreach (var dictWord in dictionary)
                if (dictWord[0] == chr)
                    sb.Append(dictWord[1]);

            return sb.ToString();
        }
    }
}