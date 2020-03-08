using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscuela
{
    class Program
    {
        // Ejemplo de PROCEDIMIENTO
        public static void ImprimirMensajePrueba(int numeroVeces)
        {
            for (int i = 0; i <= numeroVeces; i++)
            {
                Console.WriteLine("Mensaje de Prueba");
            }           
        }

        public  void SiAcceso()
        {
            Console.WriteLine("Con referencia de objeto");
        }

        static void Main(string[] args)
        {
            Console.Title = "Sistema de Administración Escolar";

            Profesor<int> profesorInterno = new Profesor<int>();
            profesorInterno.Checar();

            Profesor<string> profesorExterno = new Profesor<string>();
            profesorExterno.Checar();

            //Eliminar o Destruir Objetos
            profesorInterno = null;

            /* Se requiere referencia de Objeto
             * SiAcceso()
             * Es necesario crear instancia
             *  Program obj = new Program();
                obj.SiAcceso();
            */

            //Ejemplo de Generics
            List<int> lista = new List<int>();



            ImprimirMensajePrueba(10);


            Console.ReadKey();



        }
    }
}
