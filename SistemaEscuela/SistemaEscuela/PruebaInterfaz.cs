using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscuela
{
    interface PruebaInterfaz
    {
        /*
         * En la interfaces no se puenden crear atributos, solo propiedades y métodos
         * string atributo;
         */
        string Atributo { get; set; }
        string Mensaje();
    }
}
