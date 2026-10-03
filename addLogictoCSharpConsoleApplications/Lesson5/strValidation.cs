Console.WriteLine("Please enter Administrator, Manager, or User: ");
bool validInput = false;
string role = "placeholder";
string[] validRoles = { "administrator", "manager", "user" };


do{
    
    string input = Console.ReadLine();
    validInput = validRoles.Contains(input.ToLower().Trim());

    if(!validInput)
    {
        Console.WriteLine($"The role name that you entered, {input} is not valid. Enter your role name (Administrator, Manager, or User)");
    }
    else 
    {
        role = input;
    }

}while(!validInput);
Console.WriteLine($"Your input value ({role}) has been accepted.");