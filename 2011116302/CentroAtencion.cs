using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302
{
    public class CentroAtencion
    {
        String[] centroAtencion = { "C.A. Jockey Plaza", "C.A. Real Plaza", "C.A. Begoneas", "C.A. MegaPlaza" };

        public String DatoCentroAtencón(int num)
        {
            return centroAtencion[num];
        }
    }
}
