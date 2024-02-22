using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts.Geometry
{
    public class Square : Shape
    {
        public double Side { get; set; }

        public override double GetArea()
        {
            return Side * Side;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"\n La figura es un Cuadrado" +
                   $"\n El valor de los lades es: {Side}" +
                   $"\n El valor del Área es: {GetArea()}";
        }
    }
}
