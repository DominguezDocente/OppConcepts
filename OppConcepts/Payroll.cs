using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts
{
    public class Payroll : IPay
    {
        public string Description { get; set; }
        public List<Employee> Employees { get; set; }
        public int Id { get; set; }
        public Date PayrollDate { get; set; }

        public decimal GetPayment()
        {
            decimal total = 0;

            foreach (Employee employee in Employees)
            {
                total += employee.GetPayment();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("=========NÓMINA============");

            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);

            sb.Append($"Nomina N°: {Id}");

            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);

            sb.Append($"Fecha: {PayrollDate}");

            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);

            sb.Append(Description);

            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);

            foreach (Employee employee in Employees)
            {
                sb.Append(employee.ToString());
                sb.Append(Environment.NewLine);
                sb.Append(Environment.NewLine);
            }

            sb.Append("===========================");
            sb.Append(Environment.NewLine);
            sb.Append($" TOTAL:................: {GetPayment():C2}");

            return sb.ToString();
        }
    }
}
