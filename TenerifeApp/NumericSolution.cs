using System;
using System.Collections.Generic;
using System.Text;

namespace TenerifeApp
{
    public class NumericSolution
    {
        #region "Exercise 1"
        public int FrontBackNumbers1(int A) 
        {
            string number = A.ToString();
            string result = "";
            int i = 0;
            int j = number.Length;

            while(result.Length != number.Length) 
            {
                result += number[i];
                i++;
                if (i == j)
                    break;
                j--;                
                result += number[j];                                
            }

            return int.Parse(result);
        }

        public int FrontBackNumbers2(int A) 
        {
            var lengthNum = A.ToString().Length-1;
            var result = "";

            while (A != 0) 
            {
                int r1 = A / Convert.ToInt32(Math.Pow(10,lengthNum));
                result += r1;
                A %= Convert.ToInt32(Math.Pow(10, lengthNum));
                lengthNum-=2;

                if (A == 0)
                    break;
                
                int r2 = A % 10;
                result += r2;
                A /= 10; 
            }

            return int.Parse(result);
        }

        #region Solucion del Flaco
        public int GetFirstLastDigitAlternatively(int n)
        {
            return Int32.Parse(GetFirstLastDigit(n.ToString(), true));
        }

        private string GetFirstLastDigit(string s, bool fromStart)
        {
            if (s.Length == 1) return s;

            return (fromStart)
                ? s[0] + GetFirstLastDigit(s.Substring(1), !fromStart)
                : s[s.Length - 1] + GetFirstLastDigit(s.Substring(0, s.Length - 1), !fromStart);
        }
        #endregion

        #endregion
    }
}
