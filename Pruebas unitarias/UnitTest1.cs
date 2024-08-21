using Controladores;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelos;
using Modelos.AsistenciasYPermisos;
using Modelos.Control_de_usuarios;
using SOD_General;
using SOD_General.Controladores;
using SOD_General.Vistas.Recursos_Humanos.Registros;
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
        static List<Model_Operations> model_Operations = new List<Model_Operations>

            {
                new Model_Operations(1,"Redaccion","ver"),
                new Model_Operations(2,"Redaccion","agregar"),
                new Model_Operations(3,"Asistencias", "Ver asistencias")
            };


        static Model_Role role = new Model_Role(1, "Redactor", model_Operations);

        static Model_User user = new Model_User(1, 2, role, "Juanito", "123456");


        static AppVistaGeneral view = new AppVistaGeneral(user);

        static ControlOperaciones control = new ControlOperaciones(user ,view);

        [TestMethod]
        public void MenustripTest()
        {
            List<ToolStripMenuItem> items = new List<ToolStripMenuItem>();
            control.AddItemsInMenustrip();
            foreach (ToolStripMenuItem item in items)
            {
                MessageBox.Show(item.Text);
            }
        }
        [TestMethod]
        public void TestUserConfirm()
        {
            bool h = user.Confirm_Operation("asd");
            Assert.IsFalse(h);
        }
        [TestMethod]
        public void TestDatetimeSubstrac()
        {
            TimeSpan h = new Record_Permission(
                1,
                "Fulanito",
                "Juan",
                "a",
                new DateTime(2024, 8, 21, 8, 30, 0),
                new DateTime(2024, 8, 21, 10, 30, 0),
                new TimeSpan(12,0,0),
                new TimeSpan(1,0,0)
                ).Get_Hours_Ausent();

            TimeSpan f = new Record_Permission(
                1,
                "Fulanito",
                "Juan",
                "a",
                new DateTime(2024, 8, 21, 8, 30, 0),
                new DateTime(2024, 8, 24, 9, 30, 0),
                new TimeSpan(12, 0, 0),
                new TimeSpan(1, 0, 0)
                ).Get_Hours_Ausent();
        }
    }
}
