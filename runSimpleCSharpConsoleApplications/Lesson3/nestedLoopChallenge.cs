// initialise array
string[] orders = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

// output each order starting with B
foreach (string order in orders)
{
    if (order.StartsWith("B")){
        Console.WriteLine(order);
    };
}   
