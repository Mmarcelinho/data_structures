using Exercises;


namespace Tests 
{
    public class EncodeAndDecodeStringsTest
    {
        [Fact]
        public void EncodeAndDecodeStrings_CheckingEncodingAndDecodingIsCorrect()
        {
            //Arrange
            var EncodeAndDecode = new EncodeAndDecodeStrings();

            var strings = new List<string> { "test", "code" };

            var decodeStrings = new List<string> { "test", "code" };

            var encodedStrings = "4#test4#code";

            //Act
            var resultEncode = EncodeAndDecode.Encode(strings);
            var resultDecoded = EncodeAndDecode.Decode(encodedStrings);

            //Assert
            Assert.Equal(encodedStrings, resultEncode);
            Assert.Equal(decodeStrings, resultDecoded);
        }
    }
}
