using API1;

namespace API1Test
{
    public class CardUtilityTests
    {
        [Fact]
        public void MaskCardNumber_ShouldReturnMaskedNumber()
        {
            var maskedNumber = CardUtliity.MaskCardNumber("0123456789012345");
            Assert.Equal("************2345", maskedNumber);
        }
    }
}