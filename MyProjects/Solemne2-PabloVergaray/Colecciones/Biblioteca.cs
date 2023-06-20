using System;
using Solemne02.Clases;
using System.IO;
using System.Text;


namespace Solemne02.Colecciones
{
       // @author: Pablo Vergaray
   // @rut: 16.775.865-7
    public class Biblioteca
    {
        private string nombre;
        private Sede sede;

        private List<Prestamo> prestamos;

        /*
        • Las propiedades.
        */
        // • Constructores: 
        // Por defecto
        public Biblioteca()
        {
            nombre = "NONAME-BIBLIO";
            sede = Sede.Central;
            prestamos = new List<Prestamo>();            
        }

        // con el nombre del archivo como parámetro
        public Biblioteca(string _archivo)
        {
            FileStream f;
            StreamReader fr;
            string linea;
            try
            {
                f = new FileStream(_archivo, FileMode.Open,FileAccess.Read);
                fr = new StreamReader(f);
                while (!fr.EndOfStream)
                {
                    linea = fr.ReadLine();
                }
                fr.Close();
                f.Close();
            }
            catch(IOException ex)
            {
                Console.WriteLine("Error "+ex.Message);
            }
            
        }
        /*
        PrestamoLibro: “L, identificador, título, código ISBN, sede, bibliotecario, género y tapa”
        PrestamoPelicula: “P, identificador, título, código ISBN, sede, bibliotecario, tipo y días”
        */
        
        //para cargar la colección. 
        public Biblioteca(string _nombre, Sede _sede, List<Prestamo> _prestamos)
        {
            nombre = "NONAME";
            sede = Sede.Central;
            prestamos = new List<Prestamo>();
        }
        
        /*
        La estructura del archivo de texto es:
        PrestamoLibro: “L, identificador, título, código ISBN, sede, bibliotecario, género y tapa”
        PrestamoPelicula: “P, identificador, título, código ISBN, sede, bibliotecario, tipo y días”
        */
        
        // • Método ToString()
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            return s.ToString();

        }




    }

    public enum Sede
    {
        Central,
        Oriente
    }
}

/*             --------     PARTE 3           -----------
En la carpeta colecciones, construye la clase Biblioteca, que tiene como atributos el nombre 
de la biblioteca, la sede y una lista que representa a una colección de préstamos, en los que 
se podrá registrar tanto préstamos de libros como préstamos de películas que posee la biblioteca.
• Las propiedades.
• Constructores: Por defecto, con el nombre del archivo como parámetro, para cargar la colección. 
    La estructura del archivo de texto es:
    PrestamoLibro: “L, identificador, título, código ISBN, sede, bibliotecario, género y tapa”
    PrestamoPelicula: “P, identificador, título, código ISBN, sede, bibliotecario, tipo y días”
• Método ToString()

*/
// for each tipo javascript
//int index = 1;
/*
prestamos.foreach(p => {
    s.Append(index+"*"+p.ToString()+"\n");
    index++;
});
*/
/*     ----- PARTE 4     -----
Agrega los siguientes métodos a la clase Biblioteca. 
Todos los métodos utilizan la colección para dar respuesta a lo solicitado.

A.  ObtenerPrestamo(identificador): que retorna el préstamo (objeto completo) 
    con el identificador indicado en el parámetro. Recuerda la eficiencia de los métodos. 
    Si el préstamo no existe, debe retornar nulo.

B.  TotalPrestamoPeliculaMasDe(numDias): Retorna la cantidad de préstamos de películas más
     de los días indicados en el parámetro.

*/