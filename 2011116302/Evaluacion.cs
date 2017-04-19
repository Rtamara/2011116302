using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302
{
    public class Evaluacion
    {
        int n;
        int IdTrabajador;
        int IdTipoEvaluacion;
        int IdCelular;
        int IdCentroAtencion;
        int IdEstado;
        int IdCliente;

        public Evaluacion() { }
        public Evaluacion(int _n, int _IdTrabajador, int _IdTipoEvaluacion, int _IdCelular, int _IdCentroAtencion, int _IdEstado, int _IdCliente)
        {
            n = _n;
            IdTrabajador = _IdTrabajador;
            IdTipoEvaluacion = _IdTipoEvaluacion;
            IdCelular = _IdCelular;
            IdCentroAtencion=_IdCentroAtencion;
            IdEstado = _IdEstado;
            IdCliente = _IdCliente;
        }
        private String getEvaluacion(int tipEval)
        {
            String lista;
            lista = "msg";
            return lista;
        }
        public void MostrarEvaluacion()
        {
            Cliente cliente=new Cliente();
            Trabajador trabajador = new Trabajador();
            TipoEvaluación tipoEvaluacion = new TipoEvaluación();
            TipoCelular celular = new TipoCelular();
            CentroAtencion centroAtencion = new CentroAtencion();
            EstadoEvaluacion estado = new EstadoEvaluacion();

            String linea = String.Concat("Id: ", n,"\n", "Trabajador: ", trabajador.DatoTabajador(IdTrabajador),"\n","Evaluacion: ", tipoEvaluacion.DatoTipoEvaluacion(IdTipoEvaluacion),"\n", "Celular: ", celular.Celular(IdCelular),"\n", "Centro Atencion: ", centroAtencion.DatoCentroAtencón(IdCentroAtencion),"\n", "Estado :", estado.Estado(IdEstado),"\n", "Cliente: ", cliente.DatoCliente(IdCliente));

            Console.WriteLine(linea);
            Console.WriteLine();
        }
        public void Agregar(int _n, int _IdTrabajador, int _IdTipoEvaluacion, int _IdCelular, int _IdCentroAtencion, int _IdEstado, int _IdCliente)
        {
            n = _n;
            IdTrabajador = _IdTrabajador;
            IdTipoEvaluacion = _IdTipoEvaluacion;
            IdCelular = _IdCelular;
            IdCentroAtencion = _IdCentroAtencion;
            IdEstado = _IdEstado;
            IdCliente = _IdCliente;
        }
    }
}
