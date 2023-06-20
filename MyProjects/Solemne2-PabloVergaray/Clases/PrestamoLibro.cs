using System;
using System.IO;
using System.Text;
using Solemne02.Colecciones;

namespace Solemne02.Clases
{
       // @author: Pablo Vergaray
   // @rut: 16.775.865-7
    public class PrestamoLibro: Prestamo
    {
        // • Las propiedades.
        private Genero genero;
        private Tapa tapa;


        /*
        • Constructores:
        */ 
        
        // Por defecto
        public PrestamoLibro (): base ()
        {
            genero = Genero.Masculino;
            tapa = Tapa.Blanda;
        }
        //con parámetros
        public PrestamoLibro (Genero _genero, Tapa _tapa, int _id, string _titulo, int _ISBN, Sede _sede, string _bibliotecario): base (_id, _titulo, _ISBN, _sede, _bibliotecario)
        {
            genero = new Genero();
            tapa = new Tapa();
        }
        //de copia
        public PrestamoLibro (PrestamoLibro _prest)
        {
            genero = _prest.genero;
            tapa = _prest.tapa;
        }
        //con un String como parámetro.
        public PrestamoLibro (string _datos): base ()
        {
            StringBuilder s = new StringBuilder();
            string linea;
            
            //return s.ToString();
            
        }
    
        //• ToString()
        override public string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append(base.ToString());
            return s.ToString();
        }
    }


    public enum Genero
    {
        Masculino,
        Femenino
    }
    public enum Tapa
    {
        Dura,
        Blanda
    }
}





/*
-----------     PARTE 1        -----------------
En la carpeta Clases, implementa la clase PrestamoLibro
• Las propiedades.
• Constructores: Por defecto, con parámetros, de copia, con un String como parámetro.
• ToString().




*/