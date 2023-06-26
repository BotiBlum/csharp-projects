using System;
using System.Collections.Generic;

namespace MA_08.EjemploPersonas
{
    public class AppPersonas
    {
        public static void Main()
        {
            Console.WriteLine("Consola AppPersonas");

            // BEGIN   -- ARREGLO DE PERSONAS
            Persona[] listaPersonas = new Persona[4];
            Persona[] listaPersonasPorApellidoPaterno = new Persona[4];


            listaPersonas[0] = new Persona("1-1", "Javi", "Perez", "Gonzalez");
            listaPersonas[1] = new Persona("2-2", "Alejandra", "Tapia", "Neighbour");
            listaPersonas[2] = new Persona("3-3", "Sebastian", "Arredondo", "Zamora");
            listaPersonas[3] = new Persona("4-4", "Christian", "Carmona", "Mendoza");

            //listaPersonasPorApellidoPaterno = listaPersonas;
            int i=0;
            foreach (Persona p in listaPersonas)
            {
                listaPersonasPorApellidoPaterno[i] = p;
                i++;
            }
            // END   -- ARREGLO DE PERSONAS
            
            Console.WriteLine("Original");
            foreach (Persona p in listaPersonas)
            {
                Console.WriteLine(p.ToString());
            }

            // ORDNEADA POR APELLIDO PATERNO   
            Console.WriteLine("Ordenada Por Apellido Paterno");

            //listaPersonas[0].ordenarPorApellidos(listaPersonas);
            // Llamada al objeto persona, no es necesario pasar parametros
            //new Persona().ordenarPorApellidoPaterno(listaPersonas);
            new Persona().ordenarPorApellidoPaterno(listaPersonasPorApellidoPaterno);
            foreach (Persona p in listaPersonasPorApellidoPaterno)
            {
                Console.WriteLine(p.ToString());
            }

            
            // ORDNEADA POR APELLIDO MATERNO  
            Console.WriteLine("Ordenada Por Apellido Materno");

            //listaPersonas[0].ordenarPorApellidos(listaPersonas);
            // Llamada al objeto persona, no es necesario pasar parametros
            new Persona().ordenarPorApellidoMaterno(listaPersonas);

            foreach (Persona p in listaPersonas)
            {
                Console.WriteLine(p.ToString());
            }

            // ORDNEADA POR NOMBRE 
            Console.WriteLine("Ordenada Por Nombre");

            //listaPersonas[0].ordenarPorApellidos(listaPersonas);
            // Llamada al objeto persona, no es necesario pasar parametros
            new Persona().ordenarPorNombre(listaPersonas);

            foreach (Persona p in listaPersonas)
            {
                Console.WriteLine(p.ToString());
            }
            // ORDNEADA POR RUT
            Console.WriteLine("Ordenada Por RUT");

            //listaPersonas[0].ordenarPorApellidos(listaPersonas);
            // Llamada al objeto persona, no es necesario pasar parametros
            new Persona().ordenarPorRut(listaPersonas);

            foreach (Persona p in listaPersonas)
            {
                Console.WriteLine(p.ToString());
            }                

        }
    }
}
