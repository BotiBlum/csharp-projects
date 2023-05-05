using System;
using System.Text;
using System.IO;

namespace Universidad
{
    public class Persona
    {
        private string name;
        private string lastname;
        protected Rut rut;
        private Fecha fechaNac;
        private char gender;
        private char maritalStatus;

        public Persona()
        {
            this.rut = new Rut();
            this.name = "Sin Asignar";
            this.lastname = "Sin Asignar";
            this.gender = 'X'; // F, M
            this.maritalStatus = 'X'; // S,C D,V
            this.fechaNac = new Fecha(0,0,0);
            

        }

        public Persona(string _name, string _lastname, Rut _rut)
        {
            name = _name;
            lastname = _lastname;
            rut = _rut;
            this.fechaNac = new Fecha(0,0,0);
        }
        public Persona(string _name, string _lastname, char _gender, char _marital, Rut _rut)
        {
            name = _name;
            lastname = _lastname;
            rut = _rut;
            gender = _gender;
            maritalStatus = _marital;
            fechaNac = new Fecha(0,0,0);
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

        public void RutPersona(Rut _rut)
        {
            rut = _rut;
        }
        public Rut getRutPersona(){   // Getter de tipo Clase 

            return rut;
        }

        public Persona getPersona()
        {
            return this;
        }
        public string getName()
        {
            return name;
        }
        

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append("Persona ");
            s.Append("\nName: "+name);
            s.Append(" ");
            s.Append(" Lastname: "+lastname);
            s.Append(", ");
            s.Append(" RUT: "+rut);
            s.Append(", ");
            s.Append(" Birth Date: "+fechaNac);
          //  Console.WriteLine("Persona String: "+s.ToString());
            return s.ToString();
        }

    }
}