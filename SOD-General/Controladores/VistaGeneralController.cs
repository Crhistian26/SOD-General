using Modelos.Usuarios_Empleados;
using SOD_General;
using SOD_General.Recursos_Humanos.Empleados;
using SOD_General.Taller.Control_calidad;
using SOD_General.Taller.Registro_peticiones;
using SOD_General.Vistas.Recursos_Humanos.Motivos;
using SOD_General.Vistas.Recursos_Humanos.Registros;
using SOD_General.Vistas.Taller.Controles_de_Equipo;
using SOD_General.Vistas.Taller.Registrar_Cotizacion;
using SOD_General.Vistas.Taller.Registro_peticiones;
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
    /// <summary>
    /// clase encargada de filtrar y llenar los comboBox segun las autorizaciones
    /// </summary>
    public class VistaGeneralController
    {
        /// <summary>
        /// atributo para almacenar la instancia de AppVisGen atraves 
        /// de un parametro en el constructor de la clase
        /// </summary>
        AppVistaGeneral vista;


        public VistaGeneralController(AppVistaGeneral vista)
        {
            this.vista = vista;
        }

        public void Comprobar_Autorizaciones()
        {
            string depart = vista.Departamento;
            switch (depart)
            {
                case "Recepcion taller":
                    ToolStripMenuItem elemento;
                    List<ToolStripMenuItem> elementos = Recepcion_Taller();
                    elemento = LlenarMenu(elementos);

                    vista.cR_MenuStrip1.Items.Add(elemento);
                    break;


                //Frandy
                case "Reparaciones taller":
                    ToolStripMenuItem elemento2;
                    List<ToolStripMenuItem> elementos22 = Reparacion_Taller();
                    elemento2 = LlenarMenu(elementos22);

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

        //El apartado de taller, en caso que sea reparacion taller se ejecutara este.
        public List<ToolStripMenuItem> Reparacion_Taller()
        {
            //La lista que retornara
            List<ToolStripMenuItem> lista = new List<ToolStripMenuItem>();


            //El elemento de el menustrip abrira el ver peticiones.- Framdy
            ToolStripMenuItem Controles = new ToolStripMenuItem();
            Controles.Text = "Cotizaciones";
            Controles.Click += Peticiones1_Click;
            lista.Add(Controles);

            //Frandy
            ToolStripMenuItem Controles3 = new ToolStripMenuItem();
            Controles3.Text = "Ver Cotizaciones";
            Controles3.Click += Peticiones4_Click;
            lista.Add(Controles3);

            //Frandy
            ToolStripMenuItem Controles1 = new ToolStripMenuItem();
            Controles1.Text = "Ver Controles de calidad";
            Controles1.Click += Peticiones2_Click;
            lista.Add(Controles1);

            //Frandy
            ToolStripMenuItem Controles2 = new ToolStripMenuItem();
            Controles2.Text = "Confirmar controles";
            Controles2.Click += Peticiones3_Click;
            lista.Add(Controles2);

           



            return lista;
        }

        public List<ToolStripMenuItem> Recursos_Humanos()
        {
            //La lista que retornara
            List<ToolStripMenuItem> lista = new List<ToolStripMenuItem>();

            ToolStripMenuItem registrosP = new ToolStripMenuItem();
            registrosP.Text = "Registro de permisos";
            registrosP.Click += RegistrosP_Click;
            lista.Add(registrosP);

            ToolStripMenuItem registrosA = new ToolStripMenuItem();
            registrosA.Text = "Registro de asistencias";
            registrosA.Click += RegistrosA_Click;
            lista.Add(registrosA);

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

        private void Agregar_Click(object sender, EventArgs e)
        {
            vista.AbrirFormulario(new Agregar_Permiso());
        }

        private void AgregarA_Click(object sender, EventArgs e)
        {
            vista.AbrirFormulario(new Agregar_Asistencias());
        }

        private void RegistrosA_Click(object sender, EventArgs e)
        {
            vista.AbrirFormulario(new Registros_GeneralesAsistencias());
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

        private void RegistrosP_Click(object sender, EventArgs e)
        {
            vista.AbrirFormulario(new Registros_GeneralesPermisos());
        }

        //funciones del area de reparacion - Frandy
        private void Peticiones1_Click(object sender, EventArgs e)
        {
            vista.AbrirFormulario(new AgregarCotizaciones());
        }

        private void Peticiones2_Click(object sender, EventArgs e)
        {
            vista.AbrirFormulario(new VisualizarControles());
        }

        private void Peticiones3_Click(object sender, EventArgs e)
        {
            vista.AbrirFormulario(new VisualizarEquiposReparados());
        }

        private void Peticiones4_Click(object sender, EventArgs e)
        {
            vista.AbrirFormulario(new VisualizarCotizacion());
        }
    }
}
