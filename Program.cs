using System;
using System.Text; // Nepieciešams Encoding klasei

// Bāzes klase (Base Class)
class Vehicle
{
    // Metode, kas simulē transportlīdzekļa kustību
    public void Move()
    {
        Console.WriteLine("Transportlīdzeklis pārvietojas.");
    }
}

// Atvasinātā klase (Derived Class) - Bicycle manto no Vehicle
// Kolons (:) norāda mantojumu. Bicycle ir Vehicle veids.
class Bicycle : Vehicle
{
    // Metode, kas ir unikāla velosipēdam
    public void RingBell()
    {
        Console.WriteLine("Velosipēds zvana zvaniņu: Ding! Ding!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Iestata konsoles izvades un ievades kodējumu uz UTF-8
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8; // Ieteicams arī ievadei

        Console.WriteLine("Mantojuma demonstrācija ar Vehicle un Bicycle klasēm.");
        Console.WriteLine("-----------------------------------------------------");

        // 1. Izveidojam jaunu Bicycle klases objektu
        // Tā kā Bicycle manto no Vehicle, Bicycle objektam ir pieejamas abas metodes.
        Bicycle mansVelosipeds = new Bicycle();

        // 2. Izsaucam mantoto metodi no Vehicle klases
        Console.Write("Izsaucam mantoto Move() metodi: ");
        mansVelosipeds.Move();

        // 3. Izsaucam Bicycle klases unikālo metodi
        Console.Write("Izsaucam Bicycle klases RingBell() metodi: ");
        mansVelosipeds.RingBell();

        // Gaidām, kamēr lietotājs nospiež jebkuru taustiņu, lai konsole neaizvērtos uzreiz
        Console.WriteLine("\nNospiediet jebkuru taustiņu, lai pabeigtu...");
        Console.ReadKey();
    }
}