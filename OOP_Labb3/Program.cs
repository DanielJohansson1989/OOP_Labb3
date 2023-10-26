namespace OOP_Labb3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry rectangle = new Rectangle();

            Geometry square = new Square();

            Geometry circle = new Circle();

            Console.WriteLine($"Area of rectangle: {rectangle.Area()}");

            Console.WriteLine($"Area of square: {square.Area()}");

            Console.WriteLine($"Area of circle: {circle.Area()}");
        }
    }
}