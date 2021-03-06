using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        // Part 1
        string[] favColor = { "Red object", "Orange object", "Yellow object", "Green object", "Blue object", };
        Console.WriteLine("Please name an object");
        string userText = Console.ReadLine();

        for (int i = 0; i < favColor.Length; i++)
        {
            favColor[i] = favColor[i].Replace("object", userText);
        }
        foreach (string colorString in favColor)
        {
            Console.WriteLine(colorString);
        }

        Console.ReadLine();

        // Part 2
        for (int j = 0; j <= 16; j += 4) //Used the <= operator requested in Part here.
        {
            Console.WriteLine(j);
        }

        Console.ReadLine();

        // Part 3 used <= operator in previous for loop

        for (int s = 0; s < 5; s += 1)
        {
            Console.WriteLine(s);
        }

        Console.ReadLine();


        // Part 4
        List<string> usStates = new List<string> { "Texas", "Ohio", "Florida", "Georgia", "California" };
        Console.WriteLine("Find out where each state falls in terms of highschool football recruiting ranking. Please choose from \nTexas \nOhio \nFlorida \nGeorgia \nCalifornia\n");

        bool goodState = false;

        do
        {
            string stateRank = Console.ReadLine();
            int z;
            for (z = 0; z < usStates.Count; z++)
            {
                if (usStates[z] == stateRank)
                {
                    goodState = true;
                    Console.WriteLine("The state you've selected is " + z + " in the index.\n");
                }
            }
            if (z > 4)
            {
                Console.WriteLine("Please choose a state listed below.");
                Console.WriteLine("\nTexas \nOhio \nFlorida \nGeorgia \nCalifornia\n");
            }

        }
        while (!goodState);



        //Part 5


        List<string> theAnimals = new List<string> { "Dog", "Dog", "Cat", "Bat", "Rat" }; //Ask the user to select text to search for in the list.
        Console.WriteLine("\nPlease choose an animal from the list below: \nDog \nDog \nCat \nBat \nRat ");
        bool match = false;



        

        do
        {
            string animalThink = Console.ReadLine();

            for (int i = 0; i < theAnimals.Count; i++)
            {
                if (theAnimals[i] == animalThink)
                {
                    match = true;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Your answer was not one listed above.. please try again"); // I'm having difficulty having this only repeat in the case that it has not ended
            Console.WriteLine("Please choose another animal from the list\n");
        }
        while (!match);

        // Part 6

        // creates list of clients
        List<string> myClients = new List<string> { "Sarah", "Daniel", "Doug", "Sarah", "Tom" };

        //created variable, groups matching items under the variable duplicates
        var duplicates = myClients.GroupBy(x => x)
            .SelectMany(g => g.Skip(1));

        foreach (string Client in myClients)
        {
            Console.WriteLine("\n" + Client);
            
            if (duplicates.Contains(Client)) // if duplicates var matches a client in myclients  this is stated after.
            {
                Console.WriteLine("The user " + Client + " appears in the list more than once.\n");
            }

        }
        Console.ReadLine();
    }
}
