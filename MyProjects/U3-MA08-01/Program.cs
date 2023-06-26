using System;

namespace MA_08
{
    class AppFiguras
    {
        static void Main_(string[] args)
        {
            Console.WriteLine("Consola Program");
            ProbandoPuntos();
        }
        public static void ProbandoPuntos()
        {
           
            Punto punto1 = new Punto();
            Console.WriteLine("Punto 1: "+ punto1.ToString());

            Punto punto2 = new Punto(3,8);
            Console.WriteLine("Punto 2: " + punto2.ToString());

            Punto punto3 = new Punto(3, 2);
            Console.WriteLine("Punto 3: " + punto3.ToString());

            Punto punto4 = new Punto(3, 8);
            Console.WriteLine("Punto 4: " + punto4.ToString());

            /*
            REVISAR ESTO PARA ENTENDER ICOMPARABLE BASE
            
            int[] arreglo = {1, 6, 8, 2, 3 };

            Console.WriteLine("Arreglo Original");
            foreach (var item in arreglo)
            {
                Console.Write("["+item+"]");
            }
            Console.WriteLine("");

            // ordenamiento ida
            Array.Sort(arreglo);

            Console.WriteLine("Arreglo Ordenado");
            foreach (var item in arreglo)
            {
                Console.Write("[" + item + "]");
            }
            Console.WriteLine("");
            // ordenamiento reversa
            Array.Reverse(arreglo);

            Console.WriteLine("Arreglo Ordenado Descendiente");
            foreach (var item in arreglo)
            {
                Console.Write("[" + item + "]");
            }

            
            if (punto1.CompareTo(punto2) == 0)
            {
                Console.WriteLine(punto1.ToString() + " y " + punto2.ToString() + " son iguales");
            }
            else if (punto1.CompareTo(punto2) < 0)
            {
                Console.WriteLine(punto1.ToString() + " es Menor que " + punto2.ToString());
            }
            else
            {
                Console.WriteLine(punto1.ToString() + " es Mayor que " + punto2.ToString());
            }

            PAGINA 7 DE 32 
            */

            Punto[] misPuntos = new Punto[5];
            misPuntos[0] = punto2;
            misPuntos[1] = punto3;
            misPuntos[2] = punto4;
            misPuntos[3] = punto1;
            misPuntos[4] = new Punto(2, 1);

            

            Console.WriteLine("Puntos Originales");
            mostrarArreglosPuntos(misPuntos);

            Array.Sort(misPuntos);
            Console.WriteLine("Puntos Ordenados");
            Console.WriteLine("Puntos Ordenados Con Nuestro Criterio");
            mostrarArreglosPuntos(misPuntos);

            OtroObjeto otro1 = new OtroObjeto();
            try
            {
                if (punto1.CompareTo(otro1) == 0)
                {
                    Console.WriteLine("son uguales");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("codigo error, "+ex);

            }

        }

        public static void mostrarArreglosPuntos(Punto[] _puntos)
        {
            foreach (Punto item in _puntos)
            {
                Console.WriteLine("(" + item.ToString() + ")");
            }
        }
    }
}
