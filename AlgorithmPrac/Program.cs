using System.Globalization;
using System.Text;

namespace AlgorithmPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CategorizeNewMember(new[] { new[] { 45, 12 }, new[] { 55, 21 }}));
        }

        public static int Quadrant(int x, int y)
        {

            return (x > 0 && y > 0) ? 1 : (x < 0 && y > 0) ? 2 : (x > 0 && y < 0) ? 4 : 3;
        }
        public static string JadenCasingStrings(string phrase)
        {
            var wod =  phrase.Split(" ");
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
                for ( int j = 0; j < data.Length; j++)
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
    }
}
