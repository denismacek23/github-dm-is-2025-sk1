string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************");
    Console.WriteLine("**** Výpis řady čísel ****");
    Console.WriteLine("******************");
    Console.WriteLine("**** Denis Macek ****");
    Console.WriteLine("******************");
    Console.WriteLine();

    // vstup hodnoty do programu - špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    Console.Write("Zadejte první číslo řady(celé číslo): ");
    int first;

    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady: ");
    }



    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'.");
    again = Console.ReadLine();
}