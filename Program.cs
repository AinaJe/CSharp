using System;
using System.Collections.Generic; // Nepieciešams List<T>
using System.Linq;                // Nepieciešams LINQ metodēm (piemēram, Select, ForEach, ja izmanto)
using System.Text;                // Nepieciešams Encoding klasei

// Klases definīcija
class Book
{
    // Īpašības (Properties)
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    // Konstruktors, lai vieglāk izveidotu Book objektus
    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    // Metode, kas izvada grāmatas informāciju
    public void DisplayInfo()
    {
        Console.WriteLine($"Nosaukums: {Title}");
        Console.WriteLine($"Autors: {Author}");
        Console.WriteLine($"Izdošanas gads: {Year}");
        Console.WriteLine("-------------------------"); // Atdalītājs starp grāmatām
    }

    // Piezīme: Var arī pārrakstīt ToString() metodi, lai Console.WriteLine(book); darbotos skaisti
    public override string ToString()
    {
        return $"Nosaukums: {Title}, Autors: {Author}, Gads: {Year}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Iestata konsoles izvades un ievades kodējumu uz UTF-8
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8; // Ieteicams arī ievadei

        Console.WriteLine("Grāmatu saraksts un informācijas izvade.");
        Console.WriteLine("---------------------------------------");

        // 1. Izveidojam sarakstu (List) ar 3 Book objektiem
        List<Book> gramatas = new List<Book>
        {
            new Book("Slepkavība Orientekspresī", "Agatha Christie", 1934),
            new Book("Mazais princis", "Antoine de Saint-Exupéry", 1943),
            new Book("Alķīmiķis", "Paulo Coelho", 1988)
        };

        Console.WriteLine("Informācija par grāmatām (izmantojot LINQ un DisplayInfo metodi):");

        // 2. Izmantojam LINQ, lai iterētu cauri sarakstam un izsauktu DisplayInfo metodi
        // LINQ .ToList() ir izmantots, lai nodrošinātu, ka foreach ir virs saraksta.
        // Šis ir veids, kā izpildīt darbību (DisplayInfo) katram elementam, izmantojot LINQ.
        // Cits veids ir izmantot vienkāršu foreach ciklu (skat. zemāk),
        // bet uzdevums prasa izmantot LINQ.

        // Šeit mēs faktiski neizmantojam klasiskās LINQ vaicājumu metodes (Where, Select, OrderBy),
        // lai "atlasītu" vai "transformētu" datus, bet gan izmantojam LINQ sintaksi
        // kopā ar foreach ciklu, lai apstrādātu katru elementu.
        // Ja vēlaties stingri LINQ, varētu izmantot .ForEach (ja kolekcija ir List<T>)
        // vai .Select (lai atlasītu kaut ko, un tad foreach).
        // Visvienkāršākais un efektīvākais veids ir vienkāršs foreach, bet ja jābūt LINQ,
        // tad varam to interpretēt šādi:
        gramatas.ToList().ForEach(book => book.DisplayInfo());
        // Alternatīva (ja nevēlas izmantot .ForEach, kas ir List<T> specifiska):
        // gramatas.Select(book => { book.DisplayInfo(); return book; }).ToList();
        // vai vienkārši:
        // foreach (var book in gramatas)
        // {
        //     book.DisplayInfo();
        // }

        Console.WriteLine("\nGrāmatas (izmantojot LINQ Select un ToString() metodi):");
        // Šis ir vairāk tipisks LINQ izmantošanas piemērs,
        // kur mēs atlasām virknes reprezentāciju katrai grāmatai.
        var gramatuInformacija = gramatas.Select(book => book.ToString());

        foreach (var info in gramatuInformacija)
        {
            Console.WriteLine(info);
        }

        // Gaidām, kamēr lietotājs nospiež jebkuru taustiņu, lai konsole neaizvērtos uzreiz
        Console.WriteLine("\nNospiediet jebkuru taustiņu, lai pabeigtu...");
        Console.ReadKey();
    }
}