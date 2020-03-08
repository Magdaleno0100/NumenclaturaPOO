using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscuela
{
    /// <summary>
    /// Ejemplo de clase Abstracta, como clase principal, donde heredrán las clases : Deportiva, Cultural y Académica
    /// </summary>
    abstract class Materia
    {
        #region Atributos
        string clave;
        string nombre;
        //Profesor coordinador;
        #endregion

        #region Métodos
        public abstract decimal Evaluar();
        #endregion
    }
}
