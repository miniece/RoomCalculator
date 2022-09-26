Console.WriteLine("Hello! Welcome to Minnie's Room Calculator!");
Console.WriteLine("");

//getting user data//
Console.Write("Enter length: ");
double length = double.Parse(Console.ReadLine());

Console.Write("Enter width: ");
double width = double.Parse(Console.ReadLine());

Console.Write("Enter height: ");
double height = double.Parse(Console.ReadLine());

//calculations//
double roomArea = length * width;
double roomPerimeter = (width * 2) + (length * 2);
double roomVolume = length * width * height;
double roomSurfaceArea = 2 * (length * height) + 2 * (width * height) + 2 * (length * width);
//outputting user data//
Console.WriteLine("Area: " + roomArea);
Console.WriteLine("Perimeter: " + roomPerimeter);
Console.WriteLine("Volume: " + roomVolume);
Console.WriteLine("Surface Area: " + roomSurfaceArea);

//outputting size of rooms//
if (roomArea <= 250)
{
    Console.WriteLine("This is a small-sized room.");
}
else if (roomArea < 650)
{
    Console.WriteLine("This is a medium-sized room.");
}
else if (roomArea >= 650)
{
    Console.WriteLine("This is a large-sized room.");
}

Console.WriteLine("Thank you for using Minnie's Room Calculator!");
