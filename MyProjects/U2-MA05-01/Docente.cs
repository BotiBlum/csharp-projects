using System;
using System.IO;
using System.Text;


namespace Universidad
{
    public class Docente: Empleado
    {
        private int horasClases;
        private string gradoAcademico;
        private Grado grado;
        private decimal decSalary;
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
        public Docente( Empleado _emp, int _horas, Grado _grado) : base(_emp, _emp.getPersona())
        {
           // Console.WriteLine($"#########  {_horas} {_grado} "+_emp.ToString());
            horasClases = _horas;
            grado = _grado;


        }

        public Docente(Docente _docente)
        {
            horasClases = _docente.horasClases;
            gradoAcademico = _docente.gradoAcademico;
        }

        public void CalcularSueldo()
        {
            decimal _TotalHaberes;
            decimal _SueldoLiquido;
            decimal _TotalDescuentos;
            decimal _BonoPagar;
            decimal _SeguroCesantia = .006m; // 6% seguro de cesantia
            decimal _AFP = .1114m; // Afp Provida
            decimal _Salud = .07m;
            decimal bono = 0m;

            // 0.15 % bono
            // Licenciado 8%
            // Magister 25%
            // Doctor 45%
            // Post Doctorado 75%

            if (Grado.Licenciado.Equals(grado))
            {
                bono = 0.08m;
                gradoAcademico = Grado.Licenciado.ToString();
            }
            if (Grado.Magister.Equals(grado))
            {
                bono = 0.25m;
                gradoAcademico = Grado.Magister.ToString();
            }
            if (Grado.Doctor.Equals(grado))
            {
                bono = 0.45m;
                gradoAcademico = Grado.Doctor.ToString();
            }
            if (Grado.PostDoctorado.Equals(grado))
            {
                bono = 0.75m;
                gradoAcademico = Grado.PostDoctorado.ToString();
            }

            // Convert Salary from Int to Decimal
            decSalary = Convert.ToDecimal(base.getSalary());

            // Calculate Bonus by multiply Salary and Bonus rate.
            _BonoPagar = Math.Ceiling(decSalary*bono);
           // Console.WriteLine(base.getPersona());
           // Calculate TotalHaberes by sum Salary and Bonus
            _TotalHaberes = decSalary+_BonoPagar;

            // Calculate Health insurance payment
            _Salud = Math.Floor(_TotalHaberes*_Salud);

            // Calculate layoff contribution
            _SeguroCesantia = Math.Floor(_TotalHaberes * _SeguroCesantia);
            // Calculate retirement
            _AFP = Math.Floor(_TotalHaberes*_AFP);

            // Last calcules 
            _TotalDescuentos = _Salud+_AFP+_SeguroCesantia;
            _SueldoLiquido = _TotalHaberes - _TotalDescuentos;
            
           // Console.WriteLine("Bono a pago: $"+(decSalary*bono).ToString());
           // Console.WriteLine("Total Desc: "+_TotalDescuentos+", Haberes: "+_TotalHaberes+", Total: "+(_TotalHaberes-_TotalDescuentos));
           // Console.WriteLine("\nTotal Descuentos: $"+((_Salud)+(_AFP)+_SeguroCesantia));
            //_SueldoLiquido = _TotalHaberes - (_Salud+_AFP+_SeguroCesantia);
           // Console.WriteLine("Sueldo A Pagar: $"+_SueldoLiquido.ToString());
           // Console.WriteLine($"Docente: {base.getName()}, {gradoAcademico}, ${_SueldoLiquido.ToString()}");

            StringBuilder s = new StringBuilder();
            s.Append(base.ToString());
            s.Append(", ");
            s.Append("Net Income: $"+_SueldoLiquido);
            s.Append(", "+horasClases+ " horas, ");
            s.Append("Grado académico: "+gradoAcademico);
            Console.WriteLine($"{base.GetType()}: "+s.ToString());


        }

        public void CalcularSueldo(Grado _grado, int _horas, decimal _salud, decimal _afp)
        {
            decimal _TotalHaberes, _SueldoLiquido, _TotalDescuentos, _BonoPagar, _SeguroCesantia = .006m; /* 6% seguro de cesantia */
            decimal _AFP, _Salud, bono = 0m;
            int horas = _horas;

            // 0.15 % bono
            // Licenciado 8%
            // Magister 25%
            // Doctor 45%
            // Post Doctorado 75%

            if (Grado.Licenciado.Equals(_grado))
            {
                bono = 0.08m;
            }
            else if (Grado.Magister.Equals(_grado))
            {
                bono = 0.25m;
            }
            else if (Grado.Doctor.Equals(_grado))
            {
                bono = 0.45m;
            }
            else if (Grado.PostDoctorado.Equals(_grado))
            {
                bono = 0.75m;
            }

            // Convert Salary from Int to Decimal
            decSalary = Convert.ToDecimal(base.getSalary());

            // Calculate Bonus by multiply Salary and Bonus rate.
            Console.WriteLine("Bonus Rate: "+bono);
            _BonoPagar = Math.Ceiling(decSalary*bono);
           // Console.WriteLine(base.getPersona());
           // Calculate TotalHaberes by sum Salary and Bonus
            _TotalHaberes = decSalary+_BonoPagar;

            // Calculate Health insurance payment
            _Salud = Math.Floor(_TotalHaberes*_salud);

            // Calculate layoff contribution
            _SeguroCesantia = Math.Floor(_TotalHaberes * _SeguroCesantia);
            // Calculate retirement
            _AFP = Math.Floor(_TotalHaberes*_afp);

            // Last calcules 
            _TotalDescuentos = _Salud+_AFP+_SeguroCesantia;
            _SueldoLiquido = _TotalHaberes - _TotalDescuentos;
            
            /*
            Console.WriteLine("Total Haberes: $"+_TotalHaberes);
            Console.WriteLine("DESCUENTOS:");
            Console.WriteLine("Salud: $"+(_TotalHaberes*_salud));
            Console.WriteLine("AFP: $"+(_TotalHaberes*_afp));
            Console.WriteLine("Seguro Cesantía: $"+(_TotalHaberes*_SeguroCesantia));
            */
            Console.WriteLine("Bono a pago: $"+(decSalary*bono).ToString());
            Console.WriteLine("Total Desc: "+_TotalDescuentos+", Haberes: "+_TotalHaberes+", Total: "+(_TotalHaberes-_TotalDescuentos));
            Console.WriteLine("\nTotal Descuentos: $"+((_Salud)+(_AFP)+_SeguroCesantia));
            //_SueldoLiquido = _TotalHaberes - (_Salud+_AFP+_SeguroCesantia);
            Console.WriteLine("Sueldo A Pagar: $"+_SueldoLiquido.ToString());
            Console.WriteLine($"Docente: {base.getNameLastname()}, {gradoAcademico}, ${_SueldoLiquido.ToString()}");

            StringBuilder s = new StringBuilder();
            s.Append(base.ToString());
            s.Append(", ");
            s.Append("Net Income: $"+_SueldoLiquido);
            s.Append(", "+horasClases+ " horas, ");
            s.Append("Grado académico: "+_grado);
            Console.WriteLine($"{base.GetType()}: "+s.ToString());


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
    public enum Grado
        {
        Licenciado,
        Magister,
        Doctor,
        PostDoctorado
        }
}