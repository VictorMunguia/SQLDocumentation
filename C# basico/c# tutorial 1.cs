
//Para hacer una escritura en la consola utilizamos el metodo writeLine y ReadLine para poder escribir y leer lo que escribimos.----------------------------------
Console.WriteLine("Hello World");
Console.ReadLine();



//Creacion de varables.

int x;
int y;

x = 7;
y = x + 3;

Console.WriteLine(y);
Console.ReadLine();


// peticion de datos en consola.
//En este programa tenemos un camando WriteLine que nos permite escribir una line de texto que hayamos espesificado, despues estamos declarando una variable de tipo
//string donde meteremos el nombre dle usuario, usando el metodo ReadLine nos permite bloquear el teclado del usuario para esperar una linea de codigo o solo para
//bloquear el proceso del programa en la consola.---------------------------------------------------------------------------------------------------------------

Console.WriteLine("Escribe tu primer nombre");
string myFirstName = Console.ReadLine();

Console.WriteLine("Hello, " + myFirstName);
Console.ReadLine();





//Codigo de condicion IF, utilizado para las decisione.-----------------------------------------------------------------------------------------------------------

Console.WriteLine("Escoje una puerta");
            Console.Write("La nuemro 1, numero 2, numero 3: ");
            string Seleccion;

            Seleccion = Console.ReadLine();

            if(Seleccion == "1")
            {
                Console.WriteLine("Felicidades ganaste un carro");


            }
            else
            {
                Console.WriteLine("Nel no ganaste nada");
            }
            Console.ReadLine();


//Ciclo for
//mientras que I valga menos que 10, esta madre va a seguir imprimiendo datos.--------------------------------------------------------------------------------

            for (int i = 0; i < 10; i++) {

                Console.WriteLine(i);


            }
            Console.ReadLine();



//Ciclo con una condicion en el.---------------------------------------------------------------------------------------------------------------------------------


            for (int i = 0; i < 10; i++) {

                Console.WriteLine(i);

                if(i == 7)
                {
                    Console.WriteLine("Encontre el 7");
                }


            }
            Console.ReadLine();


//Arreglo tipo int-------------------------------------------------------------------------------------------------------------------------------------------------

            int[] numbers = new int[5];


            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            Console.WriteLine(numbers[1]);
            Console.ReadLine();


//Arraglo con recorrido en la condicion----------------------------------------------------------------------------------------------------------------------


                        string[] names = new string[] { "Victor", "Corey", "Huevos" };



            for(int i = 0;i < names.Length;i ++)
            {

                Console.WriteLine(names[i]);

            }
            Console.ReadLine();



// Ciclo foreach especialisado para ciclos, solo tenemos que poner el nombre del ciclo para poder recorrer el ciclo completo.--------------------------------------



            string[] names = new string[] { "Victor", "Corey", "Huevos" };



            foreach ( string name in names)
            {
                Console.WriteLine(name);

            }
            Console.ReadLine();






 // Metodo para voltear tu nombre, utilizando un ciclo foreach y pidiendo al usuario el nombre.----------------------------------------------------------------

            Console.WriteLine("Escribe tu nombre: ");
            string zing = Console.ReadLine();


            char[] charArray = zing.ToCharArray();
            Array.Reverse(charArray);


            foreach(char letra in charArray )
            {
                Console.Write(letra);

            }
            Console.ReadLine();





  //En este codigo declaramos un metodo fuera del metodo de inicio del programa, para mandarlo a llamar ya dentro del programa.-----------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {



        private static void HolaMundo()
        {
            Console.WriteLine("Hola mundo");
        }

        static void Main(string[] args)
        {

            HolaMundo();
            Console.ReadLine();
            
        }
    }
}




