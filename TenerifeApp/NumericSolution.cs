using System;
using System.Collections.Generic;
using System.Text;

namespace TenerifeApp
{
    public class NumericSolution
    {
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

    }
}
