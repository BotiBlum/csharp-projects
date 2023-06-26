using System;
using MA_09.ClasesGenericas;
//using BibliotecaDeClases;

namespace MA09 
{
    public class App
    {
        
        public static void verificarCajaCelular(Caja<Celular> _caja, string _nombreCaja)
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
        private static void probarGenericas()
        {
            Caja<Celular> caja4 = new Caja<Celular>(new Celular("Iphone 12", 999909009));
            if (caja4.EstaVacia())
            {
                Console.WriteLine("La Caja 4 está vacía");
                
            }
            else 
            {
                Console.WriteLine("Contenido de la Caja 4");
                Console.WriteLine(caja4.ToString());
            }
            Caja<Florero> caja5 = new Caja<Florero>();
            if (caja5.EstaVacia())
            {
                Console.WriteLine("La Caja 5 está vacía");
            }
            else 
            {
                Console.WriteLine("La Caja 5 NO está vacía");
                Console.WriteLine(caja5.ToString());
            }
            caja5.guardar(new Florero(Enumerados.EMateriales.Vidrio));
            if (caja5.EstaVacia())
            {
                Console.WriteLine("La Caja 5 está vacía");
            }
            else 
            {
                Console.WriteLine("La Caja 5 NO está vacía...");
                Console.WriteLine(caja5.ToString());
            }

            Caja<Celular> caja6 = new Caja<Celular>();
            verificarCajaCelular(caja6, "Caja 6");
            caja6 = new Caja<Celular>(new Celular("Iphone 13", 999000));
            verificarCajaCelular(caja6, "Caja 6");
            caja6.verificarCaja(caja6,"nuevacaja6");
            
            caja5.verificar("Caja 5 simple");

        }
        public static void Main() 
        {

            Console.WriteLine("MA09 :)");
            /*
            Caja<Celular> caja1 = new Caja<Celular>(new Celular("Iphone 12", 999909009));
            if (caja1.EstaVacia())
            {
                Console.WriteLine("La Caja 1 está vacía");
                
            }
            else 
            {
                Console.WriteLine("Contenido de la Caja 1");
                Console.WriteLine(caja1.ToString());
            }
            Caja<Florero> caja2 = new Caja<Florero>();
            if (caja2.EstaVacia())
            {
                Console.WriteLine("La Caja 2 está vacía");
            }
            else 
            {
                Console.WriteLine("La Caja 2 NO está vacía");
                Console.WriteLine(caja2.ToString());
            }
            caja2.guardar(new Florero(Enumerados.EMateriales.Vidrio));
            if (caja2.EstaVacia())
            {
                Console.WriteLine("La Caja 2 está vacía");
            }
            else 
            {
                Console.WriteLine("La Caja 2 NO está vacía...");
                Console.WriteLine(caja2.ToString());
            }

            Caja<Celular> caja3 = new Caja<Celular>();
            verificarCajaCelular(caja3, "Caja 3");
            caja3 = new Caja<Celular>(new Celular("Iphone 13", 999000));
            verificarCajaCelular(caja3, "Caja 3");
            caja3.verificarCaja(caja3,"nuevacaja3");
            
            caja1.verificar("Caja simple");
            */
            // probarGenericas();
            Console.WriteLine("No nos interesa las pruebas genericas");

            /*
            Boleta bol1 = new Boleta(10, 1000, new DateTime()));
            Console.WriteLine(bol1.ToString());

            Caja<Boleta> cajaBoletas0 = new Caja<Boleta>(new Boleta (10, 1000, new DateTime()));
            Caja<Boleta> cajaBoletas1 = new Caja<Boleta>(new Boleta (10, 1000, new DateTime()));
            Caja<Boleta> cajaBoletas2 = new Caja<Boleta>();
            cajaBoletas0.verificarCaja("caja de boletas 0");
            cajaBoletas1.verificarCaja("caja de boletas 1");

            cajaBoletas2.verificarCaja("caja de boletas 2");
            cajaBoletas2.guardar(new Boleta(20,2000, new DateTime()));
            cajaBoletas2.verificarCaja("caja de boletas 1");
            
            output
            Contenido Caja de boletas
            Boletas XXX Monto XXX Fecha XXXXXXX
            Console.WriteLine("Este es el contenido Caja de Boletas2");
            Console.WriteLine(cajaBoletas1.sacar().ToString());

            Punto punto1 = new Punto();
            Console.WriteLine("Punto 1: "+ punto1.ToString());

            Punto punto2 = new Punto(3, 8);
            Console.WriteLine("Punto 1: "+ punto2.ToString());

            Punto[] misPuntos = new Punto[3];
            misPuntos[0] = punto1;
            misPuntos[1] = punto2;
            misPuntos[2] = new Punto(2, 1);
            

            */
        }       
    }
}