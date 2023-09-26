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
    }
}