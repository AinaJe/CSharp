using System;
using System.Text; // Nepieciešams Encoding klasei

class Program
{
    static void Main(string[] args)
    {
        // Iestata konsoles izvades un ievades kodējumu uz UTF-8
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8; // Ieteicams arī ievadei

        int skaitlis = 25;
        switch (skaitlis)
        {
            case int n when n < 10:
                Console.WriteLine("Mazs skaitlis");
                break;
            case int n when n > 20 && n < 40:
                Console.WriteLine("Vidējs skaitlis");
                break;
            default:
                Console.WriteLine("Cits skaitlis");
                break;
        }

        // Gaidām, kamēr lietotājs nospiež jebkuru taustiņu, lai konsole neaizvērtos uzreiz
        Console.WriteLine("\nNospiediet jebkuru taustiņu, lai pabeigtu...");
        Console.ReadKey();
    }
}