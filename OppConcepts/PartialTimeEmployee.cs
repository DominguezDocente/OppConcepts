using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts
{
    public class PartialTimeEmployee : Employee
    {
        public int Hours { get; set; }
        public decimal HourValue { get; set; }

        public override decimal GetPayment()
        {
            return Hours * HourValue;
        }
        public override string ToString()
        {
            return base.ToString() +
                $"{Environment.NewLine} Horas Trabajadas......: {Hours}" +
                $"{Environment.NewLine} Valor Hora............: {HourValue:C2}" +
                $"{Environment.NewLine} ----------------------------------------" +
                $"{Environment.NewLine} Pago..................: {GetPayment():C2}";
        }
    }
}
