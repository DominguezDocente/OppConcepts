using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts.Geometry
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override string Draw()
        {
            // Calcular el diámetro del círculo
            double diameter = Radius * 2;

            // Crear un string para almacenar el círculo
            string circleString = "";

            // Iterar sobre cada fila
            for (double row = 0; row <= diameter; row++)
            {
                // Iterar sobre cada columna
                for (double column = 0; column <= diameter; column++)
                {
                    // Calcular la distancia del punto actual al centro del círculo
                    double distanceToCenter = Math.Sqrt(Math.Pow(column - Radius, 2) + Math.Pow(row - Radius, 2));

                    // Si la distancia al centro es menor o igual al radio, agregar un asterisco al string, de lo contrario agregar un espacio en blanco
                    if (distanceToCenter <= Radius)
                    {
                        circleString += "* ";
                    }
                    else
                    {
                        circleString += "  ";
                    }
                }
                // Agregar un salto de línea después de cada fila
                circleString += "\n";
            }

            // Devolver el string que representa el círculo
            return circleString;
        }


        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"\n La figura es un Circulo" +
                   $"\n El valor del Radio es: {Radius}" +
                   $"\n El valor del Área es: {GetArea()}";
        }
    }
}