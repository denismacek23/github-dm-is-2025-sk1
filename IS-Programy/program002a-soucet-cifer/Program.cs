string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Výpis řady čísel *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Denis Macek ********");
    Console.WriteLine("****************************");
    Console.WriteLine();

    //Vstup hodnoty do programu - řešený správně
    Console.Write("Zadejte celé číslo pro nějž chcete určit součet a součin cifer: ");
    int number;

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu celé číslo pro nějž chcete určit součet a součin cifer:: ");
    }


    int suma = 0;
    int numberBackup = number;
    int digit;

    if (number < 0) {
    
        number = -number;
    }

    while (number >= 10)
    {
        digit = number % 10; // zbytek po dělení nám bude určovat jednotlivé cifry
        number = (number - digit) / 10;
        Console.WriteLine("Digit: {0}", digit);
        suma = suma + digit;

    }
    Console.WriteLine();
    Console.WriteLine("Součet cifer čísla {0} je {1},", numberBackup, suma);

    // nesmime zapomenout přičíst poslední číslici do sumy
    suma = suma + number;
    Console.WriteLine("Součet cifer čísla {0} je {1},", numberBackup, suma);
   
   
   Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}