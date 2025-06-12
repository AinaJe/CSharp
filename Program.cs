using System;
using System.Text; // Nepieciešams Encoding klasei

class Program
{
    static void Main(string[] args)
    {
        // Iestata konsoles izvades un ievades kodējumu uz UTF-8
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8; // Ieteicams arī ievadei


        string vards = "Aina";
        int gads = 1984;
        double vecums = 40.5;
        char dzimums = 's';
        bool irKakis = true;
        long lidzMenesim = 38440000000;


        Console.WriteLine($"Mani sauc {vards}, esmu dzimusi {gads}. gadā un man ir {vecums} gadi. Mans dzimums ir {dzimums}. Vai man ir mājās kaķis? {irKakis}. Līdz mēnesim ir {lidzMenesim} cm.");
        Console.ReadKey();
    }
}
