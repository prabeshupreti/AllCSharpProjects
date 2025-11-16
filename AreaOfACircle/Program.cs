
double Radius;
double Area;

const double PI = (float)355 / 113;

Console.Write("Enter the radius of a circle: ");
Radius = double.Parse(Console.ReadLine());

Area = PI * Radius * Radius;

Console.WriteLine($"The area of a circle is {Math.Round(Area, 2)}.");

