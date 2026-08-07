// array = a variable that can store multiple values. fixed size

// String[] cars = {"BMW", "Mustang", "Corvette"};

String[] cars = new string[3];  // declare array and then assign values

cars[0] = "Tesla";
cars[1] = "Mustang";
cars[2] = "Corvette";
// cars[3] = "Audi"; // this won't work -> index outsude the bounds fo the array

Console.WriteLine(cars[0]);
Console.WriteLine(cars[1]);
Console.WriteLine(cars[2]);
// Console.WriteLine(cars[3]);

for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine(cars[i]);
}