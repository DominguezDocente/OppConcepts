
using OppConcepts;
using OppConcepts.Geometry;
using System;

try
{

    Console.WriteLine("=======Empleados=========");
    Console.WriteLine("=========================");
    Console.WriteLine("=========================");
    Console.WriteLine("\n");

    FullTimeEmployee emp1 = new FullTimeEmployee
    {
        Birthdate = new Date(1999, 6, 8),
        Document = "222",
        Id = 2,
        Name = "Ana",
        Role = "CMO",
        Salary = 3500000
    };


    Date date = new Date(1995, 5, 15);

    Employee emp2 = new PartialTimeEmployee
    {
        Birthdate = date,
        Document = "222",
        Id = 2,
        Name = "Ana",
        Role = "CMO",
        Hours = 40,
        HourValue = 95000.45M,
    };

    Payroll payroll = new Payroll
    {
        Description = "Pago a empleados de febrero",
        Id= 222,
        PayrollDate = new Date(2024, 2, 26),
        Employees = new List<Employee> { emp1, emp2 }
    };

    Console.WriteLine(payroll.ToString());

    Console.WriteLine("\n");


    //Console.WriteLine("========Figuras==========");
    //Console.WriteLine("=========================");
    //Console.WriteLine("=========================");
    //Console.WriteLine("\n");

    //Square square = new Square
    //{
    //    Color = "Blue",
    //    Side = 3
    //};

    //Rectangle rectangle = new Rectangle
    //{
    //    Color = "Red",
    //    Base = 4,
    //    Height = 8,
    //};

    //Circle circle = new Circle
    //{
    //    Color = "Green",
    //    Radius = 7
    //};

    //List<Shape> shapes = new List<Shape>
    //{ 
    //    square,
    //    rectangle,
    //    circle
    //};

    //Console.WriteLine("=========================");
    //foreach (Shape shape in shapes)
    //{
    //    Console.WriteLine(shape);
    //    Console.WriteLine(Environment.NewLine);

    //    // LLamado para saber si el objeto implementa la interfaz
    //    //if (shape is IDrawable)
    //    //{
    //    //    System.Reflection.MethodInfo method = typeof(IDrawable).GetMethod("Draw");
    //    //    Console.WriteLine(method.Invoke(shape, null));
    //    //}

    //    switch (shape.Color)
    //    {
    //        case "Red": Console.ForegroundColor = ConsoleColor.Red; break;
    //        case "Green": Console.ForegroundColor = ConsoleColor.Green; break;
    //        case "Blue": Console.ForegroundColor = ConsoleColor.Blue; break;
    //    }
        
    //    Console.WriteLine(shape.Draw());

    //    Console.ForegroundColor = ConsoleColor.White;

    //    Console.WriteLine("=========================");
    //    Console.WriteLine("\n");

    //}



}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
