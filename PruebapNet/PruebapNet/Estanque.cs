using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba01
{
    class Estanque
    {
        public void NivelEstanque()
        {
            Console.WriteLine("Ingrese la capasidad del estanque");
            int Capacidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese los litros del estanque");
            float Litros = Convert.ToInt32(Console.ReadLine());
            if (Litros < Capacidad * 0.25 && Litros > Capacidad * 0.75)
            {
                Console.WriteLine("El tanque esta medio lleno");
                if (Litros < Capacidad * 0.75)
                {
                    Console.WriteLine("El tanque esta casi vacio");
                }
            }
        }
    }
}