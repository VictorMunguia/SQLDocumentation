::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::Orientado a Objetos::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Clases Parciales---------------------------------------------------


archivo 1
-----------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadoObjetos
{
    public partial class Dog
    {

        private string Nombre;

        private string Apellido { get; set; }

        public string NOMBRE
        {
            get { return Nombre; }

            set { Nombre = value; }
        }

        public string APELLIDO
        {
            get { return Apellido; }

            set { Apellido = value; }
        }

        public string RAZA
        {
            get { return Raza; }

            set { Raza = value; }
        }


    }

    //---------------------------------------------------------

    public class casa : Dog
    {
        public casa()
        {
        }


        public casa(string a)
        {
            this.APELLIDO = a; 
        }

        private string tejado;


        public string TEJADO
        {
            get { return tejado; }

            set { tejado = value; }
        }


        public Boolean CubrirPersona()
        {
            Console.WriteLine("Clase casa");
            return true;
        }


    }
}


archivo 2
-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadoObjetos
{
    public partial class Dog
    {

        private string Raza;



        public Boolean CubrirPersona()
        {
            Console.WriteLine("Clase Perro");
            return false;
        }

    }
}





archivo 3
-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OrientadoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog Perro1 = new Dog();
            casa Casa1 = new casa();
            casa PerroMutante = new casa();




            Console.WriteLine(Casa1.CubrirPersona().);
            Console.ReadLine();






            


    
        }
    }
}