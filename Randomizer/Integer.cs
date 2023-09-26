using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Randomizer
{
    public static class Integer
    {
        public static int GetRandomInteger()
        {
            Random r = new Random();
            return r.Next(Int32.MinValue, Int32.MaxValue);
        }
        public static int GetRandomInteger(int maxValue, int minValue)
        {
            Random r = new Random();
            return r.Next(minValue, maxValue);
        }
        public static int GetRandomIntegerGreaterThan(int val)
        {
            Random r = new Random();
            return r.Next(val, Int32.MaxValue);
        }
        public static int GetRandomIntegerLessThan(int val)
        {
            Random r = new Random();
            return r.Next(Int32.MinValue, val);
        }
    }
}
