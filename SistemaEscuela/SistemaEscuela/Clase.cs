using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscuela
{
    class Clase : PruebaInterfaz
    {
        int numero;
        string atributo;
        public int Numero { set; get; }

        string PruebaInterfaz.Atributo
        {
            get
            {
                return atributo;
            }
            set
            {
                atributo = value;
            }
        }

        string PruebaInterfaz.Mensaje()
        {
            string mensaje = "Mensaje de Prueba";
            return mensaje;
        }
    }
}
