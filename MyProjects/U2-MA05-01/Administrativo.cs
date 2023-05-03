using System;
using System.IO;
using System.Text;

namespace Universidad
{
    public class Administrativo: Empleado
    {
       // private List<Jornada> jornadas {get; set;}
        private decimal bono;
        private Jornada jornada;


        public Administrativo() : base()
        {
            this.bono = 0m;
           // this.jornadas = new List<Jornada>();
           this.jornada = new Jornada();
        }
        public Administrativo(decimal _bono, Empleado _emp, Persona _pers) : base (_emp, _pers)
        {
            bono = _bono;
            
        }
        public Administrativo(decimal _bono, Empleado _emp) : base (_emp, _emp.getPersona())
        {
            Console.WriteLine("Constructor por parametros: "+_emp.getPersona());
            bono = _bono;
        }

        public Administrativo(decimal _bono, Empleado _emp, Persona _pers,Jornada _jornada) : base (_emp, _emp.getPersona())
        {
            Console.WriteLine("Constructor por parametros: "+_emp.getPersona());
            bono = _bono;
            jornada = _jornada;
        } 
        public void AddJornada(Jornada _jornada) // Have to create first the Jornada string as class.
        {
            Console.WriteLine("Debug Jornada "+_jornada.ToString());
            //jornada.Add(_jornada);
        }
        /*
        public void GetJornada()
        {
            foreach (Jornada item in jornada)
            {
                
                Console.WriteLine("BUSQUEDA: "+item.ToString());   

            }
        }
*/
        public override string ToString()
        {
            Console.WriteLine("Jornadas value on Administrativo: "+jornada);
            StringBuilder s = new StringBuilder();
            s.Append(base.ToString());
            s.Append(", ");
            s.Append("Bonus: "+bono);
            s.Append(", ");
            s.Append("Jornada: "+jornada);

            return s.ToString();
        }
    }   
}