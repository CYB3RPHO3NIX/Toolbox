﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Randomizer
{
    public static class Integer
    {
        /// <summary>
        /// Generates a random integer within the full range of Int32 values.
        /// </summary>
        /// <returns>A random integer.</returns>
        public static int GetRandomInteger()
        {
            Random r = new Random();
            return r.Next(Int32.MinValue, Int32.MaxValue);
        }

        /// <summary>
        /// Generates a random integer within the specified range.
        /// </summary>
        /// <param name="minValue">The minimum value (inclusive).</param>
        /// <param name="maxValue">The maximum value (exclusive).</param>
        /// <returns>A random integer within the specified range.</returns>
        public static int GetRandomInteger(int minValue, int maxValue)
        {
            if (minValue >= maxValue)
            {
                throw new ArgumentException("minValue must be less than maxValue");
            }
            Random r = new Random();
            return r.Next(minValue, maxValue);
        }

        /// <summary>
        /// Generates a random integer greater than or equal to the specified value.
        /// </summary>
        /// <param name="val">The minimum value (inclusive).</param>
        /// <returns>A random integer greater than or equal to the specified value.</returns>
        public static int GetRandomIntegerGreaterThanOrEqualTo(int val)
        {
            if (val == Int32.MaxValue)
            {
                throw new ArgumentOutOfRangeException("val", "value must be smaller than MaxValue of Int32");
            }
            Random r = new Random();
            return r.Next(val, Int32.MaxValue);
        }

        /// <summary>
        /// Generates a random integer less than the specified value.
        /// </summary>
        /// <param name="val">The maximum value (exclusive).</param>
        /// <returns>A random integer less than the specified value.</returns>
        public static int GetRandomIntegerLessThanOrEqualTo(int val)
        {
            if (val == Int32.MinValue)
            {
                throw new ArgumentOutOfRangeException("val", "value must be greater than MinValue of Int32");
            }
            Random r = new Random();
            return r.Next(Int32.MinValue, val);
        }
    }
}
