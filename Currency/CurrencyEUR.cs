namespace Currency;

public class CurrencyEUR : Currency
{
    public static decimal EurRub { get; set; }
    public static decimal EurUsd { get; set;}
    public static implicit operator CurrencyEUR(CurrencyRUB x)
    {
        return new CurrencyEUR {Value = x.Value*EurRub};
    }
    public static implicit operator CurrencyEUR(CurrencyUSD x)
    {
        return new CurrencyRUB {Value = x.Value*EurUsd};
    }
}