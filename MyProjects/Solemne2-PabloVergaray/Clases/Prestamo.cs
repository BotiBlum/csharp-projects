using System;
using System.IO;
using System.Text;
using Solemne02.Colecciones;

namespace Solemne02.Clases
{
       // @author: Pablo Vergaray
   // @rut: 16.775.865-7
    public class Prestamo
    {
        private int id;
        private string titulo;
        private int ISBN;
        private Sede sede;
        private string bibliotecario;

        public Prestamo()
        {
            sede = new Sede();
            bibliotecario = "Perico Los Palotes";
            ISBN = 0000000000;
            titulo = "Sin Titulo";
            id = 0;

        }

        public Prestamo(int _id, string _titulo, int _ISBN, Sede _sede, string _bibliotecario)
        {
            id = _id;
            titulo = _titulo;
            ISBN = _ISBN;
            sede = _sede;
            bibliotecario = _bibliotecario;
        }
        public Prestamo(string _datos)
        {
            StringBuilder d = new StringBuilder();
            d.Append("");
            //return d.ToString();
        }
    }

    
}