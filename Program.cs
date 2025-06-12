using System;
using System.Text; // Nepieciešams Encoding klasei

// Klases definīcija
class Student
{
    // Īpašības (Properties)
    // 'public' nozīmē, ka šīm īpašībām var piekļūt no jebkuras vietas programmā.
    // 'string' ir teksta datu tips, 'int' ir vesela skaitļa datu tips.
    public string Vards { get; set; }
    public int Vecums { get; set; }

    // Metode
    // 'public' nozīmē, ka šo metodi var izsaukt no jebkuras vietas.
    // 'void' nozīmē, ka metode neatgriež nekādu vērtību.
    public void Sveicinaties()
    {
        Console.WriteLine($"Sveiki! Mani sauc {Vards} un man ir {Vecums} gadi.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Iestata konsoles izvades un ievades kodējumu uz UTF-8
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8; // Ieteicams arī ievadei

        Console.WriteLine("Studenta objekta izveide un metodes izsaukšana.");
        Console.WriteLine("---------------------------------------------");

        // 1. Izveidojam jaunu Student klases objektu
        // 'new Student()' izsauc Student klases konstruktoru un izveido jaunu objektu atmiņā.
        // 'students1' ir mainīgais, kas glabā atsauci uz šo objektu.
        Student students1 = new Student();

        // 2. Piešķiram vērtības objekta īpašībām
        students1.Vards = "Anna";
        students1.Vecums = 20;

        // 3. Izsaucam objekta metodi
        // Mēs izmantojam 'students1' objektu, lai piekļūtu tā metodei 'Sveicinaties()'.
        students1.Sveicinaties(); // Izvada: "Sveiki! Mani sauc Anna un man ir 20 gadi."

        Console.WriteLine("\nIzveidojam vēl vienu studenta objektu...");

        // Var izveidot arī citu Student objektu
        Student students2 = new Student
        {
            Vards = "Jānis",
            Vecums = 22
        };

        students2.Sveicinaties(); // Izvada: "Sveiki! Mani sauc Jānis un man ir 22 gadi."

        // Gaidām, kamēr lietotājs nospiež jebkuru taustiņu, lai konsole neaizvērtos uzreiz
        Console.WriteLine("\nNospiediet jebkuru taustiņu, lai pabeigtu...");
        Console.ReadKey();
    }
}