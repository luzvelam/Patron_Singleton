using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CompositeComputadora
{
    public class Archivo : Componente
    {
        private int costo;

        public Archivo(string nombre, int costo) : base(nombre)
        {
            this.costo = costo;
        }

        public override int ObtenerCosto()
        {
            return costo;
        }

        public override string ObtenerDescripcion()
        {
            return nombre + " - $" + costo;
        }
    }
}