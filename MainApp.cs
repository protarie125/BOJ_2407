using System;
using System.Numerics;

namespace BOJ_2407
{
    internal static class MainApp
    {
        private static void Main()
        {
            var l = Console.ReadLine();
            var sp = l.Split(' ');
            var n = BigInteger.Parse(sp[0]);
            var m = BigInteger.Parse(sp[1]);
            var ans = new BigInteger(1);

            for (var i = 0; i < m; i++)
            {
                ans *= n;
                --n;
            }

            for (var i = 1; i <= m; i++)
            {
                ans /= i;
            }

            Console.WriteLine(ans);
        }
    }
}