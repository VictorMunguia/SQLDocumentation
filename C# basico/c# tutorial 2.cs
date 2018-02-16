::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::Orientado a Objetos::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Clases Parciales---------------------------------------------------
Cosntructores------------------------------------------------------
Interfaces---------------------------------------------------------


// Documento Dog2----------------------------------------------------------->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

// Tenemos un archivo de tipo clase donde tenemos una clase dog partial, la palabra partial nos permite separar la clase en diferentes archivos, es decir, podemos
// poner algunos metodos o atributos en este archivo y poner el resto de metodos os atributos en otro archivo.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadoObjetos
{
	//Esta clase tiene asociacion con la interfaz IAnimal
    public partial class Dog : IAnimal              
    {

        private string Raza;//Atributo privado, el metodo para acceder a el esta en el otro archivo



        public Boolean CubrirPersona()//Metodo que regresa un valor booleando 
        {
            Console.WriteLine("Clase Perro");
            return false;
        }

    }
// Documento Dog----------------------------------------------------------->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

// En este archivo es donde se centra la mayor cantidad de codigo, tenemos 2 clases y una interface, una de las clases es la continuacion de Dog, por lo que en su
// palanra reservada lleva partial, la interfaz es un describen un grupo de comportamientos relacionados que pueden pertenecer a cualquier clase o estructura. 
// Las interfaces pueden estar compuestas de métodos, propiedades, eventos, indizadores o cualquier combinación de estos cuatro tipos de miembros. 
// Una interfaz no puede contener campos. Los miembros de interfaz son automáticamente públicos.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadoObjetos
{


    public interface IAnimal//De esta forma declaramos una interfaz, cabe destacar que todos los metodos y atributos que esten en la interfaz tendran que estar en todas las clases que esten asociadas
    {
        void Eat();
    }

    //De esta manera asociamos una clase con una interfaz
    public partial class Dog : IAnimal
    {

        private string Nombre;//Atributo privado

        private string Apellido { get; set; }//Atributo privado

        public string NOMBRE//Metodo para acceder a la informacion del atributo privado
        {
            get { return Nombre; }

            set { Nombre = value; }
        }

        public string APELLIDO//Metodo para acceder a la informacion del atributo privado
        {
            get { return Apellido; }

            set { Apellido = value; }
        }

        public string RAZA//Metodo para acceder a la informacion del atributo privado
        {
            get { return Raza; }

            set { Raza = value; }
        }


        public void Eat()//Metodo de la interfaz
        {
            Console.WriteLine("perro eating...");
        }


    }

    //---------------------------------------------------------
    //De esta manera asociamos una clase que esta heredando otra coase con una interfaz (Al heredar una clase estamos heredando sus metodos y atributos)
    public class casa : Dog, IAnimal
    {
        public casa()//Metodo constructor de la clase
        {
        }


        public casa(string a)//Metodo constructor de la clase con un atributo obligatorio
        {
            this.APELLIDO = a;
        }

        private string tejado;//Atributo privado


        public string TEJADO//Metodo de acceso para el atributo privado
        {
            get { return tejado; }

            set { tejado = value; }
        }

        public Boolean CubrirPersona()//Metodo de la casa
        {
            Console.WriteLine("Clase casa");
            return true;
        }


        public void Eat()//Metodo de la interfaz
        {
            Console.WriteLine("Casa eating...");
        }


    }



    //---------------------------------------------------------

    public class Trabajador
    {
        private string Nombre;//Atributo privado
        private int Sueldo;//Atributo privado
        private string Apellido;//Atributo privado

        public Trabajador(string N,int S,string A)//Constructor que al inicialisar el objeto tenemos que proporcionarle estos 3 datos
        {
            this.NOMBRE = N;
            this.SUELDO = S;
            this.APELLIDO = A;

        }

        public string NOMBRE//Metodo de acceso para el atributo privado
        {
        {
            get { return Nombre; }

            set { Nombre = value; }
        }

        public int SUELDO//Metodo de acceso para el atributo privado
        {
        {
            get { return Sueldo; }

            set { Sueldo = value; }
        }

        public string APELLIDO//Metodo de acceso para el atributo privado
        {
        {
            get { return Apellido; }

            set { Apellido = value; }
        }

        public void Eat()//Metodo de la interfaz, multiplicamos el sueldo y lo terminamos imprimiendo en un console.writeline
        {
            int resultado = SUELDO * 100;
            Console.WriteLine(Convert.ToString(resultado));
        }

    }
}


// Documento program----------------------------------------------------------->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

//
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
        	//Codigo para preguntar al usuario por el contenido del objeto.
            Console.WriteLine("Escriba su nombre");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Escriba su sueldo");
            int Sueldo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba su Apellido");
            string Apellido = Console.ReadLine();

            casa Casa1 = new casa();
            Dog Perro1 = new Dog();
            Trabajador trabajador1 = new Trabajador(Nombre,Sueldo,Apellido);//Inicialisacion del objeto trabajador, ya con las variables llenas las metemos en el constructor 
            

            Casa1.Eat();
            Perro1.Eat();
            Console.WriteLine(trabajador1.NOMBRE + " " + trabajador1.APELLIDO + " "  + Convert.ToString(trabajador1.SUELDO)); //Haci imprimimos el contenido de nuestro objeto
            trabajador1.Eat();//Invocamos el metodo.



            

            Console.ReadLine();

        }
    }
}