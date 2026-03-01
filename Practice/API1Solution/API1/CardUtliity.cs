namespace API1
{
    public static class CardUtliity
    {
        public static string MaskCardNumber(string cardNumber)
        {
            return new string('*', cardNumber.Length - 4) + cardNumber[^4..];
        }
    }
}
