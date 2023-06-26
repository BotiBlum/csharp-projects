using System;
using System.Text;
namespace MA_09.ClasesGenericas
{
    public class Enumerados
    {
        public enum EMateriales
        {
            Cerámica,
            Madera,
            Vidrio
        }
        public override string ToString()
        {
            Console.WriteLine("string");
            StringBuilder sb = new StringBuilder();
           // sb.Append(EMateriales);
            return sb.ToString();
        }
    }
}