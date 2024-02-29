
using OppConcepts;
using OppConcepts.Geometry;
using System.Reflection;

try
{

    Console.WriteLine("=======Empleados=========");
    Console.WriteLine("=========================");
    Console.WriteLine("=========================");
    Console.WriteLine("\n");

    Date date = new Date(2022, 5, 15);

    Employee emp1 = new FullTimeEmployee
    {
        Birthdate = date,
        Document = "222",
        Id = 2,
        Name = "Ana",
        Role = "CMO",
        Salary = 3500000
    };


    Employee emp2 = new PartialTimeEmployee
    {
        Birthdate = new Date(1995, 5, 13),
        Document = "333",
        Id = 3,
        Name = "Jhon",
        Role = "COO",
        Hours = 40,
        HourValue = 95000.5M
    };


    Employee emp3 = new CommissionEmployee
    {
        Birthdate = new Date(1994, 5, 11),
        Document = "444",
        Id = 4,
        Name = "Juan",
        Role = "Vendedor",
        CommisionPercentage = 0.2,
        TotalSalesValue = 90000000,
    };

    Employee emp4 = new ComissionBaseEmployee
    {
        Birthdate = new Date(1996, 5, 8),
        Document = "555",
        Id = 5,
        Name = "Erika",
        Role = "MTO",
        CommisionPercentage = 0.2,
        TotalSalesValue = 4000000,
        Salary = 1000000
    };

    Payroll payroll = new Payroll
    {
        Description = "Pago Nómina Febrero",
        Id = 123,
        PayrollDate = new Date(2024, 2, 26),
        Employees = new List<Employee> { emp1, emp2, emp3, emp4 }
    };

    Console.WriteLine(payroll);

    //Console.WriteLine("========Figuras==========");
    //Console.WriteLine("=========================");
    //Console.WriteLine("=========================");
    //Console.WriteLine("\n");

    //Square square = new Square
    //{
    //    Color = "Blue",
    //    Side = 5
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

    //    //if (shape is IDrawable)
    //    //{
    //    //    MethodInfo method = typeof(IDrawable).GetMethod("Draw");
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
