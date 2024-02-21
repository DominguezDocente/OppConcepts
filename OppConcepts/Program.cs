
using OppConcepts;
using OppConcepts.Geometry;

try
{
    Square s = new Square();
    Console.WriteLine(s.Draw());

    Circle c = new Circle();
    Console.WriteLine(c.Draw());

    Rectangle r = new Rectangle();
    Console.WriteLine(r.Draw());

    //Date date = new Date(2022, 5, 15);

    //FullTimeEmployee emp2 = new FullTimeEmployee
    //{
    //    Birthdate = date,
    //    Document = "222",
    //    Id = 2,
    //    Name = "Ana",
    //    Role = "CMO",
    //    Salary = 3500000
    //};

    //Console.WriteLine( emp2 );

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
