using System;
using System.Text; // Nepieciešams Encoding klasei

class Program
{
    static void Main(string[] args)
    {
        // Iestata konsoles izvades un ievades kodējumu uz UTF-8
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8; // Ieteicams arī ievadei

        Console.WriteLine("Skaitļu izvade ar dažādiem cikliem:");
        Console.WriteLine("-----------------------------------");

        // 1. Izvade ar while ciklu
        Console.WriteLine("Izvade ar while ciklu:");
        int i = 1; // Inicializējam skaitītāju
        while (i <= 10) // Nosacījums: kamēr i ir mazāks vai vienāds ar 10
        {
            Console.WriteLine(i);
            i++; // Palielinām skaitītāju par 1
        }
        Console.WriteLine(); // Tukša rinda estētikai

        // 2. Izvade ar do-while ciklu
        Console.WriteLine("Izvade ar do-while ciklu:");
        int j = 1; // Inicializējam skaitītāju
        do
        {
            Console.WriteLine(j);
            j++; // Palielinām skaitītāju par 1
        } while (j <= 10); // Nosacījums: kamēr j ir mazāks vai vienāds ar 10 (pārbaudīts pēc izpildes)
        Console.WriteLine();

        // 3. Izvade ar for ciklu
        Console.WriteLine("Izvade ar for ciklu:");
        for (int k = 1; k <= 10; k++) // (Inicializācija; Nosacījums; Iterācija)
        {
            Console.WriteLine(k);
        }
        Console.WriteLine();

        // 4. Masīva izveide un izvade ar foreach ciklu
        Console.WriteLine("Masīva izvade ar foreach ciklu:");

        // Izveidojam virkņu masīvu ar 5 vārdiem
        string[] vardi = { "Alnis", "Bērzs", "Ciedrs", "Dadzis", "Egle" };

        // Izmantojam foreach ciklu, lai iterētu cauri katram elementam masīvā
        foreach (string vards in vardi)
        {
            Console.WriteLine(vards);
        }
        Console.WriteLine();

        // Gaidām, kamēr lietotājs nospiež jebkuru taustiņu, lai konsole neaizvērtos uzreiz
        Console.WriteLine("Nospiediet jebkuru taustiņu, lai pabeigtu...");
        Console.ReadKey();
    }
}