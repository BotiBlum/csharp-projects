using System;
using System.Text;
namespace MA_09.ClasesGenericas
{
    public class Florero
    {
        private Enumerados.EMateriales materiales;
        private string nombre;

        public Florero()
        {
            this.materiales = Enumerados.EMateriales.Cerámica;
        }
        public Florero(Enumerados.EMateriales _materiales)
        {
            materiales = _materiales;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(materiales);
            return sb.ToString();
        }
    }
}