using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba01
{
    class Doomflayers : Vehiculo  //Una Doomflayer es una motocicleta de una rueda usada por skavens, para mas informacion visite esta pagina https://www.youtube.com/watch?v=QZymVCGqQ2k //
    {



        public void marca()
        {
            string Marca = Console.ReadLine();

        }
        public void ano()
        {
            string Ano = Console.ReadLine();

        }
        public void kilometraje()
        {
            double Kilometraje = Convert.ToInt32(Console.ReadLine());
        }

    }

}

