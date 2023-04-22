using System;
using System.Text;
using System.IO;

namespace Empresa
{
    public class Persona
    {
        private string name;
        private string lastname;
        private Rut rut;

        public Persona()
        {
            this.name = "Sin Asignar";
            this.lastname = "Sin Asignar";
            this.rut = new Rut();
        }

        public Persona(string _name, string _lastname, Rut _rut)
        {
            name = _name;
            lastname = _lastname;
            rut = _rut;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append(name);
            s.Append(" ");
            s.Append(lastname);
            s.Append(", ");
            s.Append(rut);
            return s.ToString();
        }

    }
}