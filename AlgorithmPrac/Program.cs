using System.Text;

namespace AlgorithmPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToJadenCase("How can mirrors be real if our eyes aren't real"));
        }

        public static int Quadrant(int x, int y)
        {

            return (x > 0 && y > 0) ? 1 : (x < 0 && y > 0) ? 2 : (x > 0 && y < 0) ? 4 : 3;
        }
        public static string ToJadenCase(string phrase)
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
    }
}
