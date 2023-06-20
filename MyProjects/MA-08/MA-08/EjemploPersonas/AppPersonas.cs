using System;
using System.Collections.Generic;

namespace MA_08.EjemploPersonas
{
    public class AppPersonas
    {
        public static void Main()
        {
            Console.WriteLine("Personas");
            Persona[] listaPersonas = new Persona[4];


            listaPersonas[0] = new Persona("1-1", "Javi", "Perez", "Gonzalez");
            listaPersonas[1] = new Persona("2-2", "Alejandra", "Tapia", "Neighbour");
            listaPersonas[2] = new Persona("3-3", "Sebastian", "Arredondo", "Maluenda");
            listaPersonas[3] = new Persona("4-4", "Christian", "Carmona", "Mendoza");

            Console.WriteLine("Original");
            foreach (Persona p in listaPersonas)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("Ordenada");
            //listaPersonas[0].ordenarPorApellidos(listaPersonas);
            // Llamada al objeto persona, no es necesario pasar parametros
            new Persona().ordenarPorApellidos(listaPersonas);

            foreach (Persona p in listaPersonas)
            {
                Console.WriteLine(p.ToString());
            }

        }
    }
}
