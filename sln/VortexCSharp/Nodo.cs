using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vortex.Nodos
{
    public interface Nodo
    {
        void conectarCon(Nodo un_nodo);
        void recibirMensaje(Object un_mensaje);
    }
}