//Aplicacion que le pide al usuario su nombre, apellido, ciudad y edad las voltea, pero utilizando un metodo.-------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {





        private static void VoltearArreglo(string x)
        {

            char[] ArrelgoVolteado =  x.ToCharArray();
            Array.Reverse(ArrelgoVolteado);

            foreach(char Valor in ArrelgoVolteado)
            {
                Console.Write(Valor);
            }
            Console.Write(" ");

        }

        static void Main(string[] args)
        {
            string Nombre;
            string Apellido;
            string Ciudad;
            int Edad;


            Console.Write("Cual es tu nombre?: ");
            Nombre = Console.ReadLine();

            Console.WriteLine(" ");

            Console.Write("Cual es tu apellido?: ");
            Apellido = Console.ReadLine();

            Console.WriteLine(" ");

            Console.Write("Cual es tu Ciudad?: ");
            Ciudad = Console.ReadLine();

            Console.WriteLine(" ");

            Console.Write("Cual es tu Edad?: ");
            Edad = Convert.ToInt32(Console.ReadLine());

            

            Console.Write("El resultado es : ");
            VoltearArreglo(Nombre);
            VoltearArreglo(Apellido);
            VoltearArreglo(Ciudad);
            VoltearArreglo(Convert.ToString(Edad));
            Console.ReadLine();


        }
    }
}




//El mismo metodo por con metodo de imrpimir para ahorrar mas lineas, es posible hacer dos metodos con el mismo nombre, donde uno pedimos variables y el otro no.-------------------------------
//--------------------------------------------------------------------------------------------------------------------------------------------------------------



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {





        private static string VoltearArreglo(string x)
        {

            char[] ArrelgoVolteado =  x.ToCharArray();
            Array.Reverse(ArrelgoVolteado);

            return String.Concat(ArrelgoVolteado);

        }


        private static void Imprimir(string x, string y, string Z, string w)
        {
            Console.Write("EL resultado es: ");
            Console.Write(x + " "+ " " +  y  + " " + Z  + " " + w);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            string Nombre;
            string Apellido;
            string Ciudad;
            int Edad;


            Console.Write("Cual es tu nombre?: ");
            Nombre = Console.ReadLine();

            Console.WriteLine(" ");

            Console.Write("Cual es tu apellido?: ");
            Apellido = Console.ReadLine();

            Console.WriteLine(" ");

            Console.Write("Cual es tu Ciudad?: ");
            Ciudad = Console.ReadLine();

            Console.WriteLine(" ");

            Console.Write("Cual es tu Edad?: ");
            Edad = Convert.ToInt32(Console.ReadLine());



            
            string NombreAlreves = VoltearArreglo(Nombre);
            string ApellidoAlreves = VoltearArreglo(Apellido);
            string CiudadAlreves = VoltearArreglo(Ciudad);
            string EdadAlreves = VoltearArreglo(Convert.ToString(Edad));
            Imprimir(NombreAlreves, ApellidoAlreves, CiudadAlreves, EdadAlreves);
  


        }
    }
}


