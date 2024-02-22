using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts.Geometry
{
    public class Circle : Shape
    {
        public double Radious { get; set; }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radious, 2);
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"\n La figura es un Circulo" +
                   $"\n El valor del Radio es: {Radious}" +
                   $"\n El valor del Área es: {GetArea()}";
        }
    }
}
