using System;
using System.IO;
using System.Text;

namespace Universidad
{
    public class App07
    {
        public static void Main()
        {
            Persona per1 = new Persona("John", "Smith", new Rut(12345678, '9'),new Fecha(10,12,2001));
            Persona per2 = new Persona("Fred", "Roger", new Rut(16775865, '4'),new Fecha(19,05,2005));
            Empleado emp1 = new Empleado(per1, 718,"Sales",750000);

            // Console.WriteLine("Empleado String: "+emp1.ToString());

            List<Empleado> nomina = new List<Empleado>();
            Console.WriteLine("Cantidad Empleados: ["+nomina.Count()+"]");
            nomina.Add(emp1);


            Console.WriteLine("Cantidad Empleados: ["+nomina.Count()+"]");

            List<string> listaPalabras = new List<string>();
            Console.WriteLine("Lista de Palabras: ["+listaPalabras.Count()+"]");
            listaPalabras.Add("Hola");
            listaPalabras.Add("Mundo");
            Console.WriteLine("Lista de Palabras: ["+listaPalabras.Count()+"]");

            List<Object> listaObjectos = new List<object>();
            Console.WriteLine("Lista de Objetos: ["+listaObjectos.Count()+"]");
            listaObjectos.Add("Programacion C#");
            listaObjectos.Add(987652345674345465);
            listaObjectos.Add("anything");
            listaObjectos.Add(true);
            listaObjectos.Add(emp1);
            Console.WriteLine("Lista de Objetos: ["+listaObjectos.Count()+"]");
            

            // Console.WriteLine("EJORNADA: "+EJornada.Completa);
            Empleado emp2;
            emp2 = new Administrativo(0.07m, per1);
            Console.WriteLine("EMP2: "+emp2.ToString());

            Empleado empleadoCoercion;
            empleadoCoercion = new Administrativo(per2, EJornada.Completa, 0.2m);
            empleadoCoercion.setSalary(2500000);
            Console.WriteLine("empleadoCoercion: "+empleadoCoercion.ToString());

            // CREAR COERCION PARA ESTUDIANTE

            Jornada jornada1 = new Jornada("MEDIA");
            Jornada jornada2 = new Jornada();
            List<Jornada> horario = new List<Jornada>();
            List<string> agregar = new List<string>();
            agregar.Add("Media");
            agregar.Add("Completa");
            horario.Add(jornada1);
            horario.Add(jornada2);


            //Administrativo adm1 = new Administrativo(12345678,emp1,per1,jornada1);
             Administrativo adm1 = new Administrativo(12345678,emp1,per1,EJornada.Completa);
            //Administrativo adm2 = new Administrativo(12345678,emp1,per1);
            //Console.WriteLine("Administrativo 1: "+horario[0].getNombreJornada());
            //Administrativo adm1 = new Administrativo(0.15m,emp1,per1,EJornada.Media);
            Console.WriteLine("adm1: "+adm1);



            if (adm1 is Administrativo)
            {
                Console.WriteLine("ADM1 is Administrativo");
            }

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
               if (item is Empleado)
               {
                    // Castear si es empleado
                    Console.WriteLine("$"+((Empleado)item).getNameLastname());
                    Console.WriteLine("$"+((Empleado)item).getSalary());
               }
               else if (item is Persona)
               {
                    Console.WriteLine("$"+((Persona)item).getFechaNacimiento());
               }
               else 
               {
                    Console.WriteLine("#"+item.ToString());
               }
                
            }

           // Console.WriteLine("Logic location con Where: "+ nomina.Where(e => e.getName() == "John"));

            foreach (Empleado item in nomina.Where(e => e.getNameLastname() == "Juan"))
            {
            //    Console.WriteLine(item.ToString());
            }
            // changes 1

            int valor;
            valor = empleadoCoercion.getSalary();
            Console.WriteLine($"{empleadoCoercion.getNameLastname()}: "+valor);


            if (emp2 is Administrativo)
            {
                Administrativo adm2 = (Administrativo)emp2;
                //adm2.CalcularSueldo();
            }

            Console.WriteLine("VIRTUAL");
            Console.WriteLine("VIRTUAL 1: "+per2.quienSoy());
            Console.WriteLine("VIRTUAL 2: "+emp1.quienSoy());
            Console.WriteLine("VIRTUAL 3: "+adm1.quienSoy());

        }
    }
}