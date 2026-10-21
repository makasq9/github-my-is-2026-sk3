// Program 001 - Výpis řady čísel
// Autor: Maksym Yatsenko

string again = "a";

// .ToLower() převede vstup na malá písmena,
// takže program bude pokračovat při zadávání "a" tak i "A"
while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("======================================");
    Console.WriteLine("   PROGRAM 001: VÝPIS ŘADY ČÍSEL");
    Console.WriteLine("======================================");
    Console.WriteLine();

    // Načtení vstupních hodnot od uživatele
    Console.Write("Zadejte první hodnotu (first): ");
    int first = int.Parse(Console.ReadLine() ?? "1");

    Console.Write("Zadejte poslední hodnotu (last): ");
    int last = int.Parse(Console.ReadLine() ?? "10");

    Console.Write("Zadejte krok (step): ");
    int step = int.Parse(Console.ReadLine() ?? "1");

    Console.WriteLine();
    Console.WriteLine("--- Výstup řady ---");

    // Výpis řady pomocí cyklu
    if (step > 0)
    {
        for (int i = first; i <= last; i += step)
        {
            Console.WriteLine(i);
        }
    }
    else
    {
        Console.WriteLine("Krok musí být větší než 0!");
    }

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    Console.WriteLine("Následně potvrďte klávesou Enter.");
    Console.WriteLine("Jakoukoli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";
}
