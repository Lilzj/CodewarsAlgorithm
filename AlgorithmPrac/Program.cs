using System.Globalization;
using System.Text;

namespace AlgorithmPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(XO("zpzpzpzp"));
        }

        public static int Quadrant(int x, int y)
        {

            return (x > 0 && y > 0) ? 1 : (x < 0 && y > 0) ? 2 : (x > 0 && y < 0) ? 4 : 3;
        }
        public static string JadenCasingStrings(string phrase)
        {
            var wod = phrase.Split(" ");
            var result = new StringBuilder();
            for (int i = 0; i < wod.Length; i++)
            {
                var ch = wod[i][0].ToString().ToUpper() + wod[i].Substring(1);
                result.Append(ch + " ");
            }
            return result.ToString().TrimEnd();
        }
        public static IEnumerable<string> CategorizeNewMember(int[][] data)
        {
            var result = new List<string>();
            for (int j = 0; j < data.Length; j++)
            {
                if (data[j][0] >= 55 && data[j][1] > 7)
                {
                    result.Add("Senior");
                }
                else
                {
                    result.Add("Open");
                }

            }
            return result;
        }

        public static long Playingwithdigits(int n, int p)
        {

            // your code
            var cha = n.ToString().ToCharArray();
            long total = 0;

            foreach (var item in cha)
            {
                total += long.Parse(Math.Pow(long.Parse(item.ToString()), p).ToString());
                p++;
            }

            if (total % n == 0)
            {
                return total / n;
            }
            return -1;
        }

        public static bool ExesandOhs(string input)
        {
            var words = input.ToCharArray();
            var x = new List<string>();
            var o = new List<string>();
            
            if (!words.Contains('x') && !words.Contains('o'))
            {
                return true;
            }

            foreach (var word in words)
            {
                if (word.ToString().ToLower() == "x")
                {
                    x.Add(word.ToString());
                }
                if (word.ToString().ToLower() == "o")
                {
                    x.Add(word.ToString());
                }
            }

            if (x.Count() == o.Count())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    } 
}
