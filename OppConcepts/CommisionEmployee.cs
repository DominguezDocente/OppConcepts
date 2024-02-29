using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts
{
    public class CommissionEmployee : Employee
    {
        public decimal TotalSalesValue { get; set; }
        public double CommisionPercentage { get; set; }

        public override decimal GetPayment()
        {
            // Cast
            return TotalSalesValue * (decimal)CommisionPercentage;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"{Environment.NewLine} Total en ventas.......: {TotalSalesValue:C2}" +
                $"{Environment.NewLine} Porcenjaje de comisión: {CommisionPercentage:P2}" +
                $"{Environment.NewLine} -----------------------------------" +
                $"{Environment.NewLine} Pago..................: {GetPayment():C2}";
        }
    }
}
