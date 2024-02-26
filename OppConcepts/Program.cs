
using OppConcepts;
using OppConcepts.Geometry;
using System;

try
{

    Console.WriteLine("=======Empleados=========");
    Console.WriteLine("=========================");
    Console.WriteLine("=========================");
    Console.WriteLine("\n");

    Date date = new Date(2022, 5, 15);

    FullTimeEmployee emp2 = new FullTimeEmployee
    {
        Birthdate = date,
        Document = "222",
        Id = 2,
        Name = "Ana",
        Role = "CMO",
        Salary = 3500000
    };

    Console.WriteLine(emp2);

    Console.WriteLine("\n");


    Console.WriteLine("========Figuras==========");
    Console.WriteLine("=========================");
    Console.WriteLine("=========================");
    Console.WriteLine("\n");

    Square square = new Square
    {
        Color = "Blue",
        Side = 5
    };

    Rectangle rectangle = new Rectangle
    {
        Color = "Red",
        Base = 4,
        Height = 8,
    };

    Circle circle = new Circle
    {
        Color = "Green",
        Radius = 7
    };

    List<Shape> shapes = new List<Shape>
    { 
        square,
        rectangle,
        circle
    };

    Console.WriteLine("=========================");
    foreach (Shape shape in shapes)
    {
        Console.WriteLine(shape);
        Console.WriteLine(Environment.NewLine);

        // LLamado para saber si el objeto implementa la interfaz
        //if (shape is IDrawable)
        //{
        //    System.Reflection.MethodInfo method = typeof(IDrawable).GetMethod("Draw");
        //    Console.WriteLine(method.Invoke(shape, null));
        //}

        switch (shape.Color)
        {
            case "Red": Console.ForegroundColor = ConsoleColor.Red; break;
            case "Green": Console.ForegroundColor = ConsoleColor.Green; break;
            case "Blue": Console.ForegroundColor = ConsoleColor.Blue; break;
        }
        
        Console.WriteLine(shape.Draw());

        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("=========================");
        Console.WriteLine("\n");

    }



}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
