using System;
using System.Collections.Generic;
using System.Text;

namespace TenerifeApp
{
    public class Exercise2
    {
        public int RoundsInCasino(int N, int K) 
        {
            if(N == 2)
                return 1;

            if (K == 0)
                return N - 1;

            var partial = (N % 2 != 0) ? 2 : 1;

            return partial + RoundsInCasino(N / 2, K - 1);
        }

        //Solucion del Flaco
        public int MinimumRoundsInCasino(int n, int k)
        {
            if ((k is 0) || (n is 2)) return n - 1;

            return (n % 2 is 0)
                ? 1 + MinimumRoundsInCasino(n / 2, k - 1)
                : 1 + MinimumRoundsInCasino(n - 1, k);
        }

        //Solución del Jimmy
        public int Solution(int totalEarned, int maximunAllIn)
        {
            if (totalEarned == 1) return 0;
            return GetMinimunBet(totalEarned, maximunAllIn);
        }

        private int GetMinimunBet(int totalEarned, int maximunAllIn)
        {
            if (totalEarned == 2 || maximunAllIn == 0) return totalEarned - 1;
            var hasWinWithAllIn = totalEarned % 2 == 0;
            if (hasWinWithAllIn) return 1 + GetMinimunBet(totalEarned / 2, maximunAllIn - 1);
            return 1 + GetMinimunBet(totalEarned - 1, maximunAllIn);
        }
    }

}
