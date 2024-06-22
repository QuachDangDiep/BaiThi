using BaiThi;

class Program
{
    static void Main(string[] args)
    {
        ContactManager contactManager = new ContactManager();
        int choice;

        do
        {
            Console.WriteLine("\nContact Manager Menu");
            Console.WriteLine("1. Add new contact");
            Console.WriteLine("2. Find a contact by name");
            Console.WriteLine("3. Display all contacts");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter phone number: ");
                        string phone = Console.ReadLine();
                        contactManager.AddContact(name, phone);
                        break;
                    case 2:
                        Console.Write("Enter name to find: ");
                        string nameToFind = Console.ReadLine();
                        contactManager.FindContact(nameToFind);
                        break;
                    case 3:
                        contactManager.DisplayContacts();
                        break;
                    case 4:
                        Console.WriteLine("Exiting the program.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

        } while (choice != 4);
    }
}

