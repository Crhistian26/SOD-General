using Modelos.Usuarios_Empleados;
using SOD_General;
using SOD_General.Recursos_Humanos.Empleados;
using SOD_General.Vistas.Recursos_Humanos.Motivos;
using SOD_General.Vistas.Recursos_Humanos.Registros;
using SOD_General.Vistas_Taller.Taller_Recepcion;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controladores
{
    public class VistaGeneralController
    {

        AppVistaGeneral vista;

        public VistaGeneralController(AppVistaGeneral vista)
        {
            this.vista = vista;
        }

        public void Comprobar_Autorizaciones()
        {
            string depart = vista.Departamento;
            switch(depart)
            {
                case "Recepcion taller":
                    ToolStripMenuItem elemento;
                    List<ToolStripMenuItem> elementos = Recepcion_Taller();
                    elemento = LlenarMenu(elementos);

                    vista.cR_MenuStrip1.Items.Add(elemento);
                    break;


                case "Reparacion taller":
                    ToolStripMenuItem elemento2 = null;


                    vista.cR_MenuStrip1.Items.Add(elemento2);
                    break;


                case "Recursos Humanos":
                    ToolStripMenuItem elemento3;

                    List<ToolStripMenuItem> elementos3 = Recursos_Humanos();
                    elemento3 = LlenarMenu(elementos3);

                    vista.cR_MenuStrip1.Items.Add(elemento3);
                    break;


                case "Ventas":
                    ToolStripMenuItem elemento4 = null;

                    elemento = LlenarMenu(null);

                    vista.cR_MenuStrip1.Items.Add(elemento4);
                    break;


                case "Almacen":
                    ToolStripMenuItem elemento5 = null;

                    elemento = LlenarMenu(null);

                    vista.cR_MenuStrip1.Items.Add(elemento5);
                    break;
            }
        }

        //La funcion que me almacena cada uno de los items en uno solo.
        public ToolStripMenuItem LlenarMenu(List<ToolStripMenuItem> items)
        {
            //El encabezado y la lista de items.
            ToolStripMenuItem cabeza = new ToolStripMenuItem(vista.Departamento);

            //El bucle que llena el encabezado.
            foreach (ToolStripMenuItem item in items)
            {
                cabeza.DropDownItems.Add(item);
            }
            //Agregar el encabezado al menustrip.
            return cabeza;

        }

        //El apartado de taller, en caso que sea recepcion taller se ejecutara este.
        public List<ToolStripMenuItem> Recepcion_Taller()
        {
            //La lista que retornara
            List<ToolStripMenuItem> lista = new List<ToolStripMenuItem>();

            //El elemento de el menustrip abrira el ver peticiones.
            ToolStripMenuItem Peticiones = new ToolStripMenuItem();
            Peticiones.Text = "Peticiones";
            Peticiones.Click += Peticiones_Click;
            lista.Add(Peticiones);


            return lista;
        }

        public List<ToolStripMenuItem> Recursos_Humanos()
        {
            //La lista que retornara
            List<ToolStripMenuItem> lista = new List<ToolStripMenuItem>();

            ToolStripMenuItem registros = new ToolStripMenuItem();
            registros.Text = "Registros generales";
            registros.Click += Registros_Click;
            lista.Add(registros);

            //El elemento de el menustrip abrira el empleados.
            ToolStripMenuItem Emp = new ToolStripMenuItem();
            Emp.Text = "Empleados";
            Emp.Click += Empleados_Click;
            lista.Add(Emp);

            ToolStripMenuItem motivos = new ToolStripMenuItem();
            motivos.Text = "Motivos";
            motivos.Click += Motivos_Click; ;
            lista.Add(motivos);

            return lista;
        }

        private void Motivos_Click(object sender, EventArgs e)
        {
            vista.AbrirFormulario(new Visual_Motivos());
        }


        //La funcion que tendra el elemento peticiones
        private void Peticiones_Click(object sender, EventArgs e)
        {
            vista.AbrirFormulario(new VisualizarPeticiones());
        }

        private void Empleados_Click(object sender, EventArgs e)
        {
            vista.AbrirFormulario(new Visual_Empleados());
        }

        private void Registros_Click(object sender, EventArgs e)
        {
            vista.AbrirFormulario(new Registros_Generales());
        }


    }
}
