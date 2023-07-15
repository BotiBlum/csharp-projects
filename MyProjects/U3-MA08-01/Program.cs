using System;

namespace MA_08
{
    class AppFiguras
    {
        static void Main_(string[] args)
        {
            Console.WriteLine("Consola Program\n");
            

            ProbandoPuntos();
           
        }
        static void ProbandoPuntos()
        {
           
            Punto punto1 = new Punto();
            Console.WriteLine("Punto 1: "+ punto1.ToString());

            Punto punto2 = new Punto(3,8);
            Console.WriteLine("Punto 2: " + punto2.ToString());

            Punto punto3 = new Punto(3, 2);
            Console.WriteLine("Punto 3: " + punto3.ToString());

            Punto punto4 = new Punto(3, 8);
            Console.WriteLine("Punto 4: " + punto4.ToString());

            
           // REVISAR ESTO PARA ENTENDER ICOMPARABLE BASE
            
            int[] arreglo = {1, 6, 8, 2, 3 };

            Console.WriteLine("Arreglo Original");
            foreach (var item in arreglo)
            {
                Console.Write("["+item+"]");
            }
            Console.WriteLine("");

            // ordenamiento ida de menor a mayor
            Array.Sort(arreglo); // ordena un arreglo local int

            Console.WriteLine("Arreglo Ordenado < "); // Lo ordena de menor a mayor.
            foreach (var item in arreglo)
            {
                Console.Write("[" + item + "]");
            }
            Console.WriteLine("");
            
            // ordenamiento reversa de mayor a menor
            Array.Reverse(arreglo); // Lo ordena de mayor a menor
            Console.WriteLine("Arreglo Ordenado >");
            foreach (var item in arreglo)
            {
                Console.Write("[" + item + "]");
            }
            Console.WriteLine("\n#########################");
            

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
            
            static void compararPuntos(Punto _x, Punto _y)
            {
                if (_x is Punto && _y is Punto)
                {
                    if (_x.CompareTo(_y) == 0)
                    {   // Igual a 0
                        Console.WriteLine(_x.ToString() + " y " + _y.ToString() + " son iguales");                     
                    }
                    else if (_x.CompareTo(_y) < 0)
                    {   // Menor que 0
                        Console.WriteLine(_x.ToString() + " es Menor que " + _y.ToString());                      
                    }
                    else
                    {   // Mayor que 0
                        Console.WriteLine(_x.ToString() + " es Mayor que " + _y.ToString());                      
                    }
                }
            }
            compararPuntos(punto1, punto2);
            //PAGINA 7 DE 32 
            



            Console.WriteLine("\n INSTANCIACION DE ARREGLO DE PUNTOS Y UTILIZACION DE ARRAY.SORT");
            // Instanciacion de Arreglo de Puntos    
            Punto[] misPuntos = new Punto[5];
            misPuntos[0] = punto2;
            misPuntos[1] = punto3;
            misPuntos[2] = punto4;
            misPuntos[3] = punto1;
            misPuntos[4] = new Punto(2, 1);

            

            Console.WriteLine("\nPuntos Originales");
            mostrarArreglosPuntos(misPuntos);
            Console.WriteLine("#########################");
            
            //########################################
            
            Console.WriteLine("\nDespues de Array Sort");
            Console.WriteLine("Puntos Ordenados De Menor a Mayor");
            Array.Sort(misPuntos);  // Solo los ordena // ordena un arreglo de clase Punto
            mostrarArreglosPuntos(misPuntos); //Solo los muestra
            Console.WriteLine("#########################");

            Console.WriteLine("Puntos Ordenados De Mayor a Menor");
            Array.Reverse(misPuntos); // Solo los ordena
            mostrarArreglosPuntos(misPuntos);  //Solo los muestra
            Console.WriteLine("#########################");
            //###########################
            // Comparacion de dos clases distintas, da error

            Console.WriteLine("\nComparacion de dos clases distintas, da el siguiente error: \n");
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
            Console.WriteLine("############# FIN DEL ERROR ############");
            mostrarArreglosPuntos(misPuntos);

        }

        public static void mostrarArreglosPuntos(Punto[] _puntos)
        {
            Console.WriteLine("funcion mostrarArreglosPuntos");
            foreach (Punto item in _puntos)
            {
                Console.WriteLine("(" + item.ToString() + ")");
            }
        }
        
    }
}
