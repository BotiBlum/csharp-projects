using System;
using System.IO;
using System.Text;
using Solemne02.Colecciones;

namespace Solemne02.Clases
{
       // @author: Pablo Vergaray
   // @rut: 16.775.865-7
    public class PrestamoPelicula : Prestamo
    {
        private int diasPrestamo;
        private Tipo tipo;

        // • Las propiedades.

        // • Constructores: 
        // Por defecto
        public PrestamoPelicula(): base()
        {
            tipo = Tipo.Estrenos;
            diasPrestamo = 31;

        }

        // con parámetros
        public PrestamoPelicula(Tipo _tipo, int _diasPrestamo, int _id, string _titulo, int _ISBN, Sede _sede, string _bibliotecario): base(_id, _titulo, _ISBN, _sede, _bibliotecario)
        {
            diasPrestamo = _diasPrestamo;
            tipo = _tipo;
        }
        
        // de copia
        public PrestamoPelicula(PrestamoPelicula _prest)
        {
            tipo = _prest.tipo;
            diasPrestamo = _prest.diasPrestamo;
        }
        
        // con un String como parámetro
        public PrestamoPelicula(string _datos): base()
        {
            StringBuilder d = new StringBuilder();
           // return d.ToString();

           string [] arreglo = _datos.Split(";");
            diasPrestamo = arreglo[0];
            
        }

        // • ToString()
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append(base.ToString());
            return s.ToString();
            
        }


        // • Método propio:
        // AumentarDia(), incrementa en uno los días de préstamo que tenía registrado.
        public void AumentarDia()
        {

        }

    }

    public enum Tipo
    {
        Estrenos,
        Clasicos,
        Mudas,
        BlancoNegro
    }
}







/*
-------     PARTE 2     -----------

En la carpeta Clases, implementa la clase PrestamoPelicula:
• Las propiedades.
• Constructores: Por defecto, con parámetros, de copia, con un String como parámetro.
• ToString().
• Método propio, AumentarDia(), incrementa en uno los días de préstamo que tenía registrado.






*/