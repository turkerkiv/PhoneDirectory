namespace PhoneDirectory;

class Program
{
    static void Main(string[] args)
    {
        Phone myNewPhone = new Phone();
        myNewPhone.AddNumber("John", "123456789");
        myNewPhone.AddNumber("Mary", "987654321");
        myNewPhone.AddNumber("Peter", "123987456");
        myNewPhone.AddNumber("Josh", "124656789");
        myNewPhone.AddNumber("Marie", "982544321");

        while (true)
        {
            Console.WriteLine("Please select an action from the list below:");
            Console.WriteLine("1. Add a new number");
            Console.WriteLine("2. Delete a number");
            Console.WriteLine("3. Update a number");
            Console.WriteLine("4. List all numbers");
            Console.WriteLine("5. Search for a number");

            int userChoice = int.TryParse(Console.ReadLine(), out userChoice) ? userChoice : 0;
            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("Please enter the name of the person you want to add:");
                    string nameToAdd = Console.ReadLine();
                    Console.WriteLine("Please enter the number of the person you want to add:");
                    string numberToAdd = Console.ReadLine();
                    myNewPhone.AddNumber(nameToAdd, numberToAdd);
                    break;
                case 2:
                    Console.WriteLine("Please enter the name of the person you want to delete:");
                    string nameToDelete = Console.ReadLine();
                    myNewPhone.DeleteNumber(nameToDelete);
                    break;
                case 3:
                    Console.WriteLine("Please enter the name of the person you want to update:");
                    string nameToUpdate = Console.ReadLine();
                    Console.WriteLine("Please enter the new number of the person you want to update:");
                    string newNumber = Console.ReadLine();
                    myNewPhone.UpdateNumber(nameToUpdate, newNumber);
                    break;
                case 4:
                    myNewPhone.ListAllNumbers();
                    break;
                case 5:
                    Console.WriteLine("Please enter the name of the person you want to search:");
                    string nameToSearch = Console.ReadLine();
                    Console.WriteLine(myNewPhone.SearchNumber(nameToSearch));
                    break;
                default:
                    Console.WriteLine("Please select a option...");
                    break;
            }

            Console.WriteLine("Press any key to continue or ESC to exit");
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                break;
            }
        }

    }
}
