using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts.Geometry
{
    public class Rectangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public override double GetArea()
        {
            return Base * Height;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"\n La figura es un Rectángulo" +
                   $"\n El valor de la Base es: {Base}" +
                   $"\n El valor de la Altura es: {Height}" +
                   $"\n El valor del Área es: {GetArea()}";
        }

    }
}
