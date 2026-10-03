Random random = new Random();
int current = random.Next(1, 11);
int heroHP = 10;
int monsterHP = 10;

do
{
    current = random.Next(1, 11);
    //hero attacking monster
    monsterHP -= current;
    Console.WriteLine($"Monster was damaged and lost {current} health and now has {monsterHP} health");

    if (monsterHP <= 0) 
    {
        Console.WriteLine("Monster wins!");
        break;
    }


    current = random.Next(1, 11);
    //monster attacking hero
    heroHP -= current;
    Console.WriteLine($"Hero was damaged and lost {current} health and now has {heroHP} health");

    if (heroHP <= 0) 
    {
        Console.WriteLine("Hero wins!");
        break;
    }

    Console.WriteLine(current);
} while (heroHP > 0 && monsterHP > 0);