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
        }
 
    }
    
}

