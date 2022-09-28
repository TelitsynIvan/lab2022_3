namespace number3;
using Currency;

class Program
{
    static void Main()
    {
        Console.WriteLine("Eur - Rub:");
        decimal a = decimal.Parse(Console.ReadLine());
        CurrencyEUR.EurRub = a;
        CurrencyRUB.RubEur = 1 / a;
        Console.WriteLine("Eur - Usd:");
        decimal b = decimal.Parse(Console.ReadLine());
        CurrencyEUR.EurUsd = b;
        CurrencyUSD.UsdEur = 1 / b;
        Console.WriteLine("Usd - Rub:");
        decimal c = decimal.Parse(Console.ReadLine());
        CurrencyUSD.UsdRub = c;
        CurrencyRUB.RubUsd = 1 / c;
        Console.WriteLine("value: ");
        Console.WriteLine("Валюта: ");
        string ans = Console.ReadLine();
        switch (ans)
        {
            case "usd":
            {
                Console.WriteLine("value: ");
                CurrencyUSD one = new CurrencyUSD();
                one.Value = decimal.Parse(Console.ReadLine());
                CurrencyEUR two = one; 
                CurrencyRUB three = one; 
                Console.WriteLine($"eur: {two.Value}, rub: {three.Value}");
                break;
            }
            case "rub":
            {
                Console.WriteLine("value: ");
                CurrencyRUB one = new CurrencyRUB();
                one.Value = decimal.Parse(Console.ReadLine());
                CurrencyEUR two = one; 
                CurrencyUSD three = one; 
                Console.WriteLine($"eur: {two.Value}, usd: {three.Value}");
                break;
            }
            case "eur":
            {
                Console.WriteLine("value: ");
                CurrencyEUR one = new CurrencyEUR();
                one.Value = decimal.Parse(Console.ReadLine());
                CurrencyUSD two = one; 
                CurrencyRUB three = one; 
                Console.WriteLine($"usd: {two.Value}, rub: {three.Value}");
                break;
            }
            default:
            {
                Console.WriteLine("incorrect format");
                break;
            }
        }
    }
}
