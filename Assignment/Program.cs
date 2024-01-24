using Assignment;

List<Customer> customersList = new List<Customer>();
List<Order> orders = new List<Order>();

// Read data from files
CustomersFile("customers.csv");
Console.WriteLine("customerlist=" + customersList);

int option;
    do
    {
        DisplayMenu();
        option = GetOption();

        if (option == 1)
        {
            ListAllCustomers();
        }
        else if (option == 2)
        {
            //ListAllCurrentOrders();
        }
        else if (option == 0)
        {
            // Set the loop condition to false to exit the loop
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }

    } while (option != 0);


void DisplayMenu()
{
    Console.WriteLine("------------- MENU --------------");
    Console.WriteLine("[1] List all customers");
    Console.WriteLine("[2] List all current orders");
    Console.WriteLine("[0] Exit");
    Console.WriteLine("---------------------------------");
}

int GetOption()
{
    Console.Write("Enter your option: ");
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int option))
        {
            return option;
        }

        Console.WriteLine("Invalid input. Please enter a number.");
        Console.Write("Enter your option: ");
    }
}

void CustomersFile(string filePath)
{
    try
    {
        using (StreamReader sr = new StreamReader("customers.csv"))
        {
            string header = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] data = line.Split(',');
                string Name = data[0];
                int MemberId = Convert.ToInt32(data[1]);
                DateTime Dob = Convert.ToDateTime(data[2]);
                customersList.Add(new Customer(Name, MemberId, Dob));
            }
        }
    }

    catch (Exception e)
    {
        Console.WriteLine($"Error loading customers: {e.Message}");
    }
}

void ListAllCustomers() 
{
    Console.WriteLine("{0,-15} {1,-12} {2,-10}", "Name", "Member ID", "DOB");
    foreach (Customer s in customersList)
    {
        Console.WriteLine("{0,-15} {1,-12} {2,-10}", s.Name, s.MemberId, s.Dob.ToString("dd/MM/yyyy"));
    }
    Console.WriteLine();
}