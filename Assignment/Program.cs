using Assignment;

List<Customer> customers = new List<Customer>();
List<Order> orders = new List<Order>();

    // Load data from files
    LoadCustomersFromFile("customers.csv");

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
            ListAllCurrentOrders();
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



void LoadCustomersFromFile(string filePath)
{
    // load customers from a CSV file
    try
    {
        var lines = File.ReadAllLines(filePath);
        foreach (var line in lines.Skip(1))
        {
            var values = line.Split(',');
            string name = values[0];
            int memberId = int.Parse(values[1]);
            DateTime dob = DateTime.Parse(values[2]);

            customers.Add(new Customer(name, memberId, dob));
        }

        Console.WriteLine("Customers loaded successfully.");
    }
    catch (Exception e)
    {
        Console.WriteLine($"Error loading customers: {e.Message}");
    }
}
