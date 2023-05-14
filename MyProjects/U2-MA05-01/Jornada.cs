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
           this.NombreJornada = "BASE STRING";
        }
        
        public Jornada(string _jornada) 
        {
           NombreJornada = _jornada;
        }
        public Jornada(Jornada _j)
        {
            NombreJornada = _j.NombreJornada;
        }
        
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append(NombreJornada);
            s.Append(EJornada.Completa.ToString());
            s.Append("TEXT");
            return s.ToString();
        }
        public string getNombreJornada()
        {
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
    }

    public enum EJornada
    {
            Completa,
           Media,
        Parcial
    }
}
// Jornada.EJornada.Completa