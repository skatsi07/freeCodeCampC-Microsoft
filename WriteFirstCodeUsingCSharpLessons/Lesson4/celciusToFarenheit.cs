// Store a Fahrenheit temperature
Console.WriteLine("Enter the temperature in Fahrenheit:");
decimal fahrenheit = Convert.ToDecimal(Console.ReadLine());

// Convert it to Celsius
decimal celcius = (fahrenheit - 32m) * 5m/9m;

// Display the result
Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celcius} degrees Celsius");