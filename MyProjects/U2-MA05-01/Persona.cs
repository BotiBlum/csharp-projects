using System;
using System.Text;
using System.IO;

namespace Universidad
{
    public class Persona
    {
        private string name;
        private string lastname;
        private Rut rut;
        private Fecha fechaNac;

        public Persona()
        {
            this.name = "Sin Asignar";
            this.lastname = "Sin Asignar";
            this.rut = new Rut();
            this.fechaNac = new Fecha();

        }

        public Persona(string _name, string _lastname, Rut _rut)
        {
            name = _name;
            lastname = _lastname;
            rut = _rut;
        }


        public Persona(string _name, string _lastname, Rut _rut, Fecha _fechaNac)
        {
            name = _name;
            lastname = _lastname;
            rut = _rut;
            fechaNac = _fechaNac;
        }

        public Persona(Persona _p)
        {
            name = _p.name;
            lastname = _p.lastname;
            rut = _p.rut;
            fechaNac = _p.fechaNac;
        }
        

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append(name);
            s.Append(" ");
            s.Append(lastname);
            s.Append(", ");
            s.Append(rut);
            s.Append(", ");
            s.Append(fechaNac);
            return s.ToString();
        }

    }
}