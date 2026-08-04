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

int attackPower;

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