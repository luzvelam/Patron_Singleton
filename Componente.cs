using System.Collections.Generic;

namespace CompositeComputadora
{
    public abstract class Componente
    {
        protected string nombre;

        public Componente(string nombre)
        {
            this.nombre = nombre;
        }

        public abstract int ObtenerCosto();
        public abstract string ObtenerDescripcion();

        public virtual void AgregarHijo(Componente c)
        {
            throw new NotImplementedException();
        }
    }
}