using System;
using System.Text; // Nepieciešams Encoding klasei

class Program
{
    static void Main(string[] args)
    {
        // Iestata konsoles izvades un ievades kodējumu uz UTF-8
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8; // Ieteicams arī ievadei

        try
        {
            // Kods, kas var izraisīt kļūdu
            int dividend = 10;
            int divisor = 0;
            int result = dividend / divisor; // Izraisīs kļūdu
            Console.WriteLine("Rezultāts: " + result);
        }
        catch (DivideByZeroException ex)
        {
            // Apstrādā specifisku kļūdu
            Console.WriteLine("Kļūda: " + ex.Message);
        }
        catch (Exception ex)
        {
            // Apstrādā visas pārējās kļūdas
            Console.WriteLine("Vispārēja kļūda: " + ex.Message);
        }
        finally
        {
            // Izpildās vienmēr, neatkarīgi no kļūdas
            Console.WriteLine("Finally bloks izpildīts.");
        }
        Console.WriteLine("\nNospiediet jebkuru taustiņu, lai pabeigtu...");
        Console.ReadKey();
    }
}

