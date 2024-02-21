using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts
{
    public  abstract class Employee : IPay
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Document { get; set; }
        public Date Birthdate { get; set; }

        public abstract decimal GetPayment();

        public int test()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Empleado: {Name} | Cargo: {Role} | Documento: {Document} | Fecha de nacimiento: {Birthdate}";
        }
    }
}
