string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Seřazení dvou čísel *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Denis Macek ********");
    Console.WriteLine("****************************");
    Console.WriteLine();

    //Vstup hodnoty do programu - řešený správně
    Console.Write("Zadejte celé číslo - hodnota A: ");
    int a;

    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu hodnotu A: ");
    }

    Console.Write("Zadejte celé číslo - hodnota B: ");
    int b;

    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu hodnotu B: ");
    }

    Console.WriteLine();
    int pom;
    if (a > b)
    {
        pom = a;
        a = b;
        b = pom;
    }

    Console.WriteLine($"Seřazená čísla: {a}, {b}");







    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();

}