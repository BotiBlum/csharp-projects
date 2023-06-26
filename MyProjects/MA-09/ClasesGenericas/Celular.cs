using System;
using System.Text;
namespace MA_09.ClasesGenericas
{
    public class Celular
    {
        private string nombre;
        private int valor;
        public Celular()
        {
            nombre = "Sin Nombre";
            valor = 0;
        }
        public Celular(string _nombre, int _valor)
        {
            nombre = _nombre;
            valor = _valor;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(nombre);
            sb.Append(" - ");
            sb.Append(valor);
            return sb.ToString();
        }
    }
}