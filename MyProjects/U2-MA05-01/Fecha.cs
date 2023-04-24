using System;
using System.IO;
using System.Text;

namespace Universidad
{
    public class Fecha
    {
        private int day;
        private int month;
        private int year;

        public Fecha()
        {
            this.day = 01;
            this.month = 01;
            this.year = 1923;

        }

        public Fecha(int _day, int _month, int _year)
        {
            day = _day;
            month = _month;
            year = _year;
        }
        public Fecha (Fecha _f)
        {
            day = _f.day;
            month = _f.month;
            year = _f.year;
        }
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append("");
            s.Append(day);
            s.Append("-");
            s.Append(month);
            s.Append("-");
            s.Append(year);
            return s.ToString();
        }
    }
}