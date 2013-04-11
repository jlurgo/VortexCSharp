using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vortex.Nodos
{
    public class NodoRouter:Nodo
    {
        private List<Nodo> receptores;
        public NodoRouter()
        {
            receptores = new List<Nodo>();
        }
        public void conectarCon(Nodo un_nodo)
        {
            receptores.Add(un_nodo);
        }

        public void recibirMensaje(Object un_mensaje)
        {
            receptores.ForEach(r => r.recibirMensaje(un_mensaje));
        }
    }
}
