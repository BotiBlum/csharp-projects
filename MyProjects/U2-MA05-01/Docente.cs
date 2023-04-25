using System;
using System.IO;
using System.Text;


namespace Universidad
{
    public class Docente: Empleado
    {
        private int horasClases;
        private string gradoAcademico;
        public Docente() : base()
        {
            this.horasClases = 0;
            this.gradoAcademico = "Sin Grado";
        }

        public Docente( Empleado _emp, int _horas, string _grado) : base(_emp, _emp.getPersona())
        {
            Console.WriteLine($"#########  {_horas} {_grado} "+_emp.ToString());
            horasClases = _horas;
            gradoAcademico = _grado;

        }

        public Docente(Docente _docente)
        {
            horasClases = _docente.horasClases;
            gradoAcademico = _docente.gradoAcademico;
        }


        public override string ToString()
        {
            //Console.WriteLine($"Builder Docente: {horasClases} {gradoAcademico}  "+base.ToString());
            StringBuilder s = new StringBuilder();
            s.Append(base.ToString());
            s.Append(", ");
            s.Append(horasClases+ " horas, ");
            s.Append("Grado académico: "+gradoAcademico);
            return s.ToString();
        }


    }
}