using System.Security.Cryptography;

Console.WriteLine("RPG Attack Calculator");

Console.WriteLine("Enter your name: ");
String Name = Console.ReadLine() ?? string.Empty;

if (string.IsNullOrWhiteSpace(Name))
{
    Console.WriteLine("Your name cannot be empty.");
    return;
}

Console.WriteLine("Enter your character class: ");
String ChClass = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();

if (string.IsNullOrWhiteSpace(ChClass))
{
    Console.WriteLine("Your character class cannot be empty.");
    return;
}

Console.WriteLine("Enter the level of your character: ");
int ChLevel = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the strength of your character: ");
int strength = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the intellgience of your character: ");
int intelligence = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the agility of your character: ");
int agility = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the coordinates of the enemy: ");
Console.WriteLine("x: ");
int enemyX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("y: ");
int enemyY = Convert.ToInt32(Console.ReadLine());



// Távolság számítás
double xPow = Math.Pow(enemyX, 2); 
double yPow = Math.Pow(enemyY, 2); 
double distance = Math.Sqrt(xPow + yPow);

Console.WriteLine("The enemy distance is " + distance);

int attackPower = 0;

// Alap támadóerő
switch (ChClass)
{
    case "warrior":
        attackPower = strength * 2 + ChLevel;
        break;
    case "mage":
        attackPower = intelligence * 2 + ChLevel;
        break;
    case "rogue":
        attackPower = agility * 2 + ChLevel;
        break;
    default:
        Console.WriteLine("Unknown class.");
        break;
}

if (distance > 15)
{
    attackPower = 0;
    Console.WriteLine("The attack does not reach the enemy");
    return;
}
else if (distance > 8)
{
    attackPower -= 5;
}
else
{
    attackPower += 5;
}

Random random = new Random();

int randomNumber = random.Next(1, 101);
bool criticalHit = false;

if (randomNumber <= 20)
{
    attackPower *= 2;
    Console.WriteLine("Critical hit!");
    criticalHit = true;
}
else
{
    Console.WriteLine("Regular attack!");
}


// Ellenfél ereje
int enemyPower = random.Next(25, 71);

// Győzelem eldöntés
if (attackPower >= enemyPower)
{
    Console.WriteLine($"Player wins! {Name} defeated the enemy!");
}
else
{
    Console.WriteLine("Enemy survives!");
}

Console.WriteLine("Player: " + Name);
Console.WriteLine("Class: " + ChClass);
Console.WriteLine("Distance: " + distance);
Console.WriteLine("Final Attack Power: " + attackPower);
Console.WriteLine("Enemy Power: " + enemyPower);
Console.WriteLine("Ciritcal hit: " + criticalHit);