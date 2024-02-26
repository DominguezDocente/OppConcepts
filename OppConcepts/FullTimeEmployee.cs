using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts
{
    public class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }

        public override decimal GetPayment()
        {
            return Salary;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"{Environment.NewLine} Salario...............: {Salary:C2}" +
                $"{Environment.NewLine} ----------------------------------------" +
                $"{Environment.NewLine} Pago..................: {GetPayment():C2}";
        }
    }
}
