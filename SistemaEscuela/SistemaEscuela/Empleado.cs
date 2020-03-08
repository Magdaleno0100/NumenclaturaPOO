using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscuela
{
    public enum FrecuenciaPago
    {
        Quincemal,
        Mensual,
        Bimestral
    }
    /*
     Clase Parametrizada o genérica
         */
    public class Empleado<Tipo>
    {
        #region Atributos
        private Tipo id;
        private string nombre;
        private bool activo;
        private byte edad;
        private string nacionalidad;
        private decimal pago;
        #endregion

        #region Propiedades
        public Tipo Id
        {
            get;set;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public bool Activo { set; get; }
        public byte Edad { set; get; }
        public string Nacimiento { set; get; }
        public decimal Pago { get; }
        #endregion

        #region Métodos
        public void CalcularPago()
        {

        }
        #endregion

        #region Constructor
        public Empleado()
        {
            this.Activo = true;
        }
        #endregion
    }
}
