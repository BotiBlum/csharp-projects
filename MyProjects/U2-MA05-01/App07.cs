using System;
using System.IO;
using System.Text;

namespace Universidad
{
    public class App07
    {
        public static void Main()
        {
            Persona per1 = new Persona("Juan", "Perez", new Rut(12345678, '9'),new Fecha(10,12,2001));
            Empleado emp1 = new Empleado(per1, 718,"Sales",750000);
            List<Empleado> nomina = new List<Empleado>();
            List<string> listaPalabras = new List<string>();
            List<Object> listaObjectos = new List<object>();

            Console.WriteLine("Cant Empl "+nomina.Count());
            nomina.Add(emp1);
             Console.WriteLine("Cant Empl "+nomina.Count());

            listaPalabras.Add("Hola");
            listaPalabras.Add("Mundo");

            listaObjectos.Add("Programacion C#");
            listaObjectos.Add(987652345674345465);
            listaObjectos.Add("anything");
            listaObjectos.Add(true);

            foreach (Object item in nomina)
            {
                
                if (item is Empleado)
                {   
                    Console.WriteLine();
                    Console.WriteLine("> "+((Empleado)item).getID());
                }
            }
            foreach (Empleado item in nomina)
            {
                
                if (item is Empleado)
                {   
                    Console.WriteLine();
                    Console.WriteLine("> "+((Empleado)item).getID());
                }
            }

            foreach (String item in listaPalabras)
            {
                if (item is string)
                {
                    Console.WriteLine(item.ToUpper().ToString());
                }
                
            }
            foreach (Object item in listaObjectos)
            {
                    Console.WriteLine(item.ToString());
                
            }

            Console.WriteLine("Persona con Where: "+ nomina.Where(e => e.getName() == "John"));

            foreach (Empleado item in nomina.Where(e => e.getName() == "Juan"))
            {
                Console.WriteLine(item.ToString());
            }
            // changes

        }
    }
}