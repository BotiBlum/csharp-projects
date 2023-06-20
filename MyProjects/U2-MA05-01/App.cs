namespace Universidad
{  
    public class App 
    {

        public static void Main_(string[] args)
        {
            Rut r1 = new Rut(16745815, '3');
            Rut r2 = new Rut(22164779, '8');
            Rut r3 = new Rut(21234678, '8');


            

            Fecha f1= new Fecha(19,08,2012);
            Fecha f2= new Fecha(18,09,2013);
            Fecha f3= new Fecha(11,10,2014);
            Fecha f4= new Fecha(05,11,2015);
            Fecha f5= new Fecha(06,03,2014);
            Fecha f6= new Fecha(15,02,2018);
            
            
            Persona p1 = new Persona("Paul","Morgan", r1,f3);
            Persona p2 = new Persona("Sophie", "Louis", new Rut(24555820, '1'), f1);
            Persona p3 = new Persona("Fred", "Jackson", new Rut(14543810, '1'), f2);

            Estudiante student1 = new Estudiante("Matt", "Williams",r2, new Fecha(11,04,2016),1001, "Engineering", 2035);  

            Empleado em1 = new Empleado("John","Smith",r1,f6, 712, "Engineering", 1000000);
            Empleado em2 = new Empleado("Michael", "Jackson",(new Rut(17876456, '3')),f4, 1890, "Software", 1100000);
            Empleado em3 = new Empleado(p2, 650,"Pilot",7990000);
            Empleado em4 = new Empleado(p3, 1254,"Navy Seal",3990000);
            Empleado em5 = new Empleado("Guido", "Rios",(new Rut(11009234, 'K')),f6, 2467, "Teacher", 1000000);


            Administrativo adm1 = new Administrativo(20m,em3, p2); // Administrativo.cs line 24
            Administrativo adm2 = new Administrativo(18m,em4);  // Administrativo.cs line 30
           // Administrativo adm3 = new Administrativo(18m,em4);  // Administrativo.cs line 30

            
            
            Jornada Completa = new Jornada();
            //Console.WriteLine(Grado.Doctor);
            
            
            // Guido Rios
            Docente docente1 = new Docente(em5,120,"Master CS");
            docente1.CalcularSueldo(Grado.Magister, 120,.07m, .1114m);
            /*  DEJAR STANDBY - NO BORRAR
            // John Smith
            Docente docente2 = new Docente(em1,65,Grado.Magister);
            docente2.CalcularSueldo();

            // Paul Morgan
            Docente docente6 = new Docente(new Empleado(p1,999,"Network Architect and Inventor",2000000),80,Grado.PostDoctorado);
            docente6.CalcularSueldo();
            // Sophie Louis
            Docente docente5 = new Docente(em3,45,Grado.Doctor);
            docente5.CalcularSueldo();
            // Fred Jackson
            Docente docente3 = new Docente(em4,45,Grado.Licenciado);
            docente3.CalcularSueldo();
            // Michael Jackson
            Docente docente4 = new Docente(em2,45,Grado.Doctor);
            docente4.CalcularSueldo();

            Docente docente7 = new Docente();
            docente7.CalcularSueldo();

            // COERCION
            Empleado em6;
            em6 = new Administrativo(0.07m,p2);
            //Console.WriteLine(em6.ToString());
            */

            /*
            Console.WriteLine("Rut1: "+r1.ToString());
            Console.WriteLine("Rut2: "+r2.ToString());
            Console.WriteLine("Rut3: "+r3.ToString());
            Console.WriteLine("Fecha1:  "+f1.ToString());
            Console.WriteLine("Persona1: "+p1.ToString());
            Console.WriteLine("Persona2: "+p2);
            Console.WriteLine("Empleado1: "+em1.ToString());
            Console.WriteLine("Empleado2: "+em2.ToString());         
            Console.WriteLine("Empleado3: "+em3);
            Console.WriteLine("Alumno nuevo: "+ student1.ToString());    
            
            //student1.RutPersona(16775865, '7');
            
            student1.RutPersona(r3);
            Console.WriteLine("r3: "+r3.ToString());
            Console.WriteLine(student1.getRutPersona());

            Console.WriteLine("before em3:  "+em3.ToString());
            Console.WriteLine(adm1.getRutPersona().ToString());
            //Console.WriteLine("after em3:  "+em3.getPersona(em3).ToString());
            Console.WriteLine("adm2 string: "+adm2.ToString());
            */
            //Console.WriteLine("Docente: "+docente1.ToString());

            // List<Empleado> nomina = new List<Empleado>;
            // nomina.Add(emp1);


            if (docente1 is Docente)
            {
                //Console.WriteLine("Es Docente");
                Docente ad2 = (Docente) docente1;
                //Console.WriteLine("ad2: "+ad2.ToString());
            }
            else {
                Console.WriteLine("No es docente");
            }



        }
 
    }
    
}

