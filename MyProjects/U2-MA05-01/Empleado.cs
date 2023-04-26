using System;
using System.IO;
using System.Text;


namespace Universidad
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
        
        public Empleado(string _name, string _lastname, Rut _rut, Fecha _fechaNac, int _id,string _field, int _salary): base (_name, _lastname, _rut, _fechaNac)
        {
            field = _field;
            id = _id;
            salary = _salary;
        }
        
        public Empleado(Persona _persona,int _id,string _field, int _salary): base (_persona)
        {
            field = _field;
            id = _id;
            salary = _salary;
        }

        public Empleado(Empleado _emp){

            field = _emp.field;
            id = _emp.id;
            salary = _emp.salary;
        }

        // Draft
        public Empleado(Empleado _emp, Persona _pers) : base (_pers)
        {

            field = _emp.field;
            id = _emp.id;
            salary = _emp.salary;
        }
        ///

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append(base.ToString()+", Empleado: ");
            s.Append("ID:"+id);
            s.Append(", ");
            s.Append("Field: "+field);
            s.Append(", ");
            s.Append("Salary: "+salary);

            return s.ToString();
        }

        public int getID(){
            return id;
        }

        /*
        public Empleado getPersona(Empleado _emp){

            return this;
        }*/

    }
}