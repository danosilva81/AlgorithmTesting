using System;
using System.Collections.Generic;
using System.Text;

namespace TenerifeApp
{
    public class Exercise3
    {
        public int AmountConsecutivesMultiplied(int Min, int Max) 
        {
            var ceilingUpper = (int)Math.Ceiling(Math.Sqrt(Max));
            var upperValue = (ceilingUpper * (ceilingUpper - 1)) > Max ? ceilingUpper - 1 : ceilingUpper;

            var floorDown = (int)Math.Floor(Math.Sqrt(Min));
            var downValue = (floorDown * (floorDown + 1)) >= Min ? floorDown : floorDown + 1;

            return upperValue - downValue;
        }
    }
}
