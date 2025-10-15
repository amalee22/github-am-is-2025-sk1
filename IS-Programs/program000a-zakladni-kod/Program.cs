using System.Numerics;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("******Název Programu********");
    Console.WriteLine("****************************");
    Console.WriteLine("******Amálie Musilová*******");
    Console.WriteLine("****************************");
    Console.WriteLine();

    // vstup hodnoty do programu - špatně řešený 
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    // vstup hodnot do programu - řešený správně
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;

    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte hodnotu znovu: ");
    }

Console.Write("Zadejte poslední číslo řady (celé číslo): ");
    int last;

    while (!int.TryParse(Console.ReadLine(), out last))
{
        Console.Write("Nezadali jste celé číslo. Zadejte poslední číslo řady znovu: ");
    }

Console.Write("Zadejte diferenci (celé číslo): ");
    int step;

    while (!int.TryParse(Console.ReadLine(), out step))
{
        Console.Write("Nezadali jste celé číslo. Zadejte diferenci znovu: ");
    }

    // Výpis vstupních hodnot
    Console.WriteLine();
    Console.WriteLine("=========================================");

    Console.WriteLine("Zadali jste tyto hodnoty: ");
    Console.WriteLine("první číslo řady:  {0}", first);
    Console.WriteLine("poslední číslo řady:  {0}", last);
    Console.WriteLine("diference:  {0}", step);
    Console.WriteLine("=========================================");
    //vypsání všeho najednou, místo zvlášť
        Console.WriteLine("první číslo:{0}, poslední číslo:{1}, diference:{2}", first, last, step);
    Console.WriteLine("=========================================");
    

    //Výpis řady - samotný algoritmus
    Console.WriteLine();
    Console.WriteLine("=========================================");
    Console.WriteLine("Výpis číselné řady: ");
    int current = first;
    while (last <= current )
    {
        Console.WriteLine(current);
        current = current + step;//ruční přičtení diference 
        
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'.");

    again = Console.ReadLine();

    //zkouška pushe
}