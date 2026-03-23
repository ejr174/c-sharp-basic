using System;
using System.Collections.Generic;
using System.Text;

namespace Enumerados_Enum
{
    internal class ClaseGenerica<T>
    {
        private T elObjeto;

        public ClaseGenerica(T elObjeto)
        {
            this.elObjeto = elObjeto;
        }

        public T getObjeto()
        {
            return elObjeto;
        }
    }
}
