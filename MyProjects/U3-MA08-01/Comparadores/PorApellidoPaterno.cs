using System;
using System.Collections;
using MA_08.EjemploPersonas;

namespace MA_08.Comparadores
{
    public class PorApellidoPaterno: IComparer
    {
        public PorApellidoPaterno()
        {
        }

        public int Compare(Object obj1, Object obj2)
        {
            Console.WriteLine("Estamos comparando objetos "+obj1+" y " +obj2);
            if (obj1 == null || obj2 == null)
            {
                return 0;
            }
            if (obj1 is Persona && obj2 is Persona)
            {
                Persona p1 = (Persona)obj1;
                Persona p2 = (Persona)obj2;
                return p1.getApellidoPaterno().CompareTo(p2.getApellidoPaterno());
                //return -99;
            }
            else
            {
                throw new ArgumentException("Uno o más objetocs NO son PERSONA");
            }
            
        }
    }
}
