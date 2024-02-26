using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts.Geometry
{
    public abstract class Shape
    {
        public string Color { get; set; }

        public abstract double GetArea();

        public override string ToString()
        {
            return $" La Figura es de color: {Color}";
        }
    }
}
