using Modelos.Usuarios_Empleados;
using Modelos.Usuarios_Empleados.Control_de_usuario;
using SOD_General;
using SOD_General.Recursos_Humanos.Empleados;
using SOD_General.Vistas.Pruebas;
using SOD_General.Vistas.Recursos_Humanos.Motivos;
using SOD_General.Vistas.Recursos_Humanos.Registros;
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
    public class ControlOperaciones
    {
       
        AppVistaGeneral vista;
        List<C_Operation> operations;
        
        public ControlOperaciones(AppVistaGeneral vista)
        {
            this.vista = vista;
            this.operations = vista.operations;
        }

        //No hagas caso a esto de aca esto solo fue para ver como utilizar los bucles a mi favor.
        public void ImprimirOperaciones()
        {
            var Seleccion = operations.GroupBy(a => a.Module_Name).Select(a => a).ToList();

            foreach (var operation in Seleccion)
            {
                string Modulo = operation.Key;
                string Operaciones = "";
                foreach (var ope2 in operation)
                {
                    Operaciones += $"\n{ope2._Operation}";
                }
                MessageBox.Show(Modulo + Operaciones);
            }
        }


        public void Agregar_Items()
        {
            var Seleccion = operations.GroupBy(a => a.Module_Name).Select(a => a).ToList();

            foreach (var operation in Seleccion)
            {
                ToolStripMenuItem headitem = new ToolStripMenuItem();
                headitem.Text = operation.Key;

                foreach (var ope2 in operation)
                {
                    if(OperacionEnMenuStrip(ope2))
                    {
                        ToolStripMenuItem item = new ToolStripMenuItem();
                        item.Text = ope2._Operation;
                        EventHandler evento = Eventos(item);
                        if (evento != null)
                        {
                            item.Click += evento;

                        }
                        headitem.DropDownItems.Add(item);
                    }
                }
                vista.cR_MenuStrip1.Items.Add(headitem);
            }
        }

        public bool BuscarAutorizacion(int IdAutorizacion)
        {
            var ope = from a in operations
                              where a.Id == IdAutorizacion
                              select a;

            if( ope.Count() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool OperacionEnMenuStrip(C_Operation operacion)
        {
            int? id = operacion.Id;

            if(id != null)
            {
                //Id de la operacion Agregar Empleados
                if(id == 6)
                {
                    return false;
                }

                if(id == 7)
                {
                    return false;
                }
            }

            return true;
        }
        public EventHandler Eventos(ToolStripMenuItem item)
        {
            if (item.Text == "Control de empleados")
            {
                EventHandler evento = delegate (object sender, EventArgs e)
                {
                    Empleados ventana = new Empleados(vista);
                    vista.AbrirFormulario(ventana);
                };

                return evento;
            }

            if (item.Text == "Reporte de computadoras")
            {
                EventHandler evento = delegate (object sender, EventArgs e)
                {
                    Computo ventana = new Computo();
                    vista.AbrirFormulario(ventana);
                };

                return evento;
            }


            return null;
        }























        ///El codigo antes del de arriba, lo cambiamos ya que consideramos que el de arriba es mas optimo.


        //public void Comprobar_Autorizaciones()
        //{
        //    string depart = "vista.Departamento";
        //    switch(depart)
        //    {
        //        case "Recepcion taller":
        //            ToolStripMenuItem elemento;
        //            List<ToolStripMenuItem> elementos = Recepcion_Taller();
        //            elemento = LlenarMenu(elementos);

        //            vista.cR_MenuStrip1.Items.Add(elemento);
        //            break;


        //        case "Reparacion taller":
        //            ToolStripMenuItem elemento2 = null;


        //            vista.cR_MenuStrip1.Items.Add(elemento2);
        //            break;


        //        case "Recursos Humanos":
        //            ToolStripMenuItem elemento3;

        //            List<ToolStripMenuItem> elementos3 = Recursos_Humanos();
        //            elemento3 = LlenarMenu(elementos3);

        //            vista.cR_MenuStrip1.Items.Add(elemento3);
        //            break;


        //        case "Ventas":
        //            ToolStripMenuItem elemento4 = null;

        //            elemento = LlenarMenu(null);

        //            vista.cR_MenuStrip1.Items.Add(elemento4);
        //            break;


        //        case "Almacen":
        //            ToolStripMenuItem elemento5 = null;

        //            elemento = LlenarMenu(null);

        //            vista.cR_MenuStrip1.Items.Add(elemento5);
        //            break;
        //    }
        //}

        ////La funcion que me almacena cada uno de los items en uno solo.
        //public ToolStripMenuItem LlenarMenu(List<ToolStripMenuItem> items)
        //{
        //    //El encabezado y la lista de items.
        //    ToolStripMenuItem cabeza = new ToolStripMenuItem("vista.Departamento");

        //    //El bucle que llena el encabezado.
        //    foreach (ToolStripMenuItem item in items)
        //    {
        //        cabeza.DropDownItems.Add(item);
        //    }
        //    //Agregar el encabezado al menustrip.
        //    return cabeza;

        //}

        //El apartado de taller, en caso que sea recepcion taller se ejecutara este.
        //public List<ToolStripMenuItem> Recepcion_Taller()
        //{
        //    //La lista que retornara
        //    List<ToolStripMenuItem> lista = new List<ToolStripMenuItem>();

        //    //El elemento de el menustrip abrira el ver peticiones.
        //    ToolStripMenuItem Peticiones = new ToolStripMenuItem();
        //    Peticiones.Text = "Peticiones";
        //    Peticiones.Click += Peticiones_Click;
        //    lista.Add(Peticiones);


        //    return lista;
        //}

        //public List<ToolStripMenuItem> Recursos_Humanos()
        //{
        //    //La lista que retornara
        //    List<ToolStripMenuItem> lista = new List<ToolStripMenuItem>();

        //    ToolStripMenuItem registrosP = new ToolStripMenuItem();
        //    registrosP.Text = "Registro de permisos";
        //    registrosP.Click += RegistrosP_Click;
        //    lista.Add(registrosP);

        //    ToolStripMenuItem registrosA = new ToolStripMenuItem();
        //    registrosA.Text = "Registro de asistencias";
        //    registrosA.Click += RegistrosA_Click; 
        //    lista.Add(registrosA);

        //    //El elemento de el menustrip abrira el empleados.
        //    ToolStripMenuItem Emp = new ToolStripMenuItem();
        //    Emp.Text = "Empleados";
        //    Emp.Click += Empleados_Click;
        //    lista.Add(Emp);

        //    ToolStripMenuItem motivos = new ToolStripMenuItem();
        //    motivos.Text = "Motivos";
        //    motivos.Click += Motivos_Click; ;
        //    lista.Add(motivos);

        //    return lista;
        //}

        //private void Agregar_Click(object sender, EventArgs e)
        //{
        //    vista.AbrirFormulario(new Agregar_Permiso());
        //}

        //private void AgregarA_Click(object sender, EventArgs e)
        //{
        //    vista.AbrirFormulario(new Agregar_Asistencias());
        //}

        //private void RegistrosA_Click(object sender, EventArgs e)
        //{
        //    vista.AbrirFormulario(new Registros_GeneralesAsistencias());
        //}

        //private void Motivos_Click(object sender, EventArgs e)
        //{
        //    vista.AbrirFormulario(new Visual_Motivos());
        //}


        ////La funcion que tendra el elemento peticiones
        //private void Peticiones_Click(object sender, EventArgs e)
        //{
        //    vista.AbrirFormulario(new VisualizarPeticiones());
        //}

        //private void Empleados_Click(object sender, EventArgs e)
        //{
        //    vista.AbrirFormulario(new Visual_Empleados());
        //}

        //private void RegistrosP_Click(object sender, EventArgs e)
        //{
        //    vista.AbrirFormulario(new Registros_GeneralesPermisos());
        //}


    }
}
