using System;
using System.Text; // Nepieciešams Encoding klasei

class Program
{
    static void Main(string[] args)
    {
        // Iestata konsoles izvades un ievades kodējumu uz UTF-8
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8; // Ieteicams arī ievadei

        Console.WriteLine("Mēneša nosaukuma noteikšana:");
        Console.WriteLine("-------------------------------------");

        int menesaNumurs;
        bool ievadeDeriga;

        // Nepārtraukti prasām ievadi, līdz lietotājs ievada derīgu skaitli no 1 līdz 12
        do
        {
            Console.Write("Lūdzu, ievadiet mēneša numuru (1-12): ");
            string ievadeTeksts = Console.ReadLine();

            // Mēģinām pārvērst tekstu par int
            ievadeDeriga = int.TryParse(ievadeTeksts, out menesaNumurs);

            // Pārbaudām, vai ievade ir skaitlis un ir diapazonā no 1 līdz 12
            if (!ievadeDeriga)
            {
                Console.WriteLine("Kļūda: Nederīga ievade. Lūdzu, ievadiet veselu skaitli.");
            }
            else if (menesaNumurs < 1 || menesaNumurs > 12)
            {
                Console.WriteLine("Kļūda: Numuram jābūt no 1 līdz 12.");
                ievadeDeriga = false; // Atkārtot ciklu
            }

        } while (!ievadeDeriga);

        string menesaNosaukums;

        // Izmantojam switch paziņojumu, lai noteiktu mēneša nosaukumu
        switch (menesaNumurs)
        {
            case 1:
                menesaNosaukums = "Janvāris";
                break;
            case 2:
                menesaNosaukums = "Februāris";
                break;
            case 3:
                menesaNosaukums = "Marts";
                break;
            case 4:
                menesaNosaukums = "Aprīlis";
                break;
            case 5:
                menesaNosaukums = "Maijs";
                break;
            case 6:
                menesaNosaukums = "Jūnijs";
                break;
            case 7:
                menesaNosaukums = "Jūlijs";
                break;
            case 8:
                menesaNosaukums = "Augusts";
                break;
            case 9:
                menesaNosaukums = "Septembris";
                break;
            case 10:
                menesaNosaukums = "Oktobris";
                break;
            case 11:
                menesaNosaukums = "Novembris";
                break;
            case 12:
                menesaNosaukums = "Decembris";
                break;
            // 'default' bloks tiek izpildīts, ja 'menesaNumurs' neatbilst nevienam 'case'
            // Šajā gadījumā tas, visticamāk, netiks sasniegts, jo mēs jau validējam ievadi
            default:
                menesaNosaukums = "Nezināms mēneša numurs";
                break;
        }

        Console.WriteLine($"\nMēnesis ar numuru {menesaNumurs} ir {menesaNosaukums}.");

        // Gaidām, kamēr lietotājs nospiež jebkuru taustiņu, lai konsole neaizvērtos uzreiz
        Console.WriteLine("\nNospiediet jebkuru taustiņu, lai pabeigtu...");
        Console.ReadKey();
    }
}