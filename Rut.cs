using System;
using System.Text;

namespace Empresa
{
    public class Rut
    {
        private int rut;
        private string dv;

        public Rut()
        {
            this.rut = 12345678;
            this.dv = "0";
        }
        public Rut(int _rut, string _dv)
        {
            rut = _rut;
            dv = _dv;
        }

        public Rut(Rut _r)
        {
            rut = _r.rut;
            dv = _r.dv;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append(rut);
            s.Append("-");
            s.Append(dv);

            return s.ToString();
        }


    }
}