//Programa que deja jugar al usuario con una tabla de multiplicar y un juego de adivinar el numero.----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {

    	//Metodo que imprime el menu
        private static Boolean MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al Menu");
            Console.WriteLine("Escoja una opcion¡¡¡¡");
            Console.WriteLine("1) Opcion 1");
            Console.WriteLine("2) Opcion 2");
            Console.WriteLine("3) Opcion 3");
            Console.WriteLine("4) Opcion 4");
            Console.WriteLine("5) Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                Opcion1Multiplicar();
            }
            else if (opcion == 2)
            {
                Opcion2Suerte();
            }
            else if (opcion == 3)
            {
                Opcion3();
            }
            else if (opcion == 4)
            {
                Opcion4();
            }
            else if (opcion == 5)
            {

                return false;
            }
            else
            {
                Console.WriteLine("Opcion invalida");
            }


            return true;

        }

        	//Metodo que juega con el usuario imprimiendo una tabla de multiplicar
        private static void Opcion1Multiplicar()
        {
            int numero = 1;
            Console.Clear();

            Console.WriteLine("Tablas de multiplicar");
            Console.WriteLine("Escoja una tabla");
            int Tabla = int.Parse(Console.ReadLine());
            while(numero < Tabla + 1)
            {
                Console.WriteLine("La tabla del: " + Tabla + " " + Tabla + " X " + numero + " = " + (Tabla * numero));
                numero = numero + 1;
            }
            Console.ReadLine();
        }


        //Metodo que juega con el usuario adivinando el numero
        private static void Opcion2Suerte()
        {
            Random NumeroAleatorio = new Random();
            int Numero = NumeroAleatorio.Next(1,11);

            int intentos = 3;

            while(intentos != 0)
            {
                Console.Clear();

                Console.WriteLine("Felicidades 2");
                Console.WriteLine("Intenta adivinar el numero entre 1 y 10");
                int NumeroSuerte = int.Parse(Console.ReadLine());

                if (NumeroSuerte == Numero)
                {
                    Console.WriteLine("Felcidiades acertaste, el numero es: " + Numero);
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Nel wey, intentalo otra vez, numero de intentos: " + intentos);
                    Console.WriteLine("Precione enter para continuar");
                    Console.ReadLine();
                }

                intentos--;
            }

            if(intentos==0)
            {
                Console.WriteLine("Mala suerte broo");
                Console.ReadLine();
            }
            


        }

        private static void Opcion3()
        {
            Console.Clear();

            Console.WriteLine("Felicidades 3");
            Console.ReadLine();
        }

        private static void Opcion4()
        {
            Console.Clear();

            Console.WriteLine("Felicidades 4");
            Console.ReadLine();
        }

        private static void Opcion5()
        {
            Console.Clear();

            Console.WriteLine("Gracias por haber venido");
            Console.ReadLine();
        }

        //Programa principal, aqui se une todo, solo es un while y estamos manando a llavmar el metodo mostrarMenu el cual tiene un return que le esta aplicando a nuestra 
        //bandera, siempre y cuando nuestra vandera sea true el metodo MostrarMenu se seguir ejecutando.
        static void Main(string[] args)
        {
            Boolean banderaMenu = true;
            while(banderaMenu == true)
            {

                banderaMenu = MostrarMenu();


            }

        }
    }
}

// Esta es la manera en la que imprimimos caracteres con simbolos especiales.-------------------------------------------------------------------------------------

string Nombre = "Mi nombre es \"victor Munguia Enciso\"es" ;

            Console.WriteLine(Nombre);
            Console.ReadLine();


// Codigo para crear un objeto tipo date que con el codigo.NOW nos da la hora actual.---------------------------------------------------------------------------

            DateTime myValue = DateTime.Now;
                Console.WriteLine(myValue.ToString());
                Console.ReadLine();



//Con este metodo podemos imprimir solo la fecha y no el tiempo----------------------------------------------------------------------------------------------------

            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToShortDateString());
            Console.ReadLine();


//Con esta imprimir el tiempo----------------------------------------------------------------------------------------------------------------------------------------


            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToShortTimeString());
            Console.ReadLine();


//Podemos agregar horas, dias , meses ETCA... con estas funciones------------------------------------------------------------------------------------------------

              DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
            Console.ReadLine();




//COdigo que crea un objeto tipo car y lo mandamos a llamar, hay que investigar constructores nada mas.-----------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {


        class car
        {
            public string Empresa { get; set; }
            public string Modelo { get; set; }
            public int Año { get; set; }
            public string Color { get; set; }
        }

        static void Main(string[] args)
        {


            car NuevoCarro = new car();
            NuevoCarro.Empresa = "Chebrolet";
            NuevoCarro.Modelo = "Mustang";
            NuevoCarro.Año = 2018;
            NuevoCarro.Color = "Pinchi Rojo";


            Console.WriteLine("{0} {1} {2} {3}",NuevoCarro.Empresa,NuevoCarro.Modelo,NuevoCarro.Año,NuevoCarro.Color);
            Console.ReadLine();

        }
    }
}




//Recuerda el contexto, donde declaras las variables depende de donde puedes usarlas, a esto se le llama SCOPE----------------------------------------------------



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 2;

            for(int a = 0; a < 10; a++)
            {
                int b = 1;
                Console.WriteLine(a);
            }
            Console.ReadLine();

            Console.WriteLine(b);//No se puede usar debido a que esta solo declarada dentro del ciclo for
            Console.WriteLine(z);//Se puede usar debido a que se declara a nivel main y se peude usar dentro del ciclo y fuera de.


        }
    }
}






