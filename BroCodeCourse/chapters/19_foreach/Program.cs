// array = a variable that can store multiple values. fixed size

String[] cars = {"BMW", "Mustang", "Corvette"};

Console.WriteLine(cars[0]);
Console.WriteLine(cars[1]);
Console.WriteLine(cars[2]);
// Console.WriteLine(cars[3]);

for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine(cars[i]);
}

foreach (String car in cars)
{
    Console.WriteLine(car);
}