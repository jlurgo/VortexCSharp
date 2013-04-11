using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vortex.Nodos
{
    public class NodoPortal:Nodo
    {
        private Nodo receptor;
        private Action<object> callback;

        public NodoPortal()
        {
            callback = callbackNulo;
        }

        private void callbackNulo(object un_mensaje)
        {
        }

        public void conectarCon(Nodo un_nodo)
        {
            receptor = un_nodo;
        }

        public void recibirMensaje(Object un_mensaje)
        {
            callback.Invoke(un_mensaje);
        }

        public void pedirMensajes(Action<object> un_callback)
        {
            this.callback = un_callback;
        }

        public void enviarMensaje(object mensaje)
        {
            receptor.recibirMensaje(mensaje);
        }
    }
}
