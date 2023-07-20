namespace AddressBook
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System");
            AddressBooks addressBook = new AddressBooks();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1. Create Contact \n2. Edit Contact \n3. Delete Contact \n4. Add Multiple Contact" +
                    " \n5. Create Multiple Address Book \n6. Check for duplicate entry\n7. Check Contact details by City Or State \n8. View Person by city or state  \n9. Exit ");
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        addressBook.Details();
                        addressBook.Display();
                        break;
                    case 2:
                        addressBook.Details();
                        addressBook.Display();
                        Console.WriteLine("Enter the name of the person whose contact details you want to edit");
                        string name = Console.ReadLine();
                        addressBook.EditContact(name);
                        addressBook.Display();
                        break;
                    case 3:
                        addressBook.Details();
                        addressBook.Display();
                        Console.WriteLine("Enter the name of the person whose contact details you want to delete");
                        string pname = Console.ReadLine();
                        addressBook.DeleteContact(pname);
                        addressBook.Display();
                        break;
                    case 4:
                        addressBook.Details();
                        addressBook.Display();
                        flag = false;
                        break;
                    case 5:
                        addressBook.Details();
                        addressBook.DisplayAdressBook();
                        flag = false;
                        break;
                    case 6:
                        addressBook.Details();
                        addressBook.DisplayAdressBook();
                        addressBook.CheckDuplicateEntryOfAContact();
                        flag = false;
                        break;
                    case 7:
                        addressBook.Details();
                        addressBook.DisplayAdressBook();
                        Console.WriteLine("Enter the name of city or state which state or city contact details you want");
                        string cityOrstate= Console.ReadLine();
                        addressBook.SearchByCityOrState(cityOrstate);
                        addressBook.Display();
                        break;
                    case 8:
                        addressBook.Details();
                        addressBook.DisplayAdressBook();
                        addressBook.CreateCityDictionary();
                        addressBook.CreateStateDictionary();

                        Console.WriteLine("Enter the city name to view persons:");
                        string city = Console.ReadLine();
                        addressBook.ViewPersonsByCity(city);

                        Console.WriteLine("Enter the state name to view persons:");
                        string state = Console.ReadLine();
                        addressBook.ViewPersonsByState(state);   
                        break;

                    case 9:
                        flag = false;
                        Console.WriteLine("Exist");
                        break;
                    default:
                        Console.WriteLine("Please choose the correct option");
                        break;
                }
            }
        }
    }
}