using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302
{
    public class TipoEvaluación
    {
        String[] tipoEvaluacion = { "Renovación de Contrato", "Portabilidad", "Línea Nueva" };

        public String DatoTipoEvaluacion(int num)
        {
            return tipoEvaluacion[num];
        }
    }
}
