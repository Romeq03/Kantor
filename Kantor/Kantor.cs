using System;

class CurrencyConverter
{
    static void Main()
    {
        double plnToUsdExchangeRate = 0.25;
        double usdToEurExchangeRate = 0.85;
        double usdToChfExchangeRate = 0.92;
        double usdToGbpExchangeRate = 0.75;

        Console.Write("Podaj kwotę w PLN: ");
        double amountInPln = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj walutę docelową (EUR, CHF, GBP): ");
        string targetCurrency = Console.ReadLine().ToUpper();

        double amountInUsd = amountInPln * plnToUsdExchangeRate;

        double result = 0.0;
        switch (targetCurrency)
        {
            case "EUR":
                result = amountInUsd * usdToEurExchangeRate;
                break;
            case "CHF":
                result = amountInUsd * usdToChfExchangeRate;
                break;
            case "GBP":
                result = amountInUsd * usdToGbpExchangeRate;
                break;
            default:
                Console.WriteLine("Nieprawidłowa waluta docelowa.");
                return;
        }

        Console.WriteLine($"Wynik przeliczenia: {result} {targetCurrency}");
        Console.ReadLine();
    }
}
