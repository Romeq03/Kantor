using System;

class CurrencyConverter
{
    static void Main()
    {
        // Kursy wymiany walut (zakodowane na stałe)
        double plnToUsdExchangeRate = 0.25;
        double usdToEurExchangeRate = 0.85;
        double usdToChfExchangeRate = 0.92;
        double usdToGbpExchangeRate = 0.75;

        // Pobieranie danych od użytkownika
        Console.Write("Podaj kwotę w PLN: ");
        double amountInPln = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj walutę docelową (EUR, CHF, GBP): ");
        string targetCurrency = Console.ReadLine().ToUpper();

        // Przeliczanie kwoty na walutę pośrednią (USD)
        double amountInUsd = amountInPln * plnToUsdExchangeRate;

        // Przeliczanie na walutę docelową
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

        // Wyświetlanie wyniku
        Console.WriteLine($"Wynik przeliczenia: {result} {targetCurrency}");

        // Oczekiwanie na naciśnięcie klawisza przed zakończeniem programu
        Console.ReadLine();
    }
}
