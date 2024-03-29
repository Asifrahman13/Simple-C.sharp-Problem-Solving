

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration <=1)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} day! Renew now and save {discountPercentage}%!");
    discountPercentage = 20;
}


else if (daysUntilExpiration <=5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days! Renew now and save {discountPercentage}%!");
    discountPercentage = 10;
}


else if (daysUntilExpiration <=10)

{
    if (daysUntilExpiration!<=10)
    {
    Console.WriteLine();
    }

    else
    { 
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    }

}

else
{
    Console.WriteLine("Your subscription has expired.");
}