
using OppConcepts;

try
{
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

    Console.WriteLine( emp2 );

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
