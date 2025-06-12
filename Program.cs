using System;
using System.Text; // Nepieciešams Encoding klasei

class Program
{
    static void Main(string[] args)
    {
        // Iestata konsoles izvades un ievades kodējumu uz UTF-8
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8; // Ieteicams arī ievadei

        Console.WriteLine("Vecuma konvertēšanas programma.");

        // 1. Prasām lietotājam ievadīt vecumu kā tekstu
        Console.Write("Lūdzu, ievadiet savu vecumu: ");

        // 2. Nolasām lietotāja ievadi kā tekstu (string)
        string vecumaTeksts = Console.ReadLine();

        // 3. Deklarējam mainīgo, kurā tiks saglabāts konvertētais skaitlis
        int vecums;

        // 4. Mēģinām pārvērst tekstu par veselu skaitli, izmantojot int.TryParse()
        // int.TryParse() atgriež 'true', ja konvertēšana ir veiksmīga, un 'false', ja nē.
        // Konvertētais skaitlis tiek saglabāts 'vecums' mainīgajā (izmantojot 'out' atslēgvārdu).
        bool isConversionSuccessful = int.TryParse(vecumaTeksts, out vecums);

        // 5. Izvadam ziņojumu, pamatojoties uz konvertēšanas rezultātu
        if (isConversionSuccessful)
        {
            Console.WriteLine($"Konvertēšana izdevās! Jūsu vecums ir: {vecums} gadi.");
        }
        else
        {
            Console.WriteLine($"Konvertēšana neizdevās. '{vecumaTeksts}' nav derīgs skaitlis.");
            Console.WriteLine("Lūdzu, ievadiet tikai skaitliskas vērtības vecumam.");
        }

        // Gaidām, kamēr lietotājs nospiež jebkuru taustiņu, lai konsole neaizvērtos uzreiz
        Console.WriteLine("\nNospiediet jebkuru taustiņu, lai pabeigtu...");
        Console.ReadKey();
    }
}