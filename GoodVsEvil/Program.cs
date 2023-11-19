using System.Reflection.Metadata.Ecma335;

namespace GoodVsEvil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GoodVsEvil("0 0 0 0 0 10", "0 1 1 1 1 0 0"));
            Console.ReadKey();
        }

        public static string GoodVsEvil(string good, string evil)
        {
            int[] goodWorth = new[] { 1, 2, 3, 3, 4, 10 };

            int[] evilWorth = new[] { 1, 2, 2, 2, 3, 5, 10 };

            var goodArr = good.Split(' ').Select(int.Parse).ToArray();

            int goodPower = 0;

            for (int i = 0; i < goodArr.Length; i++)
            {
                goodPower += goodArr[i] * goodWorth[i];
            }

            var evilArr = evil.Split(' ').Select(int.Parse).ToArray();

            int EvilPower = 0;

            for (int i = 0; i < evilArr.Length; i++)
            {
                EvilPower += evilArr[i] * evilWorth[i];
            }

            if (goodPower > EvilPower)
                return "Battle Result: Good triumphs over Evil";

            else if (goodPower < EvilPower)
                return "Battle Result: Evil eradicates all trace of Good";

            else
                return "Battle Result: No victor on this battle field";
        }
    }
}
