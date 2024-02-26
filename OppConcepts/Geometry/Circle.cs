using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts.Geometry
{
    public class Circle
    {
        public string Draw()
        {
            string result = " " + Environment.NewLine;
            int x, y, radious;
            radious = 7;
            for (x = 0; x <= radious * 2; x++)
            {
                for (y = 0; y <= radious * 2; y++)
                {
                    if (Math.Pow(y - radious, 2) + Math.Pow(x - radious, 2) <= (int)Math.Pow(radious, 2))
                    {
                        result += "*";
                    }
                    else
                    {
                        result += " ";
                    }
                }
                result += " " + Environment.NewLine;
            }

            return result;
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