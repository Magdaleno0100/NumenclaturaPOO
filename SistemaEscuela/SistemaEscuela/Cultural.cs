using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscuela
{
    class Cultural :Materia
    {
        public override decimal Evaluar()
        {
            //Evaluar en base a prueba y asistencia
            //Se consulta en la BD
            //Se calcula : ejemplo
            decimal calificacion = 90.0M;
            return calificacion;
        }
    }
}
