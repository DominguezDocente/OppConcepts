using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts
{
    public class ComissionBaseEmployee : CommissionEmployee
    {
        public decimal Salary { get; set; }

        public override decimal GetPayment()
        {
            return base.GetPayment() + Salary;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"{Environment.NewLine} Total en ventas.......: {TotalSalesValue:C2}" +
                $"{Environment.NewLine} Porcenjaje de comisión: {CommisionPercentage:P2}" +
                $"{Environment.NewLine} Salario...............: {Salary:C2}" +
                $"{Environment.NewLine} -----------------------------------" +
                $"{Environment.NewLine} Pago..................: {GetPayment():C2}";
        }
    }
}
