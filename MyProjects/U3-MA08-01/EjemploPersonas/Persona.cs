using System;
using System.Collections.Generic;
using MA_08.Comparadores;

namespace MA_08.EjemploPersonas
{
    public class Persona
    {
        private string rut;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;

        public Persona()
        {
            rut = "Sin Rut";
            nombre = "Sin Nombre";
            apellidoPaterno = "Sin Apellido";
            apellidoMaterno = "Sin Apellido";
        }
        public Persona(string _rut, string _n, string _ap, string _am)
        {
            rut = _rut;
            nombre = _n;
            apellidoPaterno = _ap;
            apellidoMaterno = _am;
        }
        public string getRut()
        {
            return rut;
        }
        public string getNombre()
        {
            return nombre;
        }
        public string getApellidoPaterno()
        {
            return apellidoPaterno;
        }
        public string getApellidoMaterno()
        {
            return apellidoMaterno;
        }

        public override string ToString()
        {
            return rut +";"+nombre+" "+ apellidoPaterno+" "+apellidoMaterno;
        }
        public void ordenarPorApellidoPaterno(Persona[] _lista)
        {

              Array.Sort(_lista, new PorApellidoPaterno());
            
            
        }
        public void ordenarPorApellidoMaterno(Persona[] _lista)
        {

              Array.Sort(_lista, new PorApellidoMaterno());
            
        }
        public void ordenarPorNombre(Persona[] _lista)
        {

              Array.Sort(_lista, new PorNombre());
            
        }
        public void ordenarPorRut(Persona[] _lista)
        {

              Array.Sort(_lista, new PorRut());
            
        }
    }
}
