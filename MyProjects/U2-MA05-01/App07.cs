using System;
using System.IO;
using System.Text;

namespace Universidad
{
    public class App07
    {
        public static void Main_()
        {
            Persona per1 = new Persona("Juan", "Perez", new Rut(12345678, '9'),new Fecha(10,12,2001));
            Empleado emp1 = new Empleado(per1, 718,"Sales",750000);

            Console.WriteLine("Empleado String: "+emp1.ToString());

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
            
            Console.WriteLine("EJORNADA: "+EJornada.Completa);


            Jornada jornada1 = new Jornada("MEDIA");
            Jornada jornada2 = new Jornada();
            List<Jornada> horario = new List<Jornada>();
            List<string> agregar = new List<string>();
            agregar.Add("Media");
            agregar.Add("Completa");
            horario.Add(jornada1);
            horario.Add(jornada2);


            //Administrativo adm1 = new Administrativo(12345678,emp1,per1,jornada1);
          //  Administrativo adm1 = new Administrativo(12345678,emp1,per1,EJornada.Media);
            //Administrativo adm2 = new Administrativo(12345678,emp1,per1);
            //Console.WriteLine("Administrativo 1: "+horario[0].getNombreJornada());
            Administrativo adm1 = new Administrativo(0.15m,emp1,per1,EJornada.Media);
            Console.WriteLine("adm1: "+adm1);


            adm1.CalcularSueldo(.07m, .1145m); // 7% Salud, 11,45% AFP Provida

            foreach (Jornada lista in horario)
            {
               // Console.WriteLine("HORARIO JORNADA: "+lista.getNombreJornada());
            }

            /*

            Jornada.Media
            Media es un Getter que deberia devolver un string con la jornada
            se puede insertar un foreach dentro del getter para hacer un if y where.

            */
            
            foreach (Object item in nomina)
            {
                
                if (item is Empleado)
                {   
                 //   Console.WriteLine("> "+((Empleado)item).getID());
                }
            }
            foreach (Empleado item in nomina)
            {
                
                if (item is Empleado)
                {   
                 //   Console.WriteLine("> "+((Empleado)item).getID()+" "+((Empleado)item).getName());
                }
            }

            foreach (String item in listaPalabras)
            {
                if (item is string)
                {
                 //   Console.WriteLine(item.ToUpper().ToString());
                }
                if (item.Equals("Mundo"))
                {
                 //   Console.WriteLine("Match Mundo");
                }
                
            }
            foreach (Object item in listaObjectos)
            {
               //     Console.WriteLine(item.ToString());
                
            }

           // Console.WriteLine("Logic location con Where: "+ nomina.Where(e => e.getName() == "John"));

            foreach (Empleado item in nomina.Where(e => e.getName() == "Juan"))
            {
            //    Console.WriteLine(item.ToString());
            }
            // changes 1

        }
    }
}