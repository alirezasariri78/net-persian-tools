using PersianTools.Modules.capital_by_province;

namespace PersianTools.Modules
{
    public static class FindCapitalByProvince
    {
        public static string Find(string province)
        {
            if (string.IsNullOrWhiteSpace(province))
            {
                return string.Empty;
            }
            return State.CapitalProvince.ContainsKey(province)
                ? State.CapitalProvince[province] 
                : string.Empty;
        }
    }
}
