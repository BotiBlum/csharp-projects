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
        private EJornada ejornada;


        public Administrativo() : base()
        {
            this.bono = 0m;
           // this.jornadas = new List<Jornada>();
           this.jornada = new Jornada();
           this.ejornada = new EJornada();
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

        public Administrativo(decimal _bono, Empleado _emp, Persona _pers,EJornada _jornada) : base (_emp, _emp.getPersona())
        {
            Console.WriteLine("Constructor por parametros: "+_emp.getPersona());
            bono = _bono;
            ejornada = _jornada;
            if ((EJornada.Completa.Equals(_jornada)))
            {
                Console.WriteLine("MATCH");
            }
            else 
            {
                Console.WriteLine("NOT MATCH");
            }
        } 
        public void AddJornada(Jornada _jornada) // Have to create first the Jornada string as class.
        {
            Console.WriteLine("Debug Jornada "+_jornada.ToString());
            //jornada.Add(_jornada);
        }

        public override string ToString()
        {
            Console.WriteLine("Jornadas value on Administrativo: "+jornada);
            StringBuilder s = new StringBuilder();
            s.Append(base.ToString());
            s.Append(", ");
            s.Append("Bonus: "+bono);
            s.Append(", ");
            s.Append("Jornada: "+ejornada);

            return s.ToString();
        }



    }   
}