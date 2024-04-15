using PersianTools.Modules.Bank_By_CardNumber;

namespace PersianTools.Modules
{
    public static class GetBankNameFromCardNumber
    {
        public static string Find(string cardNumber)
        {
            if (string.IsNullOrWhiteSpace(cardNumber)
                || cardNumber.Length < 6
                || cardNumber.Length > 16)
            {
                return string.Empty;
            }

            string bankCode = cardNumber.Substring(0, 6);
            return CardBank.CardBankDictionary.ContainsKey(bankCode)
                ? CardBank.CardBankDictionary[bankCode]
                : string.Empty;
        }

        public static string Find(ulong cardNumber)
        => Find(cardNumber.ToString());
    }
}
