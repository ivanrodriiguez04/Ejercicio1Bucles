using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaNumeros.Servicios
{
    internal class SumaNumImplementacion : SumaNumInterfaz
    {
        public void sumaNum()
        {
            int numeroIntroducido = pideNum();
            int aux = 0;
            for (int i = 1; i <= numeroIntroducido; i++) 
            {
                aux = aux + i; ;
                if (i == numeroIntroducido)
                {
                    Console.Write(i + "=" + aux);
                }
                else
                {
                    Console.Write(i + "+");
                }
            }
        }
        /// <summary>
        /// Metodo que pide al usuario el numero necesario
        /// </summary>
        /// <returns></returns>
        private int pideNum() 
        {
            int numero;
            Console.WriteLine("Introduzca el numero que desee:");
            numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }
    }
}
