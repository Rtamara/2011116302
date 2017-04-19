using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302
{
    class Program
    {
        static void Main(string[] args)
        {
            var evaluacion = new Evaluacion();
            List<Evaluacion> _listaEvaluacion=new List<Evaluacion>();

            evaluacion.Agregar(1,1,0,1,1,0,1);
            evaluacion.MostrarEvaluacion();

            evaluacion.Agregar(2,1,1,1,1,0,1);
            evaluacion.MostrarEvaluacion();

            evaluacion.Agregar(3,1,2,1,1,0,1);
            evaluacion.MostrarEvaluacion();

            evaluacion.Agregar(4,1,1,1,1,1,1);
            evaluacion.MostrarEvaluacion();

            evaluacion.Agregar(5,1,2,1,1,1,1);
            evaluacion.MostrarEvaluacion();

            Console.ReadKey();


        }
    }
}
