using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302
{
    public class TipoCelular
    {
        String[] celular = { "Samsung", "Motorola","Sony","LG","Microsoft" };

        public String Celular(int num)
        {
            return celular[num];
        }
    }
}
