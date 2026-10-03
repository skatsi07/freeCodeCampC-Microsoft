// Collect the bill amount and tip percentage
Console.WriteLine("Enter your bill details:\n");
Console.Write("Bill amount: ");
decimal billAmount = Convert.ToDecimal(Console.ReadLine());
Console.Write("Tip Percentage: ");
decimal tipPercentage = Convert.ToDecimal(Console.ReadLine());

// Display the entered values
Console.WriteLine("\nBill Details...");
Console.WriteLine($"The total bill is: {billAmount}");
Console.WriteLine($"Tip percentage: {tipPercentage}");

// Calculate the tip and total
decimal tipAmount = billAmount * (tipPercentage / 100m);
decimal totalAmount = billAmount + tipAmount;

// Display the results
Console.WriteLine($"");
Console.WriteLine($"The tip amount is: {tipAmount}");
Console.WriteLine($"The total is: {totalAmount}");