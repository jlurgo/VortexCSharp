using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vortex.Nodos;

namespace VortexCSharpTest
{
    [TestClass]
    public class TestComunicacion
    {
        [TestMethod]
        public void Cuando_envio_un_mensaje_por_un_portal_conectado_a_un_router_deberian_recibirlo_los_otros_portales_conectados()
        {

            var portal_1 = new NodoPortal();
            var portal_2 = new NodoPortal();
            var portal_3 = new NodoPortal();

            var router = new NodoRouter();

            portal_1.conectarCon(router);
            router.conectarCon(portal_2);
            router.conectarCon(portal_3);

            var mensaje_recibido_en_portal_2 = false;
            portal_2.pedirMensajes(m => mensaje_recibido_en_portal_2 = true);

            var mensaje_recibido_en_portal_3 = false;
            portal_3.pedirMensajes(m => mensaje_recibido_en_portal_3 = true);

            portal_1.enviarMensaje(new { tipoDeMensaje = "prueba"});

            Assert.IsTrue(mensaje_recibido_en_portal_2);
            Assert.IsTrue(mensaje_recibido_en_portal_3);

        }
    }
}
