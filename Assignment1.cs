// See https://aka.ms/new-console-template for more information

namespace CshIntermediate.Assignment1
{
    class Assignment1
    {
        public static void run()
        {
            List<Pet> myPets = new List<Pet>();

            string mainPrompt = "Enter letter to create one of the following Pets\n";
            mainPrompt += "D - for a dog\n";
            mainPrompt += "B - for a bird\n";
            mainPrompt += "F - for a fish\n";
            mainPrompt += "L - for a lizzard\n";
            mainPrompt += "X - Next step\n";

            // collect pets from user
            string letter = getString(mainPrompt);
            Console.WriteLine("");
            while (letter != "X")
            {
                Pet pet; string name;
                switch (letter.ToUpper())
                {
                    case "D":
                        name = getString("Dog's name: ");
                        pet = new Dog(name, "Woof");
                        break;
                    case "B":
                        name = getString("Bird's name: ");
                        pet = new Bird(name, "Tweet");
                        break;
                    case "F":
                        name = getString("Fish's name: ");
                        pet = new Fish(name, "[silent blob]");
                        break;
                    case "L":
                    default:
                        name = getString("Lizzard's name: ");
                        pet = new Lizzard(name, "[silent tongue flick]");
                        break;
                }

                myPets.Add(pet);
                Console.WriteLine("");
                letter = getString(mainPrompt);
            }

            string secondPrompt = "Choose a pet and an action";
            string petChoices = "";
            for (int i = 0; i < myPets.Count; i++) petChoices += $"{i + 1} - {myPets[i].name} ({myPets[i].PetType}); ";
            petChoices += "\n0 - to end\n";
            string petActions = "1 - Move, 2 - Sleep, 3 - Make sound";
            petActions += "\n0 - to end\n";

            Console.WriteLine(secondPrompt);
            int number = getInt(petChoices);
            while (number != 0)
            {
                if (number > myPets.Count)
                {
                    Console.WriteLine("Invalid entry. Exiting");
                    return;
                }
                if (number == 0) break;

                Pet pet = myPets[number - 1];
                Console.WriteLine($"You chose {pet.name}. Now choose an action");
                number = getInt(petActions);
                if (number == 0) break;

                switch (number)
                {
                    case 1:
                        int meters = pet.move();
                        Console.WriteLine("");
                        Console.WriteLine($"{pet.name} moved {meters} meters");
                        break;
                    case 2:
                        int hours = getInt("for how many hours? ");
                        Console.WriteLine("");
                        pet.sleep(hours);
                        break;
                    case 3:
                        int times = getInt("how many times? ");
                        Console.WriteLine("");
                        pet.makeSound(times);
                        break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Invalid entry. Exiting");
                        return;
                }

                Console.WriteLine("");
                Console.WriteLine(secondPrompt);
                number = getInt(petChoices);
            }
        }

        // helpers
        static int getInt(string prompt)
        {
            Console.Write(prompt);
            var input = Console.ReadLine();

            return input == null ? 0 : int.Parse(input);
        }

        static string getString(string prompt)
        {
            Console.Write(prompt);
            var input = Console.ReadLine();

            return input == null ? "" : input;
        }
    }
}
