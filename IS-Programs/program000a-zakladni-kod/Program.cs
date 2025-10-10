string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("******Výpis řady čísel******");
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
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'.");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    again = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.


}