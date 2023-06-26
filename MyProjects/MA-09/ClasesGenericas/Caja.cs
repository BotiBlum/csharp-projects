using System;
namespace MA_09.ClasesGenericas
{
    public class Caja<T> where T:class
    {
        private T objeto;
        public T Objecto;

        public Caja()
        {
            Objecto = null;
            objeto = null;
        }
        public Caja(T _obj)
        {
            objeto = _obj;
        }
        public Caja(Caja<T> _caja)
        {
            objeto = _caja.objeto;
        }
        public override string ToString()
        {
            return objeto.ToString();
        }
        public void guardar(T _obj)
        {
            objeto = _obj;
        }
        public T Sacar()
        {
            return objeto;
        }
        public bool EstaVacia()
        {
            return objeto == null;
        }
        public void verificarCaja(Caja<T> _caja, string _nombreCaja)
        {
            if (_caja.EstaVacia())
            {
                Console.WriteLine("La Caja: "+_nombreCaja+" está vacía");
                
            }
            else 
            {
                Console.WriteLine("Contenido de la Caja "+_nombreCaja);
                Console.WriteLine(_caja.ToString());
            }
        }
        public void verificar(string _nombreCaja)
        {
            if (EstaVacia())
            {
                Console.WriteLine("La Caja: "+_nombreCaja+" está vacía");
                
            }
            else 
            {
                Console.WriteLine("Contenido de la Caja "+_nombreCaja);
                Console.WriteLine(objeto.ToString());
            }
        }

    }
}