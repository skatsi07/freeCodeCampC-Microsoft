Console.WriteLine("Please enter an integer between 5 and 10: ");
bool validInput = false;
int numericValue;


do{
    
    string input = Console.ReadLine();
    validInput = int.TryParse(input, out numericValue);

    if(validInput)
    {
        if (numericValue >= 5 && numericValue <= 10)
        {
            validInput = true;
        }
        else
        {
            Console.WriteLine("Please enter an integer between 5 and 10.");
            validInput = false;
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid integer.");
    }

}while(!validInput);
Console.WriteLine($"You entered {numericValue}");