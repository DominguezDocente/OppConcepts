using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts.Geometry
{
    public class Rectangle
    {
        public string Draw()
        {
            int base1, height, x, y;
            base1 = 4;
            height = 9;
            string result = " " + Environment.NewLine;

            for (x = 1; x <= height; x++)
            {
                for (y = 1; y <= base1; y++)
                {
                    result += "*  ";
                }
                result += " " + Environment.NewLine;
            }

            return result;
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