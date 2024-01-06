using System.Globalization;
using System.Text;

namespace AlgorithmPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(binToDec("110"));
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

        public static int DigitalRoot(long n)
        {
            // Your awesome code here!
            var result = 0;
            var spl = n.ToString().ToCharArray();
            while (spl.Length > 1)
            {
                result = 0;
                foreach (var item in spl)
                {
                    result += int.Parse(item.ToString());
                };
                spl = result.ToString().ToCharArray();

            }
                return result;
        }

        public static string DuplicateEncode(string word)
        {
            var wordCount = new Dictionary<string, int>();
            var result = string.Empty;

            foreach (var item in word)
            {
                if (wordCount.ContainsKey(item.ToString()))
                {
                    wordCount[item.ToString()]++;
                }
                else
                {
                    wordCount.Add(item.ToString(), 1);
                }

            }

            foreach (var item in word)
            {
                if (wordCount[item.ToString()] > 1)
                {
                    result += ")";
                }
                else { result += "("; }
            }

            return result.ToString();
        }

        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Length < 10 || walk.Length > 10)
                return false;

            for (int i = 0; i < walk.Length; i++)
            {
                if (i == walk.Length - 1) break;
                if (walk[i] == walk[i + 1])
                    return false;
            }

            return true;
        }

        public int GetSum(int a, int b)
        {
            if (a == b) return a;
            var result = 0;
            var temp = 0;
            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }

            for (int i = a; i <= b; i++)
            {
                result += i;
            }

            return result;
        }

        public static bool ValidatePin(string pin)
        {
            return pin.All(n => Char.IsDigit(n)) && (pin.Length == 4 || pin.Length == 6);
        }

        public static int binToDec(string s)
        {
            int total = 0;
            var newStr = s.Reverse();
            var p = 0;
            foreach (var item in newStr)
            {
               
                total += int.Parse(Math.Pow(2, p).ToString()) * int.Parse(item.ToString());
                p++;
            };
            return total;
        }
    } 
}
