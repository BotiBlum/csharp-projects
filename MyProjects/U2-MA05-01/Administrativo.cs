using System;
using System.IO;
using System.Text;

namespace Universidad
{
    public class Administrativo: Empleado
    {
       // private List<string> jornada;
        private decimal bono;
        private List<Jornada> jornada;

        public Administrativo() : base()
        {
            this.bono = 0m;
            this.jornada = new List<Jornada>();
        }
/*
        public Administrativo(decimal _bono, Empleado _emp) : base (_emp)
        {
            bono = _bono;
        }*/

        public Administrativo(decimal _bono, Empleado _emp, Persona _pers) : base (_emp, _pers)
        {
            bono = _bono;
        }
        public Administrativo(decimal _bono, Empleado _emp) : base (_emp, _emp.getPersona())
        {
            bono = _bono;
        }

        
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append(base.ToString()+", ");
            s.Append(bono);

            return s.ToString();
        }
    }   
}