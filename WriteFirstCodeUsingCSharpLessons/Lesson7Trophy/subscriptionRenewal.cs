// Generate a random number of days until expiration
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Display an expiration message based on the days remaining
if (daysUntilExpiration == 0){
    Console.WriteLine("Your subscription has expired.");
} elseif (daysUntilExpiration == 1){
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
} elseif (daysUntilExpiration <= 5){
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days");
    discountPercentage = 10;
} elseif (daysUntilExpiration <= 10){
    Console.WriteLine("Your subscription expire soon. Renew now!");
} else {
    Console.WriteLine("Your subscription expires in more than 10 days.");
}

// Display a discount message if a discount applies
if (discountPercentage > 0){
    Console.WriteLine($"Renew now and you get a {discountPercentage}% discount!");
}