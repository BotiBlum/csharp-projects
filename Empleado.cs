using System;
using System.IO;
using System.Text;


namespace Empresa
{
    public class Empleado : Persona
    {
        private int id;
        private string field;
        private int salary;

        public Empleado() : base()
        {
            this.field = "Sin Asignar";
            this.id = 0000;
            this.salary = 999999;
        }

        public Empleado(string _name, string _lastname, Rut _rut,int _id,string _field, int _salary): base (_name, _lastname, _rut)
        {
            field = _field;
            id = _id;
            salary = _salary;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append(base.ToString()+" ");
            s.Append(field);
            s.Append(", ");
            s.Append(id);
            s.Append(", ");
            s.Append(salary);

            return s.ToString();
        }

    }
}