﻿using System;
using System.Collections;
using MA_08.EjemploPersonas;

namespace MA_08.Comparadores
{
    public class PorNombre: IComparer
    {
        public PorNombre()

        {
        }

        public int Compare(object _x, object _y)
        {
            Console.WriteLine("Estamos comparando objetos "+_x+" y " +_y);
            if (_x == null || _y == null)
            {
                return 0;
            }
            if (_x is Persona && _y is Persona)
            {
                Persona p1 = (Persona)_x;
                Persona p2 = (Persona)_y;
                return p1.getNombre().CompareTo(p2.getNombre());
                //return -99;
            }
            else
            {
                throw new ArgumentException("Uno o más objetocs NO son PERSONA");
            }
            
        }
    }
}
