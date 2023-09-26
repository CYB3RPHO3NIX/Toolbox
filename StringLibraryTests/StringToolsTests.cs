using AutoFixture;
using StringLibrary;
namespace StringLibraryTests
{
    public class StringToolsTests
    {
        private Fixture _fixture;
        public StringToolsTests()
        {
            _fixture = new Fixture();
        }

        [Fact(DisplayName = "Positive test: String reverse test")]
        public void StringReverseTestPositiveCase()
        {
            //Arrange
            string text = _fixture.Create<string>();
            string expected = String.Concat(text.Reverse());
            //Act
            string actual = StringTools.Reverse(text);
            //Assert.
            Assert.NotNull(actual);
            Assert.NotEmpty(actual);
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "Negative test: String reverse test (null input)")]
        public void StringReverseTestNegativeCase_NullInput()
        {
            // Arrange
            string text = null;

            // Act & Assert (Expecting ArgumentNullException)
            Assert.Throws<NullReferenceException>(() => StringTools.Reverse(text));
        }

        [Fact(DisplayName = "Positive test: CountSubstringOccurrences (substring exists)")]
        public void CountSubstringOccurrences_PositiveCase_SubstringExists()
        {
            // Arrange
            string input = _fixture.Create<string>(); // Generate a random string
            int randomValue = _fixture.Create<int>() % (input.Length - 0 + 1) + 0;
            int expectedCount = _fixture.Create<int>();

            
            
            // Ensure the substring exists in the input string
            

            // Act
            int actualCount = StringTools.CountSubstringOccurrences(input, substring);

            // Assert
            Assert.Equal(expectedCount, actualCount);
        }

        [Fact(DisplayName = "Negative test: CountSubstringOccurrences (substring not found)")]
        public void CountSubstringOccurrences_NegativeCase_SubstringNotFound()
        {
            // Arrange
            string input = _fixture.Create<string>(); // Generate a random string
            string substring = "xyz";

            // Ensure the substring does not exist in the input string

            // Act
            int actualCount = StringTools.CountSubstringOccurrences(input, substring);

            // Assert
            Assert.Equal(0, actualCount);
        }
    }
}