//Ejemplo de encapsulacion.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {


    	//Clase carro, tenemos asignados variables privadas las cuales solo pueden ser tocadas con los metdodos que creamos.
        class car
        {


            private string Nombre;
            private string Apellido;
            private string Edad;


            //Metodo nombre que contiene un get para sacar la informacion y un set para introducirla.
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

            public string EDAD

            {

                get { return Edad; }

                set { Edad = value; }

            }

            //Tenemos dos metodos, uno privado y otro publico, en privado no se peude acceder en ningun momento en el contexto principal del programa
            //sin embargo si se peude acceder a un metodo privado en su propia clase.
            public void DoSomething()
            {
                Console.WriteLine(MetodoAyuda());
            }

            private string MetodoAyuda()
            {
                return "Hello world¡";
            }


        }

        static void Main(string[] args)
        {
            car CarroNuevo = new car();

            CarroNuevo.APELLIDO = "Munguia";


            string Apellido = CarroNuevo.APELLIDO;
            Console.WriteLine(Apellido);
            Console.ReadLine();

        }
    }
}





//Tenemos un ejemplo de como usar las librerias que tenemos arriba de cada proyecto y como guardar un archivo de texto desde .NET--------------------------------

using System; //Esta libreria nos permite acceder a los componentes System sin necesidad de poner System.Console
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;//El comnado para guardar archivos de texto lleva System.IO pero al poner la libreria aqui ya no es necesario.

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            string TextoDocumento = "Mi nombre es victor munguia enciso y la ando cagando recio en el amor";
            Console.WriteLine("");

            File.WriteAllText(@"C:\Users\vMunguia\Desktop", TextoDocumento); //Esta linea de codigo gracias a la libreria no lleva System.IO.

            Console.WriteLine("Echo");
            Console.ReadLine();
        }
    }
}





//Codigo para sacar el HTML de una pagina en formato string


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Net;//Nueva libreria que nos permite usar la clase WebClient

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {



            WebClient client = new WebClient();//Esta clase, al tener acceso a la clase tenemosa acceso a los metodos

            string reply = client.DownloadString("http://rogerdudler.github.io/git-guide/index.es.html"); // Estos metodos XD

            Console.WriteLine(reply);
            Console.ReadLine();
        }
    }
}



//En este ejemplo tenemos un arraylist y una list


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TrabajandoConColecciones
{
    class Program
    {
        static void Main(string[] args)
        {

            car carro1 = new car();
            car carro2 = new car();
            Libro libro1 = new Libro();

            carro1.HACEDOR = "Oldmobile";
            carro1.MODELO = "Cutlas supreme";

            carro2.HACEDOR = "Geo";
            carro2.MODELO = "Prism";

            libro1.AUTOR = "Robert Tabor";
            libro1.TITULO = "Microsoft .NET xml web services";
            libro1.ENC_ISBN = "8,0000,0000,000";

            ArrayList MiArrayList = new ArrayList();//La arraylist nos permite agregar todo tipo de elementos pero es poco segura es mejor usar las listas
            List<car> lista1carro = new List<car>();//se decalara de esta manera una lista y tenemos que espesiciar entre los <> el tipo de objetos que va a almacenar las listas

            lista1carro.Add(carro1);//Se agregan elementos de esta manera , para los dos casos es igual

            MiArrayList.Add(carro1);
            MiArrayList.Add(carro2);


            //Para recorrer la lista y la arraylist usamos un foreach, es mas sencillo.
            foreach (car car in MiArrayList)
            {
                Console.WriteLine(car.HACEDOR);
            }
            Console.ReadLine();

            foreach (car car in lista1carro)
            {
                Console.WriteLine(car.MODELO);
            }
            Console.ReadLine();


        }


        class car
        {
            private string Hacedor;
            private string Modelo;

            public string HACEDOR

            {

                get { return Hacedor; }

                set { Hacedor = value; }

            }


            public string MODELO
            {

                get { return Modelo; }

                set { Modelo = value; }
            }
        }

        class Libro
        {
            private string Titulo;
            private string ISBN;
            private string Autor;

            public string AUTOR
            {
                
                get { return Autor; }
                set { Autor = value; }
            }

            public string TITULO

            {

                get { return Titulo; }

                set { Titulo = value; }

            }


            public string ENC_ISBN
            {

                get { return ISBN; }

                set { ISBN = value; }
            }
        }
    }
}



