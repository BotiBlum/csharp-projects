namespace Universidad
{  
    public class App 
    {

        public static void Main(string[] args)
        {
            Rut r1 = new Rut(16775865, '7');

            Console.WriteLine(r1.ToString());

            Persona p1 = new Persona("Pablo","Vergaray", r1);

            Console.Write(p1.ToString());

            Empleado em1 = new Empleado("John","Smith",r1, 712, "Engineering", 5590000);
            Empleado em2 = new Empleado("Michael", "Jackson",(new Rut(17876456, '3')), 1890, "Software", 1100000);
            Console.WriteLine();
            Console.WriteLine(em1.ToString());
            Console.WriteLine(em2.ToString());

            Fecha f1= new Fecha(06,03,2014);
            Console.WriteLine(f1.ToString());

            Persona p2 = new Persona("Sofia", "Vergaray", new Rut(24555820, '1'), f1);      
            Console.WriteLine(p2);
            Empleado em3 = new Empleado(p2, 650,"Pilot",7990000);
            Console.WriteLine(em3);

            Estudiante student1;
            // Console.WriteLine("Alumno nuevo: "+ student1.ToString());
            Rut r2 = new Rut(26124779, '8');
            student1 = new Estudiante("Vicente", "Vergaray",r2, new Fecha(15,02,2018),1001, "Engineering", 2035);
            Console.WriteLine("Alumno nuevo: "+ student1.ToString());
            //student1.RutPersona(16775865, '7');

 
        }
 
    }
    
}

