using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts.Geometry
{
    public class Rectangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public override string Draw()
        {
            // Convertir los lados a enteros para asegurar un rectángulo perfecto
            int integerBase = (int)Math.Round(Base);
            int integerHeight = (int)Math.Round(Height);

            // Crear un string para almacenar el rectángulo
            string rectangleString = "";

            // Iterar sobre cada fila
            for (int i = 0; i < integerHeight; i++)
            {
                // Iterar sobre cada columna
                for (int j = 0; j < integerBase; j++)
                {
                    // Si estamos en el borde superior o inferior del rectángulo, o en el borde izquierdo o derecho, agregar un asterisco,
                    // de lo contrario agregar un espacio en blanco
                    if (i == 0 || i == integerHeight - 1 || j == 0 || j == integerBase - 1)
                    {
                        rectangleString += "* ";
                    }
                    else
                    {
                        rectangleString += "  ";
                    }
                }
                // Agregar un salto de línea después de cada fila
                rectangleString += "\n";
            }

            // Devolver el string que representa el rectángulo
            return rectangleString;
        }

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