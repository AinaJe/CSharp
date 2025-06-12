using System;
using System.Text; // Nepieciešams Encoding klasei

class Program
{
    static void Main(string[] args)
    {
        // Iestata konsoles izvades un ievades kodējumu uz UTF-8
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8; // Ieteicams arī ievadei

        Console.WriteLine("Vārda un uzvārda apvienošanas programma.");
        Console.WriteLine("--------------------------------------");

        // 1. Prasām lietotājam ievadīt vārdu
        Console.Write("Lūdzu, ievadiet savu vārdu: ");
        string vards = Console.ReadLine();

        // 2. Prasām lietotājam ievadīt uzvārdu
        Console.Write("Lūdzu, ievadiet savu uzvārdu: ");
        string uzvards = Console.ReadLine();

        Console.WriteLine("\nApvienotie vārdi, izmantojot dažādas metodes:");

        // Metode 1: Virkņu savienošana ar '+' operatoru
        string pilnsVards1 = vards + " " + uzvards;
        Console.WriteLine($"1. '+' operators: {pilnsVards1}");

        // Metode 2: String.Concat() metode
        string pilnsVards2 = String.Concat(vards, " ", uzvards);
        Console.WriteLine($"2. String.Concat(): {pilnsVards2}");

        // Metode 3: String.Format() metode
        string pilnsVards3 = String.Format("{0} {1}", vards, uzvards);
        Console.WriteLine($"3. String.Format(): {pilnsVards3}");

        // Metode 4: Virkņu interpolācija (String Interpolation) - modernākā un ieteicamākā metode C#
        string pilnsVards4 = $"{vards} {uzvards}";
        Console.WriteLine($"4. Virkņu interpolācija: {pilnsVards4}");

        // Gaidām, kamēr lietotājs nospiež jebkuru taustiņu, lai konsole neaizvērtos uzreiz
        Console.WriteLine("\nNospiediet jebkuru taustiņu, lai pabeigtu...");
        Console.ReadKey();
    }
}

