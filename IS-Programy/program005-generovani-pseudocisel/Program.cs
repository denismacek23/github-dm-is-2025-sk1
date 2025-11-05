string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Generování pseudonáhodných čísel *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Denis Macek ********");
    Console.WriteLine("****************************");
    Console.WriteLine();

    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;

    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel: ");
    }

     Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;

    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez: ");
    }

     Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;

    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez: ");
    }

    Console.WriteLine();
    Console.WriteLine("*************************");
    Console.WriteLine("Zadané hodnoty: ");
    Console.WriteLine("Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2};", n, lowerBound, upperBound);
    Console.WriteLine("*************************");

    //Deklarace pole
    int[] myRandNumbs = new int[n];

    Random myRandNumb = new Random();

    int negativeNumbs = 0;
    int positiveNumbs = 0;
    int zeroes = 0;


    int evenNumbs = 0;
    int oddNumbs = 0;

    
    
    Console.WriteLine();
    Console.WriteLine("*************************");
    Console.WriteLine("Pseudonáhodná čísla:");
    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound);
        Console.WriteLine("{0}; ", myRandNumbs[i]);

        /* if (myRandNumbs[i] < 0)
             negativeNumbs++;
         if (myRandNumbs[i] > 0)
             positiveNumbs++;
         if (myRandNumbs[i] == 0)
             zeroes++;*/


        if (myRandNumbs[i] < 0)
            negativeNumbs++;
        else if (myRandNumbs[i] > 0)
            positiveNumbs++;
        else 
            zeroes++;
    }

    Console.WriteLine();
    Console.WriteLine("*************************");
    Console.WriteLine("*************************");
    Console.WriteLine("Počet záporných: {0};", negativeNumbs);
    Console.WriteLine("Počet kladných: {0};", positiveNumbs);
    Console.WriteLine("Počet nul: {0};", zeroes);
    Console.WriteLine("*************************");
    Console.WriteLine("Počet sudých čísel: {0};", evenNumbs);
    Console.WriteLine("Počet lichých čísel: {0};", oddNumbs);

    


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}