//Utilizando el LINQ-------------------------------------------------------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using BuscadorWeb2;

namespace TrabajandoConColecciones
{
    class Program
    {
        static void Main(string[] args)
        {


        	//Esta es una forma de crear una lista llenandola al mismo tiempo de objetos tipo carro, con esto ya no es necesario nombrar cada objeto, la lista se encarga de identificarlos por su posicion
            List<car> ListaCarro = new List<car>()
            {
                new car(){ENC_VIN = "A1", HACEDOR = "BMW", MODELO = "550I",PRECIO = 150000,AÑO = 2000 },
                new car(){ENC_VIN = "B1", HACEDOR = "AWC", MODELO = "450I",PRECIO = 250000,AÑO = 2001 },
                new car(){ENC_VIN = "C1", HACEDOR = "CMW", MODELO = "250I",PRECIO = 300000,AÑO = 2002 },
                new car(){ENC_VIN = "D1", HACEDOR = "DMW", MODELO = "150I",PRECIO = 350000,AÑO = 2003 },
                new car(){ENC_VIN = "E1", HACEDOR = "FMW", MODELO = "A50I",PRECIO = 400000,AÑO = 2004 },
                new car(){ENC_VIN = "F1", HACEDOR = "GMW", MODELO = "D50I",PRECIO = 450000,AÑO = 2010 },
                new car(){ENC_VIN = "G1", HACEDOR = "HMW", MODELO = "G50I",PRECIO = 500000,AÑO = 2015 },
                new car(){ENC_VIN = "H1", HACEDOR = "JMW", MODELO = "H50I",PRECIO = 550000,AÑO = 2020 }
            };


            //LINQ query
            //Ponemos condiciones y ubicaciones como si se tratara de una sentencia SQL, 

            var queryLINQ = from car in ListaCarro
                            where car.HACEDOR != "BMW"
                            && car.AÑO > 2003
                            select car;


            //LINQ Metodo
            //Simple metodo para recorrer el queryLINQ, parece que es una lista, y se llena a vace de la comparacion de la lsita car, todo similar.
            foreach(var car in queryLINQ)
            {
                Console.WriteLine("{0} {1} {2}", car.ENC_VIN, car.AÑO, car.HACEDOR);
            }
            Console.ReadLine();


        }

        //tODO LO QUE TENEMOS ABAJO DE ESTO SON LA CLASE CAR Y LIBRO LAS CUALES TIENENE ATRIBUTOS PRIVADOS Y SUS RESPECTIVOS METODOS ENCAPSULADOS PARA ACCEDER A SUS ATRIBUTOS

        class car
        {
            private int Precio;
            private int año;
            private string VIN;
            private string Hacedor;
            private string Modelo;

            public int AÑO
            {
                get { return año; }
                set { año = value; }
            }

            public int PRECIO
            {
                get { return Precio; }
                set { Precio = value; }
            }

            public string ENC_VIN

            {

                get { return VIN; }

                set { VIN = value; }

            }

            public string HACEDOR

            {

                get { return Hacedor; }

                set { Hacedor = value; }

            }



            public string MODELO
            {

                get { return Modelo; }

                set { Modelo = value; }
            }
        }

        class Libro
        {
            private string Titulo;
            private string ISBN;
            private string Autor;

            public string AUTOR
            {
                
                get { return Autor; }
                set { Autor = value; }
            }

            public string TITULO

            {

                get { return Titulo; }

                set { Titulo = value; }

            }


            public string ENC_ISBN
            {

                get { return ISBN; }

                set { ISBN = value; }
            }
        }
    }
}



