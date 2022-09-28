namespace Currency;

public class CurrencyUSD : Currency
{
    public static decimal UsdRub { get; set; }
    public static decimal UsdEur { get; set;}
    public static implicit operator CurrencyUSD(CurrencyEUR x)
    {
        return new CurrencyUSD {Value = x.Value*UsdEur};
    }
    public static implicit operator CurrencyUSD(CurrencyRUB x)
    {
        return new CurrencyUSD {Value = x.Value*UsdRub};
    }
}