using System;
using System.Text; // Nepieciešams Encoding klasei

class Program
{
    static void Main(string[] args)
    {
        // Iestata konsoles izvades un ievades kodējumu uz UTF-8
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8; // Ieteicams arī ievadei

        Console.WriteLine("Skaitļu dalīšana:");
        Console.WriteLine("-----------------------------");

        double skaitlis1 = 0;
        double skaitlis2 = 0;
        bool ievadeDeriga;

        // Ievades nolasīšana pirmajam skaitlim
        do
        {
            Console.Write("Lūdzu, ievadiet pirmo skaitli: ");
            string ievadeTeksts1 = Console.ReadLine();
            ievadeDeriga = double.TryParse(ievadeTeksts1, out skaitlis1);

            if (!ievadeDeriga)
            {
                Console.WriteLine("Kļūda: Nederīga ievade. Lūdzu, ievadiet derīgu skaitli.");
            }
        } while (!ievadeDeriga);

        // Ievades nolasīšana otrajam skaitlim
        do
        {
            Console.Write("Lūdzu, ievadiet otro skaitli: ");
            string ievadeTeksts2 = Console.ReadLine();
            ievadeDeriga = double.TryParse(ievadeTeksts2, out skaitlis2);

            if (!ievadeDeriga)
            {
                Console.WriteLine("Kļūda: Nederīga ievade. Lūdzu, ievadiet derīgu skaitli.");
            }
        } while (!ievadeDeriga);


        // Dalīšanas veikšana un izņēmumu apstrāde
        try
        {
            // Pārbaudām, vai otrais skaitlis nav nulle pirms dalīšanas
            if (skaitlis2 == 0)
            {
                // Izmetam DivideByZeroException manuāli, ja dalītājs ir nulle
                // Tas nodrošina, ka mēs notveram tieši šo specifisko kļūdu
                throw new DivideByZeroException("Nevar dalīt ar nulli!");
            }

            double rezultats = skaitlis1 / skaitlis2;
            Console.WriteLine($"\n Dalīšanas rezultāts: {skaitlis1} / {skaitlis2} = {rezultats}");
        }
        catch (DivideByZeroException ex)
        {
            // Apstrādā dalīšanas ar nulli izņēmumu
            Console.WriteLine($"\nKļūda: {ex.Message}");
            Console.WriteLine("Lūdzu, nodrošiniet, lai otrais skaitlis nebūtu nulle.");
        }
        catch (FormatException ex)
        {
            // Apstrādā nepareiza formāta ievades izņēmumu
            // Lai gan mēs izmantojam TryParse iepriekš, šis catch bloks
            // parāda, kā to varētu apstrādāt, ja izmantotu Convert.ToDouble() vai līdzīgi.
            // Šajā gadījumā TryParse jau apstrādā formatēšanas kļūdas,
            // tāpēc šis bloks, iespējams, netiks sasniegts, ja vien nav citas FormatException avota.
            Console.WriteLine($"\n Kļūda: Nederīga skaitļa formāta ievade. {ex.Message}");
            Console.WriteLine("Lūdzu, ievadiet tikai derīgus skaitļus (piemēram, 123 vai 12.5).");
        }
        catch (Exception ex)
        {
            // Apstrādā jebkuru citu negaidītu izņēmumu
            Console.WriteLine($"\n Radās negaidīta kļūda: {ex.Message}");
        }

        // Gaidām, kamēr lietotājs nospiež jebkuru taustiņu, lai konsole neaizvērtos uzreiz
        Console.WriteLine("\nNospiediet jebkuru taustiņu, lai pabeigtu...");
        Console.ReadKey();
    }
}