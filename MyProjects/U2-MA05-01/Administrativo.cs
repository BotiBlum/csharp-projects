using System;
using System.IO;
using System.Text;

namespace Universidad
{
    public class Administrativo: Empleado
    {
       // private List<Jornada> jornadas {get; set;}
        private decimal bono;
        private decimal decSalary;
        //private Jornada jornada;
        private EJornada ejornada; // Llamo EJornada


        public Administrativo() : base()
        {
            this.bono = 0m;
           // this.jornadas = new List<Jornada>();
          // this.jornada = new Jornada();
           this.ejornada = new EJornada();
        }
        public Administrativo(decimal _bono, Persona _per) : base (_per)
        {
          //  Console.WriteLine("Constructor por parametros: "+_emp.getPersona());
            bono = _bono;
        }
        public Administrativo(decimal _bono, Empleado _emp, Persona _pers) : base (_emp, _pers)
        {
            bono = _bono;     
        }
        public Administrativo(decimal _bono, Empleado _emp) : base (_emp, _emp.getPersona())
        {
          //  Console.WriteLine("Constructor por parametros: "+_emp.getPersona());
            bono = _bono;
        }

        public Administrativo(decimal _bono, Empleado _emp, Persona _pers,EJornada _jornada) : base (_emp, _emp.getPersona())
        {
            //Console.WriteLine("Constructor por parametros: "+_emp.getPersona());
            bono = _bono;
            ejornada = _jornada;


            if ((EJornada.Completa.Equals(_jornada)))
            {
              //  Console.WriteLine("MATCH");
            }
            else 
            {
              //  Console.WriteLine("NOT MATCH");
            }
        }
                public Administrativo(Persona _pers,EJornada _jornada, decimal _bono) : base (_pers)
        {
            //Console.WriteLine("Constructor por parametros: "+_emp.getPersona());
            bono = _bono;
            ejornada = _jornada;


            if ((EJornada.Completa.Equals(_jornada)))
            {
             //   Console.WriteLine("MATCH");
            }
            else 
            {
             //   Console.WriteLine("NOT MATCH");
            }
        }
        /* 
        public void AddJornada(Jornada _jornada) // Have to create first the Jornada string as class.
        {
            Console.WriteLine("Debug Jornada "+_jornada.ToString());
            //jornada.Add(_jornada);
        }*/

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append(base.ToString());
            s.Append(", ");
            s.Append("Bonus: $"+(Math.Ceiling(base.getSalary()*bono)));
            s.Append(", ");
            s.Append("Jornada: "+ejornada);

            return s.ToString();
        }

        public decimal getBonus()
        {
            return bono;
        }

        public void CalcularSueldo(decimal _salud, decimal _afp)
        {
             decimal _TotalHaberes;
             decimal _SueldoLiquido;
             decimal _TotalDescuentos;
             decimal _BonoPagar;
             decimal _SeguroCesantia = .006m; // 6% seguro de cesantia
             decimal _AFP;
             decimal _Salud;

             // 0.15 % bono
             //  
            decSalary = Convert.ToDecimal(base.getSalary());
           // Console.WriteLine("Bono a pago: $"+(decSalary*bono).ToString());
            _BonoPagar = Math.Ceiling(decSalary*bono);
           // Console.WriteLine(base.getPersona());
            _TotalHaberes = decSalary+_BonoPagar;
            /*
            Console.WriteLine("Total Haberes: $"+_TotalHaberes);
            Console.WriteLine("DESCUENTOS:");
            Console.WriteLine("Salud: $"+(_TotalHaberes*_salud));
            Console.WriteLine("AFP: $"+(_TotalHaberes*_afp));
            Console.WriteLine("Seguro Cesantía: $"+(_TotalHaberes*_SeguroCesantia));
            */
            _Salud = Math.Floor(_TotalHaberes*_salud);
            _SeguroCesantia = Math.Floor(_TotalHaberes * _SeguroCesantia);
            _AFP = Math.Floor(_TotalHaberes*_afp);
            
            _TotalDescuentos = _Salud+_AFP+_SeguroCesantia;
            _SueldoLiquido = _TotalHaberes - _TotalDescuentos;

           // Console.WriteLine("Total Desc: "+_TotalDescuentos+", Haberes: "+_TotalHaberes+", Total: "+(_TotalHaberes-_TotalDescuentos));
           // Console.WriteLine("\nTotal Descuentos: $"+((_Salud)+(_AFP)+_SeguroCesantia));
           // _SueldoLiquido = _TotalHaberes - (_Salud+_AFP+_SeguroCesantia);
           
            
          //  Console.WriteLine("Sueldo A Pagar: $"+_SueldoLiquido.ToString());

            StringBuilder s = new StringBuilder();
            s.Append(base.ToString());
            s.Append(", ");
            s.Append("Net Income: $"+_SueldoLiquido);
            Console.WriteLine(s.ToString());



        }
        public override string quienSoy()
        {
            //return base.quienSoy();
            return "Soy un administrativo";
        }

    }



    
}