using Modelos.Control_de_usuarios;
using Modelos.Usuarios_Empleados.Control_de_usuario;
using SOD_General;
using SOD_General.Recursos_Humanos.Empleados;
using SOD_General.Taller.Registro_peticiones;
using SOD_General.Vistas.Pruebas;
using SOD_General.Vistas.Recursos_Humanos.Exportar;
using SOD_General.Vistas.Recursos_Humanos.Registros;
using SOD_General.Vistas.Taller.Clientes;
using SOD_General.Vistas.Taller.Controles_de_Equipo;
using SOD_General.Vistas.Taller.Registrar_Cotizacion;
using SOD_General.Vistas.Taller.Registrar_entrada;
using SOD_General.Vistas.Taller.Registro_peticiones;
using SOD_General.Vistas_Taller.Taller_Recepcion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using System.Windows.Forms;

namespace Controladores
{
    public class ControlOperaciones
    {
        #region Nuevo filtro de operaciones

        public Model_User User;
        public Model_Role Role;
        public AppVistaGeneral _view;
        public Dictionary<(string,string), EventHandler> OperationsEvents;

        public ControlOperaciones(Model_User User,AppVistaGeneral view)
        {
            this.User = User;
            this.Role = User._Role;
            this._view = view;
            this.OperationsEvents = DictionaryData();
        }

        #region agregar eventos nuevos

        #endregion


        /// <summary>
        /// Este metodo se encarga de llenar el diccionario inicial con cada una de las operaciones existentes en el sistema.
        /// </summary>
        /// <returns>Se encarga de regresar un diccionario, la llave es (Modulo,Operacion) y su valor es el evento.<returns>
        public Dictionary<(string,string), EventHandler> DictionaryData()
        {
            return
                new Dictionary<(string, string), EventHandler>
                {
                    {
                        (("Empleados", "Ver empleados")),
                        (object sender, EventArgs e) =>
                        {
                            Visual_Empleados window = new Visual_Empleados(_view);
                            _view.OpenForm(window);
                        }
                    },
                    {
                        ("Asistencias","Ver asistencias"),
                        (object sender, EventArgs e) =>
                        {
                            Registros_GeneralesAsistencias window = new Registros_GeneralesAsistencias(User);
                            _view.OpenForm(window);
                        }
                    },
                    {
                        ("Permisos","Ver permisos"),
                        (object sender, EventArgs e) =>
                        {
                            Registros_GeneralesPermisos window = new Registros_GeneralesPermisos(_view);
                            _view.OpenForm(window);
                        }
                    },
                    {
                        ("Reportes de RRHH","Exportar reporte"),
                        (object sender, EventArgs e) =>
                        {
                            ExportarReportesRRHH window = new ExportarReportesRRHH();
                            _view.OpenForm(_view);
                        }
                    },
                };



        }

        /// <summary>
        /// Esta funcion es la encargada de llenar el Menustrip de vista general con cada uno de sus items.
        /// </summary>
        public void AddItemsInMenustrip()
        {
            List<Model_Operations> operations = this.Role._Operations;

            var GroupOperations = operations.GroupBy(a => a._Module).Select(a => a).ToList();  

            foreach (var operations1 in GroupOperations)
            {
                ToolStripMenuItem head_item = new ToolStripMenuItem();
                head_item.Text = operations1.Key;

                foreach (Model_Operations operation in operations1)
                {
                    EventHandler _event = OperationsEvents.Where(a => a.Key == (operation._Module, operation._Operation)).Select(a => a.Value).FirstOrDefault();

                    if(_event == null)
                    {
                        continue;
                    }
                    else
                    {
                        ToolStripMenuItem item = new ToolStripMenuItem();
                        item.Text = operation._Operation;
                        item.Click += _event;
                        head_item.DropDownItems.Add(item);
                    }
                }

                if(head_item.DropDownItems.Count <= 0)
                {
                    continue;
                }
                else
                {
                    _view.cR_MenuStrip1.Items.Add(head_item);
                }
                
            }

        }

     
        #endregion
    }
}
