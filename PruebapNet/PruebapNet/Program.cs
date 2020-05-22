using System;
using System.Collections;

namespace Prueba01
{
    class Program
    {
        static void Main(string[] args)
        {
            String usuario;
            String clave;
            do
            {

                Console.WriteLine("Ingresar usuario");

                usuario = Console.ReadLine();
                Console.WriteLine("Ingresar clave");

                clave = Console.ReadLine();

                if (usuario != "admin" || clave != "abc123")
                {
                    Console.WriteLine("Credenciales incorrectas, intentelo nuevamente");
                }

            } while (usuario != "admin" || clave != "abc123");


            Console.WriteLine("Bienvenido, que operacion desea realizar?");
            Console.WriteLine("_1 Ingresar un nuevo vehiculo");
            Console.WriteLine("_2 Vehiculo ingresado");
            Console.WriteLine("_3 Salir");


            int respuestaa = Convert.ToInt32(Console.ReadLine());

            if (respuestaa == 1)
            {

                Doomflayers d = new Doomflayers();

                Console.WriteLine("ingrese la marca de su vehiculo");
                d.marca();
                Console.WriteLine("ingrese el año de su vehiculo");
                d.ano();
                Console.WriteLine("ingrese el kilometraje");
                d.kilometraje();

                Estanque e = new Estanque();
                e.NivelEstanque();



            }
        }

    }
}
