// Collect the bill amount and tip percentage
decimal billAmount = 45.50m;
decimal tipPercentage = 18.0m;

// Display the entered values
Console.WriteLine("Bill Details...")
Console.WriteLine($"The total bill is: {billAmount}");
Console.WriteLine($"Tip percentage: {tipPercentage}");

// Calculate the tip and total
decimal tipAmount = billAmount * (tipPercentage / 100m);
decimal totalAmount = billAmount + tipAmount;

// Display the results
Console.WriteLine($"")
Console.WriteLine($"The tip amount is: {tipAmount}");
Console.WriteLine($"The total is: {totalAmount}");