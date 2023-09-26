using Randomizer;

namespace RandomizerTest
{
    public class IntegerTests
    {
        [Fact(DisplayName = "Generate random integer within full Int32 range")]
        public void GenerateRandomIntegerWithinFullRange()
        {
            int result = Integer.GetRandomInteger();
            Assert.InRange(result, Int32.MinValue, Int32.MaxValue);
        }

        [Fact(DisplayName = "Generate random integer within specified range")]
        public void GenerateRandomIntegerWithinSpecifiedRange()
        {
            int minValue = -100;
            int maxValue = 100;
            int result = Integer.GetRandomInteger(minValue, maxValue);
            Assert.InRange(result, minValue, maxValue - 1); // MaxValue is exclusive
        }

        [Fact(DisplayName = "Generate random integer greater than or equal to specified value")]
        public void GenerateRandomIntegerGreaterThanOrEqualToSpecifiedValue()
        {
            int val = -50;
            int result = Integer.GetRandomIntegerGreaterThanOrEqualTo(val);
            Assert.True(result >= val);
        }

        [Fact(DisplayName = "Generate random integer less than or equal to specified value")]
        public void GenerateRandomIntegerLessThanOrEqualToSpecifiedValue()
        {
            int val = 50;
            int result = Integer.GetRandomIntegerLessThanOrEqualTo(val);
            Assert.True(result <= val);
        }

        [Fact(DisplayName = "Generate random integer with minValue >= maxValue")]
        public void GenerateRandomIntegerInvalidRange()
        {
            int minValue = 100;
            int maxValue = -100;
            Assert.Throws<ArgumentException>(() => Integer.GetRandomInteger(minValue, maxValue));
        }

        [Fact(DisplayName = "Generate random integer greater than or equal to Int32.MaxValue")]
        public void GenerateRandomIntegerGreaterThanMaxValue()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Integer.GetRandomIntegerGreaterThanOrEqualTo(Int32.MaxValue));
        }

        [Fact(DisplayName = "Generate random integer less than or equal to Int32.MinValue")]
        public void GenerateRandomIntegerLessThanMinValue()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Integer.GetRandomIntegerLessThanOrEqualTo(Int32.MinValue));
        }
    }
}