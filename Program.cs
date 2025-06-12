using System;
using System.IO; // Nepieciešams failu sistēmas operācijām, piemēram, File.WriteAllText
using System.Text; // Nepieciešams Encoding klasei
using Newtonsoft.Json; // Nepieciešams JsonConvert klasei JSON serializācijai

// 1. Klases Person definīcija
// Šī klase apraksta personas datu struktūru.
public class Person
{
    // Publiska īpašība 'Name' (Vārds)
    public string Name { get; set; }

    // Publiska īpašība 'Age' (Vecums)
    public int Age { get; set; }

    // Publiska īpašība 'City' (Pilsēta)
    public string City { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Iestata konsoles izvades un ievades kodējumu uz UTF-8, lai nodrošinātu latviešu burtu attēlošanu.
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Personas objekta izveide un saglabāšana JSON failā.");
        Console.WriteLine("--------------------------------------------------");

        // 2. Izveidojam jaunu Person klases objektu
        Person person1 = new Person
        {
            Name = "Jānis Bērziņš",
            Age = 30,
            City = "Rīga"
        };

        // 3. Saglabājam Person objektu JSON failā

        // Definējam JSON faila nosaukumu
        string fileName = "person.json";

        try
        {
            // Serializējam Person objektu JSON formāta virknē.
            // Formatting.Indented nodrošina, ka JSON fails būs vieglāk lasāms ar atkāpēm.
            string json = JsonConvert.SerializeObject(person1, Formatting.Indented);

            // Uzrakstām ģenerēto JSON virkni failā.
            // Ja fails neeksistē, tas tiks izveidots. Ja tas jau pastāv, tā saturs tiks pārrakstīts.
            File.WriteAllText(fileName, json);

            Console.WriteLine($"Persona veiksmīgi saglabāta failā: {fileName}");
            Console.WriteLine("Faila saturs:");
            Console.WriteLine(json); // Parādām arī konsolē, kas tika saglabāts
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Kļūda saglabājot personu JSON failā: {ex.Message}");
        }

        // Gaidām, kamēr lietotājs nospiež jebkuru taustiņu, lai konsole neaizvērtos uzreiz
        Console.WriteLine("\nNospiediet jebkuru taustiņu, lai pabeigtu...");
        Console.ReadKey();
    }
}