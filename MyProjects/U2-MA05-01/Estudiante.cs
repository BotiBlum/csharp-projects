using System;
using System.IO;
using System.Text;

namespace Universidad
{
    public class Estudiante: Persona
    {
        private int numMatricular;
        private string carrera;
        private int anoEgreso;

        

        public Estudiante() : base()
        {
            this.numMatricular = 2000;
            this.carrera = "CARRERA N/A";
            this.anoEgreso = 0000;
        }
        public Estudiante(string _name, string _lastname,Rut  _rut, Fecha _fechaNac, int _numAdm, string _degree, int _egress ) : base (_name, _lastname, _rut, _fechaNac)
        {
            numMatricular = _numAdm;
            carrera = _degree;
            anoEgreso = _egress;
        }
        
        public Estudiante(Persona _persona,int _numAdm, string _degree, int _egress) : base (_persona)
        {
            numMatricular = _numAdm;
            carrera = _degree;
            anoEgreso = _egress;
        }

        public Estudiante(Estudiante _student)
        {
            numMatricular = _student.numMatricular;
            carrera = _student.carrera;
            anoEgreso = _student.anoEgreso;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append(base.ToString()+" // ");
            s.Append(numMatricular);
            s.Append(", ");
            s.Append(carrera);
            s.Append(", ");
            s.Append(anoEgreso);
            return s.ToString();

        }

        
    }


    
}