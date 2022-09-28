namespace Currency;

public class CurrencyRUB :Currency
{
    public static decimal RubEur { get; set; }
    public static decimal RubUsd { get; set;}

    public static implicit operator CurrencyRUB(CurrencyEUR x)
    {
        return new CurrencyRUB {Value = x.Value*RubEur};
    }
    public static implicit operator CurrencyRUB(CurrencyUSD x)
    {
        return new CurrencyRUB {Value = x.Value*RubUsd};
    }
}