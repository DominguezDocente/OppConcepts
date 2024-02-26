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
        public override string Draw()
        {
            // Convertir el lado a un entero para asegurar un cuadrado perfecto
            int ingeterSide = (int)Math.Round(Side);

            // Crear un string para almacenar el cuadrado
            string squareString = "";

            // Iterar sobre cada fila
            for (int i = 0; i < ingeterSide; i++)
            {
                // Iterar sobre cada columna
                for (int j = 0; j < ingeterSide; j++)
                {
                    // Si estamos en el borde del cuadrado, agregar un asterisco, de lo contrario agregar un espacio en blanco
                    if (i == 0 || i == ingeterSide - 1 || j == 0 || j == ingeterSide - 1)
                    {
                        squareString += "* ";
                    }
                    else
                    {
                        squareString += "  ";
                    }
                }
                // Agregar un salto de línea después de cada fila
                squareString += "\n";
            }

            // Devolver el string que representa el cuadrado
            return squareString;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"\n La figura es un Cuadrado" +
                   $"\n El valor de los lados es: {Side}" +
                   $"\n El valor del Área es: {GetArea()}";
        }
    }
}