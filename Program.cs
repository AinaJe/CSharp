using System;
using System.Collections.Generic; // Nepieciešams List<T>
using System.Linq;                // Nepieciešams LINQ metodēm (Where, OrderBy, Select)
using System.Text;                // Nepieciešams Encoding klasei

// Klases definīcija
class Person
{
    public string Vards { get; set; }
    public int Vecums { get; set; }

    // Konstruktors, lai vieglāk izveidotu Person objektus
    public Person(string vards, int vecums)
    {
        Vards = vards;
        Vecums = vecums;
    }

    // Metode, lai ērti izvadītu Person objektu informāciju
    public override string ToString()
    {
        return $"Vārds: {Vards}, Vecums: {Vecums}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Iestata konsoles izvades un ievades kodējumu uz UTF-8
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8; // Ieteicams arī ievadei

        Console.WriteLine("Personu saraksts un LINQ operācijas.");
        Console.WriteLine("-----------------------------------");

        // 1. Izveidojam sarakstu (List) ar 5 Person objektiem
        List<Person> personas = new List<Person>
        {
            new Person("Anna", 25),
            new Person("Jānis", 18),
            new Person("Pēteris", 30),
            new Person("Līga", 22),
            new Person("Zane", 19)
        };

        Console.WriteLine("Sākotnējais personu saraksts:");
        foreach (var persona in personas)
        {
            Console.WriteLine(persona);
        }
        Console.WriteLine();

        // 2. Atlasīt personas, kas vecākas par 20 gadiem (izmantojot Where)
        // 'Where' ir LINQ paplašinājuma metode, kas filtrē elementus, pamatojoties uz nosacījumu.
        // Tā atgriež jaunu kolekciju (IEnumerable<Person>), kas satur tikai atbilstošos elementus.
        var personasVecakasPar20 = personas.Where(p => p.Vecums > 20);

        Console.WriteLine("Personas, kas vecākas par 20 gadiem:");
        foreach (var persona in personasVecakasPar20)
        {
            Console.WriteLine(persona);
        }
        Console.WriteLine();

        // 3. Sakārtot sarakstu pēc vārda (izmantojot OrderBy)
        // 'OrderBy' ir LINQ paplašinājuma metode, kas sakārto elementus augošā secībā, pamatojoties uz norādīto atslēgu.
        // Tā atgriež jaunu sakārtotu kolekciju (IOrderedEnumerable<Person>).
        var personasSakartotasPecVarda = personas.OrderBy(p => p.Vards);

        Console.WriteLine("Personas, sakārtotas pēc vārda:");
        foreach (var persona in personasSakartotasPecVarda)
        {
            Console.WriteLine(persona);
        }
        Console.WriteLine();

        // 4. Izvadīt tikai vārdus (izmantojot Select)
        // 'Select' ir LINQ paplašinājuma metode, kas transformē katru elementu jaunā formā.
        // Šeit mēs katru 'Person' objektu transformējam par tā 'Vards' vērtību (string).
        var tikaiVardi = personas.Select(p => p.Vards);

        Console.WriteLine("Tikai vārdi no saraksta:");
        foreach (var vards in tikaiVardi)
        {
            Console.WriteLine(vards);
        }
        Console.WriteLine();

        // Kombinētas LINQ operācijas:
        // Personas, kas vecākas par 20 gadiem, sakārtotas pēc vārda, un izvadīt tikai to vārdus.
        var filtrētiSakārtotiVardi = personas
                                    .Where(p => p.Vecums > 20)          // Vispirms filtrējam
                                    .OrderBy(p => p.Vards)             // Pēc tam sakārtojam
                                    .Select(p => p.Vards);             // Beigās atlasām tikai vārdus

        Console.WriteLine("Vārdi no personām, kas vecākas par 20 un sakārtoti:");
        foreach (var vards in filtrētiSakārtotiVardi)
        {
            Console.WriteLine(vards);
        }
        Console.WriteLine();


        // Gaidām, kamēr lietotājs nospiež jebkuru taustiņu, lai konsole neaizvērtos uzreiz
        Console.WriteLine("Nospiediet jebkuru taustiņu, lai pabeigtu...");
        Console.ReadKey();
    }
}