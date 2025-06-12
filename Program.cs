using System;
using System.Linq; // Nepieciešams OrderByDescending metodei
using System.Text; // Nepieciešams Encoding klasei

class Program
{
    static void Main(string[] args)
    {
        // Iestata konsoles izvades un ievades kodējumu uz UTF-8
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8; // Ieteicams arī ievadei

        Console.WriteLine("Skaitļu masīva kārtošana.");
        Console.WriteLine("--------------------------");

        // 1. Izveidojam masīvu ar 5 skaitļiem
        int[] skaitli = { 5, 2, 8, 1, 9 };
        int[] skaitliKopija = new int[skaitli.Length]; // Izveidojam kopiju, lai demonstrētu visas metodes neatkarīgi
        Array.Copy(skaitli, skaitliKopija, skaitli.Length);

        Console.WriteLine("Sākotnējais masīvs:");
        foreach (int sk in skaitli)
        {
            Console.Write($"{sk} ");
        }
        Console.WriteLine("\n"); // Pāriet jaunā rindā

        // 2. Sakārtošana augošā secībā (Ascending Order)
        Array.Sort(skaitli); // Kārto sākotnējo masīvu
        Console.WriteLine("Masīvs augošā secībā (Array.Sort):");
        foreach (int sk in skaitli)
        {
            Console.Write($"{sk} ");
        }
        Console.WriteLine("\n");

        // 3. Sakārtošana dilstošā secībā, izmantojot Array.Sort() + Array.Reverse()
        // (Turpina ar iepriekš sakārtoto masīvu, kas tagad ir augošā secībā)
        Array.Reverse(skaitli); // Apgriež jau augošā secībā sakārtoto masīvu
        Console.WriteLine("Masīvs dilstošā secībā (Array.Sort + Array.Reverse):");
        foreach (int sk in skaitli)
        {
            Console.Write($"{sk} ");
        }
        Console.WriteLine("\n");

        // 4. Sakārtošana dilstošā secībā, izmantojot Array.Sort() ar pielāgotu salīdzinātāju
        // Izmantojam masīva kopiju, lai sāktu no sākotnējā stāvokļa demonstrācijai
        Array.Sort(skaitliKopija, (a, b) => b.CompareTo(a)); // Pielāgotais salīdzinātājs
        Console.WriteLine("Masīvs dilstošā secībā (Array.Sort ar pielāgotu salīdzinātāju):");
        foreach (int sk in skaitliKopija)
        {
            Console.Write($"{sk} ");
        }
        Console.WriteLine("\n");

        // 5. Sakārtošana dilstošā secībā, izmantojot LINQ OrderByDescending()
        // Atkārtoti inicializējam masīvu vai izmantojam jaunu, lai demonstrētu no "svaiga" sākuma
        int[] skaitliLinqDemo = { 5, 2, 8, 1, 9 };
        var dilstošaisMasivsLinq = skaitliLinqDemo.OrderByDescending(s => s);

        Console.WriteLine("Masīvs dilstošā secībā (LINQ OrderByDescending):");
        foreach (int sk in dilstošaisMasivsLinq)
        {
            Console.Write($"{sk} ");
        }
        Console.WriteLine("\n");

        // Gaidām, kamēr lietotājs nospiež jebkuru taustiņu, lai konsole neaizvērtos uzreiz
        Console.WriteLine("Nospiediet jebkuru taustiņu, lai pabeigtu...");
        Console.ReadKey();
    }
}