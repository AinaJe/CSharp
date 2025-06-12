using System;
using System.Text; // Nepieciešams Encoding klasei

class Program
{
    static void Main(string[] args)
    {
        // Iestata konsoles izvades un ievades kodējumu uz UTF-8
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8; // Ieteicams arī ievadei

        Console.WriteLine("Pāra vai nepāra skaitļa noteikšana:");
        Console.WriteLine("--------------------------------------------");

        int skaitlis;
        bool ievadeDeriga;

        // Nepārtraukti prasām ievadi, līdz lietotājs ievada derīgu veselu skaitli
        do
        {
            Console.Write("Lūdzu, ievadiet veselu skaitli: ");
            string ievadeTeksts = Console.ReadLine();

            // Mēģinām pārvērst tekstu par int, izmantojot int.TryParse()
            ievadeDeriga = int.TryParse(ievadeTeksts, out skaitlis);

            if (!ievadeDeriga)
            {
                Console.WriteLine("Kļūda: Nederīga ievade. Lūdzu, ievadiet derīgu veselu skaitli.");
            }
        } while (!ievadeDeriga);

        // Pārbaudām, vai skaitlis ir pāra vai nepāra, izmantojot % operatoru
        // Ja skaitli dala ar 2 un atlikums ir 0, tad tas ir pāra skaitlis.
        // Pretējā gadījumā tas ir nepāra skaitlis.
        if (skaitlis % 2 == 0)
        {
            Console.WriteLine($"Skaitlis {skaitlis} ir pāra skaitlis.");
        }
        else
        {
            Console.WriteLine($"Skaitlis {skaitlis} ir nepāra skaitlis.");
        }

        // Gaidām, kamēr lietotājs nospiež jebkuru taustiņu, lai konsole neaizvērtos uzreiz
        Console.WriteLine("\nNospiediet jebkuru taustiņu, lai pabeigtu...");
        Console.ReadKey();
    }
}