//Switch y enumeracion


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeracionSwitch
{
    class Program
    {


    	//Tenemos la clase todo, donde tenemos nuestros metodos encapsulados para acceder a nuestros atributos.
        class Todo
        {

            private string Descripcion;
            private int HorasEstimadas;
            private Status Estatus;

            public string DESCRIPCION
            {

                get { return Descripcion; }

                set { Descripcion = value; }
            }

            public int HORAESTIMADA
            {

                get { return HorasEstimadas; }

                set { HorasEstimadas = value; }
            }

            public Status ESTATUS
            {

                get { return Estatus; }

                set { Estatus = value; }
            }

        }

        //Tenemos un metodo de enmueracion, podemos asignar palabras y c# les asigna un numero (Un valor)
        enum Status
        {
            SinIniciar,
            EnProgueso,
            EnEspera,
            Completo,
            Eliminado
        }

        //Creamos un metodo que no regresa nada y pedimos un objeto tipo Todo el cual sera la lsita que tiene nuestros campos
        private static void PrintAssessment(List<Todo> x)
        {
        	//Creamos un foreeach donde metemos una variable que representa nuestra lista que va a recorrer nuestra lista la cual es la X
            foreach(Todo todos in x)
            {
            	//en este switch condicionamos que cada registro dependiendo del tipo de status es el color que va a imprimir el texto
                switch (todos.ESTATUS)
                {

                    case Status.Completo:
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        }
                    case Status.Eliminado:
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            break;
                        }
                    case Status.EnEspera:
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            break;
                        }
                    case Status.EnProgueso:
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                        }
                    case Status.SinIniciar:
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        }


                }
                Console.WriteLine(todos.DESCRIPCION);
            }
        }


        //Centro dle programa
        static void Main(string[] args)
        {
        	//Creamos una lista y la llenamos 
            List<Todo> Todos = new List<Todo>()
            {
            	//Aqui llenamos la lista, y en el atributo status estamos poniendo el nombre del contador para que nos detecte las palabras que pusmios
                new Todo(){DESCRIPCION = "Tarea1", HORAESTIMADA = 6, ESTATUS = Status.Completo},
                new Todo(){DESCRIPCION = "Tarea2", HORAESTIMADA = 16, ESTATUS = Status.Eliminado},
                new Todo(){DESCRIPCION = "Tarea3", HORAESTIMADA = 3, ESTATUS = Status.EnEspera},
                new Todo(){DESCRIPCION = "Tarea4", HORAESTIMADA = 1, ESTATUS = Status.EnProgueso},
                new Todo(){DESCRIPCION = "Tarea5", HORAESTIMADA = 4, ESTATUS = Status.SinIniciar},
                new Todo(){DESCRIPCION = "Tarea6", HORAESTIMADA = 9, ESTATUS = Status.Completo},
                new Todo(){DESCRIPCION = "Tarea7", HORAESTIMADA = 12, ESTATUS = Status.Eliminado},
                new Todo(){DESCRIPCION = "Tarea8", HORAESTIMADA = 1, ESTATUS = Status.EnEspera},
                new Todo(){DESCRIPCION = "Tarea9", HORAESTIMADA = 6, ESTATUS = Status.EnProgueso}
            };


            
            //Mandamos a llamar el metodo para imprimir los campos.
            PrintAssessment(Todos);
            Console.ReadLine();

        }

    }
}


//Timer

using System;

using System.Timers;

namespace Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer MiTimer = new Timer(2000);//Esto son 2 segundos

            MiTimer.Elapsed += MiTimer_Elapsed;

            MiTimer.Start();

            Console.ReadLine();
        }

        private static void MiTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);//Esto nos imprime el tiempo cada dos segundos
        }
    }
}





https://mva.microsoft.com/en-US/training-courses/c-fundamentals-for-absolute-beginners-16169?l=Y6D7PQQIC_5406218949--------------------------------------------------

http://undiaparahablar.blogspot.mx/2010/02/polimorfismo.html--------------------- Exelente ejemplo de programacion orientada a objetos