using System;

class PetsApp
{
    // Declare variables and ourAnimals array
    static int menuChoice;
    static int petIDCounter = 1;
    static int maxNumPets = 8;
    static int numArrMember = 0;
    static string[,] ourAnimals = new string[maxNumPets, 6];

    public static void showOutput()
    {
        // Loop for the main menu
        do
        {
            // Display the main menu
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. List all our current pet information.");
            if (numArrMember == maxNumPets){
                Console.WriteLine("YOU CANNOT add new animals ANYMORE.");
                Console.WriteLine($"\nWe currently have {numArrMember} pets that need homes. We can manage {maxNumPets-numArrMember} more.");
            } else{
                Console.WriteLine("2. Add new animals.");
            }
            Console.WriteLine("3. Ensure ages and physical descriptions are complete.");
            Console.WriteLine("4. Ensure nicknames and personality descriptions are complete.");
            Console.WriteLine(@"5. Edit an animal’s age.");
            Console.WriteLine(@"6. Edit an animal’s personality description.");
            Console.WriteLine("7. Display all cats with specified characteristics.");
            Console.WriteLine("8. Display all dogs with specified characteristics.");
            Console.WriteLine("9. Exit");
            Console.Write("\nEnter menu item selection (Type \"exit\" or 9 to close the program): ");

            // Read user's menu selection
            string? input = Console.ReadLine();

            // Check if the user wants to exit
            if (input is not null && input.ToLower() == "exit" || input == "9")
            {
                break;
            }

            // Validate and parse the user's input
            if (int.TryParse(input, out menuChoice))
            {
                // Switch based on the menu choice
                switch (menuChoice)
                {
                    case 1:
                        // List all ourAnimals array data
                        ListAllAnimals();
                        break;
                    case 2:
                        // Add new animals to the ourAnimals array
                        AddNewAnimal();
                        break;
                    case 3:
                        EnsureProperties("Age or Physical");
                        break;
                    case 4:
                        EnsureProperties("Personality or Nickname");
                        break;
                    case 5:
                        EditProperties("Age");
                        break;
                    case 6:
                        EditProperties("Personality");
                        break;
                    case 7:
                        ListAllAnimals("cats");
                        break;
                    case 8:
                        ListAllAnimals("dogs");
                        break;
                    // Add cases for other menu options here
                    default:
                        Console.WriteLine("Invalid menu choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number corresponding to the menu options.");
            }

        } while (true);

        Console.WriteLine("Exiting the program.");
    }

    // Function to list all ourAnimals array data
    static void ListAllAnimals(string type="all")
    {
        if (type == "all"){
            Console.WriteLine("\nList of all our current pet information:");
            for (int i = 0; i < ourAnimals.GetLength(0); i++)
            {
                if (ourAnimals[i, 0] != null)
                {
                    Console.WriteLine($"Pet ID: {ourAnimals[i, 0]} | Species: {ourAnimals[i, 1]} | Age: {ourAnimals[i, 2]} years | Physical: {ourAnimals[i, 3]} | Personality: {ourAnimals[i, 4]} | Nickname: {ourAnimals[i, 5]}");
                }
            }
        }
        else if (type == "cats"){
            Console.WriteLine("\nList of all our current cats information:");
            for (int i = 0; i < ourAnimals.GetLength(0); i++)
            {
                if (ourAnimals[i, 1] == "cat")
                {
                    Console.WriteLine($"Pet ID: {ourAnimals[i, 0]} | Species: {ourAnimals[i, 1]} | Age: {ourAnimals[i, 2]} years | Physical: {ourAnimals[i, 3]} | Personality: {ourAnimals[i, 4]} | Nickname: {ourAnimals[i, 5]}");
                }
            }
            
        }
        else if (type == "dogs"){
            Console.WriteLine("\nList of all our current dogs information:");
            for (int i = 0; i < ourAnimals.GetLength(0); i++)
            {
                if (ourAnimals[i, 1] == "dog")
                {
                    Console.WriteLine($"Pet ID: {ourAnimals[i, 0]} | Species: {ourAnimals[i, 1]} | Age: {ourAnimals[i, 2]} years | Physical: {ourAnimals[i, 3]} | Personality: {ourAnimals[i, 4]} | Nickname: {ourAnimals[i, 5]}");
                }
            }

        }
    }

    // Function to add new animals to the ourAnimals array
    static void AddNewAnimal()
    {
        if (numArrMember == maxNumPets){
            Console.WriteLine("YOU CANNOT add new animals ANYMORE.");
        } 
        else{
            Console.WriteLine($"\nWe currently have {numArrMember} pets that need homes. We can manage {maxNumPets-numArrMember} more.");
            Console.WriteLine("\nAdding a new animal:");
            for (int i = 0; i < ourAnimals.GetLength(0); i++)
            {
                if (ourAnimals[i, 0] == null)
                {
                    // Generate a new pet ID
                    string petID = petIDCounter.ToString();
                    petIDCounter++;

                    Console.Write("Enter pet species (dog or cat): ");
                    string? species = Console.ReadLine();

                    Console.Write("Enter pet age (years): ");
                    string? age = Console.ReadLine();

                    Console.Write("Enter physical description: ");
                    string? physical = Console.ReadLine();

                    Console.Write("Enter personality description: ");
                    string? personality = Console.ReadLine();

                    Console.Write("Enter pet nickname: ");
                    string? nickname = Console.ReadLine();

                    // Save data to ourAnimals array
                    ourAnimals[i, 0] = petID;
                    ourAnimals[i, 1] = species is not null ? species : "";
                    ourAnimals[i, 2] = age is not null ? age : "";
                    ourAnimals[i, 3] = physical is not null ? physical : "";
                    ourAnimals[i, 4] = personality is not null ? personality : "";
                    ourAnimals[i, 5] = nickname is not null ? nickname : "";

                    Console.WriteLine("New animal added successfully!");
                    break;
                }
            }
            numArrMember += 1;

        }
    }


    static void EnsureProperties(string type)
    {
        Console.WriteLine("\nChecking the animals:");
        for (int i = 0; i < ourAnimals.GetLength(0); i++)
        {
            if (type == "Age or Physical"){
                if (ourAnimals[i, 2] == "" || ourAnimals[i, 3] == "")
                {
                    Console.Write($"Age or Physical of Animal {ourAnimals[i, 0]} are NOT completed!");
                    Console.Write($"Age of Animal {ourAnimals[i, 0]} : {ourAnimals[i, 2]}");
                    Console.Write($"Physical of Animal {ourAnimals[i, 0]} : {ourAnimals[i, 3]}");
                    string? personality = Console.ReadLine();
                    break;
                } else{
                    Console.Write("Age or Physical are already completed!");
                }  
            }
            else if (type == "Personality or Nickname"){
                if (ourAnimals[i, 4] == "" || ourAnimals[i, 5] == "")
                {
                    Console.Write($"Personality or Nickname of Animal {ourAnimals[i, 0]} are NOT completed!");
                    Console.Write($"Personality of Animal {ourAnimals[i, 0]} : {ourAnimals[i, 4]}");
                    Console.Write($"Nickname of Animal {ourAnimals[i, 0]} : {ourAnimals[i, 5]}");
                    string? personality = Console.ReadLine();
                    break;
                } else{
                    Console.Write($"Personality or Nickname of Animal {ourAnimals[i, 0]} are already completed!");
                }
            }
        }
    }

    static void EditProperties(string type)
    {
        Console.WriteLine("\nEdit Property of the animals");
        Console.WriteLine("\nType ID number of the animals that want you change");
        string? idAnimal = Console.ReadLine();
        bool found = false;
        if (type == "Age"){
            Console.WriteLine("\nType new Age:");
            string? newAge = Console.ReadLine();
            for (int i = 0; i < ourAnimals.GetLength(0); i++)
            {
                if (idAnimal is not null && ourAnimals[i, 0] == idAnimal)
                {
                    ourAnimals[i, 2] = newAge is not null ? newAge : ourAnimals[i, 2];
                    Console.Write($"Age of Animal {ourAnimals[i, 0]} already changed!");
                    found = true;
                    break;
                }
            }
            if (!found){
                Console.Write($"Data is NOT FOUND, ID may be Invalid");
            }
        }
        else if (type == "Personality"){
            Console.WriteLine("\nType new Personality:");
            string? newPersonality = Console.ReadLine();
            for (int i = 0; i < ourAnimals.GetLength(0); i++)
            {
                if (idAnimal is not null && ourAnimals[i, 0] == idAnimal)
                {
                    ourAnimals[i, 4] = newPersonality is not null ? newPersonality : ourAnimals[i, 4];
                    Console.Write($"Age of Animal {ourAnimals[i, 0]} already changed!");
                    found = true;
                    break;
                }
                if (!found){
                    Console.Write($"Data is NOT FOUND, ID may be Invalid");
                }
            }
        }
    }
}
