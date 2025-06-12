using System;
using System.Text; // Nepieciešams Encoding klasei

class Program
{
    static void Main(string[] args)
    {
        // Iestata konsoles izvades un ievades kodējumu uz UTF-8
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8; // Ieteicams arī ievadei


        // 1. Paziņojam lietotājam, ko programma darīs
        Console.WriteLine("Šī programma saskaita 2 jūsu ievadītus skaitļus.");



        // 2. Prasām pirmo skaitli
        Console.Write("Lūdzu, ievadiet pirmo skaitli: ");

        // 3. Nolasām lietotāja ievadi un mēģinām to pārvērst par skaitli (veselu skaitli)
        string pirmaisSkaitlisTeksts = Console.ReadLine();
        int pirmaisSkaitlis;

        // Pārbaudām, vai ievade ir derīgs skaitlis
        while (!int.TryParse(pirmaisSkaitlisTeksts, out pirmaisSkaitlis))
        {
            Console.WriteLine("Nederīga ievade. Lūdzu, ievadiet veselu skaitli.");
            Console.Write("Lūdzu, ievadiet pirmo skaitli: ");
            pirmaisSkaitlisTeksts = Console.ReadLine();
        }



        // 4. Prasām otro skaitli
        Console.Write("Lūdzu, ievadiet otro skaitli: ");

        // 5. Nolasām lietotāja ievadi un mēģinām to pārvērst par skaitli
        string otraisSkaitlisTeksts = Console.ReadLine();
        int otraisSkaitlis;

        // Pārbaudām, vai ievade ir derīgs skaitlis
        while (!int.TryParse(otraisSkaitlisTeksts, out otraisSkaitlis))
        {
            Console.WriteLine("Nederīga ievade. Lūdzu, ievadiet veselu skaitli.");
            Console.Write("Lūdzu, ievadiet otro skaitli: ");
            otraisSkaitlisTeksts = Console.ReadLine();
        }


        // 6. Aprēķinām summu
        int summa = pirmaisSkaitlis + otraisSkaitlis;

        // 7. Izvadam rezultātu
        Console.WriteLine($"Ievadīto skaitļu summa ir: {summa}");

        // 8. Gaidām, kamēr lietotājs nospiež jebkuru taustiņu, lai konsole neaizvērtos uzreiz
        Console.WriteLine("Nospiediet jebkuru taustiņu, lai pabeigtu...");
        Console.ReadKey();
    }
}
