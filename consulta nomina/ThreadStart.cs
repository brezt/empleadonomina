using System;

namespace consulta_nomina
{
    internal class ThreadStart
    {
        private Action buscar_Imagen;

        public ThreadStart(Action buscar_Imagen)
        {
            this.buscar_Imagen = buscar_Imagen;
        }
    }
}