using System;
using System.IO;
using System.Text;


namespace Universidad
{
    public class Jornada
    {
        public string NombreJornada {get; set;}
        public Jornada() 
        {
            Console.WriteLine("WORKS JORNADA BASE");
           this.NombreJornada = "BASE STRING";
        }
        
        public Jornada(string _jornada) 
        {
            Console.WriteLine("WORKS JORNADA STRING ");
           NombreJornada = _jornada;
        }
        public Jornada(Jornada _j)
        {
            Console.WriteLine("WORKS JORNADA COPY");
            NombreJornada = _j.NombreJornada;
        }
        
        public override string ToString()
        {
            Console.WriteLine("WORKS JORNADA STRING BUILDER");
            StringBuilder s = new StringBuilder();
            s.Append(NombreJornada);
            s.Append(EJornada.Completa.ToString());
            s.Append("TEXT");
            return s.ToString();
        }
        public string getNombreJornada()
        {
            Console.WriteLine("WORKS JORNADA GETNAME");
            return NombreJornada;
        }

        public void Media()
        {
            NombreJornada = "MEDIA";
        }
        public void Completa()
        {
            NombreJornada = "COMPLETA";
        }




        
        /*
        public  Jornada Media()
        {
         //    return jornada[0];
             return jornada;;
        }
*/   }
    public enum EJornada
        {
            Completa,
            Media,
            Parcial

        }
}