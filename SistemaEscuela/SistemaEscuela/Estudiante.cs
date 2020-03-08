using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscuela
{
    class Estudiante
    {
        #region Atributos
        #endregion

        #region Propiedades Auto Implementadas
        public bool Estatus { set; get; }

        public string Nombre { set; get; }
        public string Grado { get; set; }
        public string Grupo { get; set; }
        #endregion

        #region Métodos
        public string Registrar()
        {
            //Se debe de realizar un registro en la BD
            string respuesta = "El estudiante fue creado correctamente";
            return respuesta;
        }

        public string DarDeBaja()
        {
            this.Estatus = false;
            //Editar en la BD 
            // EditarMetodoEnBd()
            string respuesta = "Se dio de baja el elemento";
            return respuesta;
        }

        //Ejemplo de Sobre Carga en el método DarDeBaja
        public string DarDeBaja(string motivo)
        {
            this.Estatus = false;
            //Editar en la BD 
            // EditarMetodoEnBd() agregando motivo
            string respuesta = "Se dio de baja el elemento";
            return respuesta;
        }

        public void DarDeBaja(string motivo, string pwd, string cveUsuario)
        {
            this.Estatus = false;
            //Editar en la BD 
            // Verficar Usuario VerfivicarUsuario(cveUsuario, pwd)
            // dar de baja
        }

        #endregion

        #region Contructor
        public Estudiante(string nombre, string grado, string grupo)
        {
            Nombre = nombre;
            Grado = grado;
            Grupo = grupo;
        }

        //Sobre carga de Constructor
        public Estudiante(string nombre)
        {
            Nombre = nombre;
        }

        #endregion
    }
}
