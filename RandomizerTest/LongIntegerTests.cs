using Randomizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizerTest
{
    public class LongIntegerTests
    {
        [Fact(DisplayName = "Generate random long within full Int64 range")]
        public void GenerateRandomLongWithinFullRange()
        {
            long result = LongInteger.GetRandomLong();
            Assert.InRange(result, Int64.MinValue, Int64.MaxValue);
        }

        [Fact(DisplayName = "Generate random long within specified range")]
        public void GenerateRandomLongWithinSpecifiedRange()
        {
            long minValue = -100L;
            long maxValue = 100L;
            long result = LongInteger.GetRandomLong(minValue, maxValue);
            Assert.InRange(result, minValue, maxValue - 1); // MaxValue is exclusive
        }

        [Fact(DisplayName = "Generate random long greater than or equal to specified value")]
        public void GenerateRandomLongGreaterThanOrEqualToSpecifiedValue()
        {
            long val = -50L;
            long result = LongInteger.GetRandomLongGreaterThanOrEqualTo(val);
            Assert.True(result >= val);
        }

        [Fact(DisplayName = "Generate random long less than or equal to specified value")]
        public void GenerateRandomLongLessThanOrEqualToSpecifiedValue()
        {
            long val = 50L;
            long result = LongInteger.GetRandomLongLessThanOrEqualTo(val);
            Assert.True(result <= val);
        }

        [Fact(DisplayName = "Generate random long with minValue >= maxValue")]
        public void GenerateRandomLongInvalidRange()
        {
            long minValue = 100L;
            long maxValue = -100L;
            Assert.Throws<ArgumentException>(() => LongInteger.GetRandomLong(minValue, maxValue));
        }

        [Fact(DisplayName = "Generate random long greater than or equal to Int64.MaxValue")]
        public void GenerateRandomLongGreaterThanMaxValue()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => LongInteger.GetRandomLongGreaterThanOrEqualTo(Int64.MaxValue));
        }

        [Fact(DisplayName = "Generate random long less than or equal to Int64.MinValue")]
        public void GenerateRandomLongLessThanMinValue()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => LongInteger.GetRandomLongLessThanOrEqualTo(Int64.MinValue));
        }
    }
}
