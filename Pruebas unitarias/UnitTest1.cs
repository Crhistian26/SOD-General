using Controladores;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelos;
using Modelos.Control_de_usuarios;
using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Pruebas_unitarias
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {

            List<Model_Operations> model_Operations = new List<Model_Operations>
            {
                new Model_Operations(1,"Redaccion","ver"),
                new Model_Operations(2,"Redaccion","agregar"),
                new Model_Operations(3,"Empleados", "Ver asistencias")
            };

            Model_Role role = new Model_Role(1, "Redactor", model_Operations);

            Model_User user = new Model_User(1, 2, role, "Juanito", "123456");

            ControlOperaciones control = new ControlOperaciones(user);

            EventHandler e = control.GetEvents("Ver asistencias");

            Assert.IsNotNull(e);
        }
    }
}
