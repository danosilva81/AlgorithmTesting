using System;
using System.Collections.Generic;
using System.Text;

namespace TenerifeApp
{
    public class Exercise1
    {
        public int FrontBackNumbers_Solution1(int A) 
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

        public int FrontBackNumbers_Solution2(int A) 
        {
            var lengthNum = A.ToString().Length-1;
            var result = "";

            while (A != 0) 
            {
                int r1 = A / (int)Math.Pow(10,lengthNum);
                result += r1;
                A %= (int)Math.Pow(10, lengthNum);
                lengthNum-=2;

                if (A == 0)
                    break;
                
                int r2 = A % 10;
                result += r2;
                A /= 10; 
            }

            return int.Parse(result);
        }

        public int FrontBackNumbers_Recursive(int A) 
        {
            var lengthNum = A.ToString().Length;
            
            if (lengthNum == 1 || lengthNum == 2)
                return A;

            int r1 = A / (int)Math.Pow(10, lengthNum-1);
            int r2 = A % 10;

            return int.Parse(r1.ToString() + r2.ToString() + FrontBackNumbers_Recursive(A % (int)Math.Pow(10, lengthNum-1) / 10).ToString());
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
    }
}
