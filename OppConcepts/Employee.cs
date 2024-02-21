using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts
{
    public  class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Document { get; set; }
        public Date Birthdate { get; set; }

        public Employee()
        {

        }

        public Employee(int id, string name, string role, string document, Date birthdate)
        {
            Id = id;
            Name = name;
            Role = role;
            Document = document;
            Birthdate = birthdate;
        }

        public override string ToString()
        {
            return $"Empleado: {Name} | Cargo: {Role} | Documento: {Document} | Fecha de nacimiento: {Birthdate}";
        }
    }
}
