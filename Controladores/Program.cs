using SumaNumeros.Servicios;

namespace SumaNumeros.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// 24102023 -> irm
    /// </summary>
    class Program
    {
        /// <summary>
        /// metodo principal de la aplicacion
        /// 24102023 -> irm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Creamos los objetos
            SumaNumInterfaz si = new SumaNumImplementacion();

            //Llamamos a los metodos a traves de los objetos
            si.sumaNum();
        }
    }
}
