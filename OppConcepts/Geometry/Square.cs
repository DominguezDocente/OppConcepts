﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts.Geometry
{
    public class Square
    {
        public string Draw()
        {
            int size, x, y;
            size = 5;

            string result = " " + Environment.NewLine;

            for (x = 1; x <= size; x++)
            {
                for (y = 1; y <= size; y++)
                {
                    result += "*  ";
                }
                result += " " + Environment.NewLine;
            }

            return result;
        }
    }
}