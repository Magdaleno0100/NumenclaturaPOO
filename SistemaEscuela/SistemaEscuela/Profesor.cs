using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscuela
{
    class Profesor<Tipo> : Empleado<Tipo>   
    {
        #region Atributos
        private string matricula;
        /*
         * Se comenta el atributo para poner el ejemplo de Propiedades AutoImplementadas
         * private Materia materia;
         */

        private FrecuenciaPago frecuenciaPagoProfesor;
        #endregion

        #region Propiedades
        public string Matricula
        {
            get
            {
                return matricula + "_2017";
            }
            set
            {
                this.matricula = value;
            }
        }
        /*
         * Una vez que se comentó el atributo se procede a la parte de Propiededad Auto Implementada
         */
         public Materia Materia { set; get; }
        // El compilador se encarga de agrega el atributo privado


        #endregion

        #region Métodos
        public string Checar()
        {
            DateTime horaActual = DateTime.Now;
            //Se guarda registro en la BD
            string respuesta = $"Hora de registro {horaActual}";
            return respuesta;
        }

        public void AsignarMateria(Materia materia)
        {
            Materia = materia;
        }
        #endregion

        #region Contructor
        public Profesor()
        {
            this.Matricula = "_2017";
            this.Activo = true;
        }
        #endregion

    }
}
