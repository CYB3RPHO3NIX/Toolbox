using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer
{
    public class LongInteger
    {
        /// <summary>
        /// Generates a random integer within the full range of Int64 values.
        /// </summary>
        /// <returns>A random integer.</returns>
        public static long GetRandomLong()
        {
            Random r = new Random();
            return r.NextInt64(Int64.MinValue, Int64.MaxValue);
        }

        /// <summary>
        /// Generates a random integer within the specified range.
        /// </summary>
        /// <param name="minValue">The minimum value (inclusive).</param>
        /// <param name="maxValue">The maximum value (exclusive).</param>
        /// <returns>A random integer within the specified range.</returns>
        public static long GetRandomLong(long minValue, long maxValue)
        {
            if (minValue >= maxValue)
            {
                throw new ArgumentException("minValue must be less than maxValue");
            }

            Random r = new Random();
            return r.NextInt64(minValue, maxValue);
        }

        /// <summary>
        /// Generates a random integer greater than or equal to the specified value.
        /// </summary>
        /// <param name="val">The minimum value (inclusive).</param>
        /// <returns>A random integer greater than or equal to the specified value.</returns>
        public static long GetRandomLongGreaterThanOrEqualTo(long val)
        {
            if (val == Int64.MaxValue)
            {
                throw new ArgumentOutOfRangeException("val", "value must be smaller than MaxValue of Int64");
            }
            Random r = new Random();
            return r.NextInt64(val, Int64.MaxValue);
        }

        /// <summary>
        /// Generates a random integer less than the specified value.
        /// </summary>
        /// <param name="val">The maximum value (exclusive).</param>
        /// <returns>A random integer less than the specified value.</returns>
        public static long GetRandomLongLessThanOrEqualTo(long val)
        {
            if (val == Int64.MinValue)
            {
                throw new ArgumentOutOfRangeException("val", "value must be greater than MinValue of Int64");
            }
            Random r = new Random();
            return r.NextInt64(Int64.MinValue, val);
        }
    }
}
