using System;
using System.Text; // Nepieciešams Encoding klasei

class Program
{
    static void Main(string[] args)
    {
        // Iestata konsoles izvades un ievades kodējumu uz UTF-8
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8; // Ieteicams arī ievadei

        Console.Write("Lūdzu, ievadiet savu vecumu: ");
        string vecumsTeksts = Console.ReadLine(); 
        int vecums = Convert.ToInt32(vecumsTeksts);
        if (vecums >= 18)
        {
            Console.WriteLine("Tu esi pilngadīgs!");
        }
        else if (vecums >= 13)
        {
            Console.WriteLine("Tu esi pusaudzis!");
        }
        else
        {
            Console.WriteLine("Tu esi bērns!");
        }

        // Gaidām, kamēr lietotājs nospiež jebkuru taustiņu, lai konsole neaizvērtos uzreiz
        Console.WriteLine("\nNospiediet jebkuru taustiņu, lai pabeigtu...");
        Console.ReadKey();
    }
}