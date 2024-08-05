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
        public ControlOperaciones(Model_User User,AppVistaGeneral view)
        {
            this.User = User;
            this.Role = User._Role;
            this._view = view;
        }

        #region agregar eventos
        /*
                if(operation._Module == "Modulo a verificar")
                {
                    switch (operation._Operation)
                    {
                        case ("Operacion"):
                            _Event = (object sender, EventArgs e) =>
                            {
                                //tu evento
                            };
                            return _Event;
                    }
                }
         */
        #endregion
        /// <summary>
        /// Este metodo se encarga de retornar un evento dependiendo de la operacion a buscar,
        /// este se utiliza en la parte de agregar los elementos al menu strip de AppVistaGeneral.
        /// </summary>
        /// <param name="name_operation"></param>
        /// <returns>Retorna el evento asignado a esa operacion, en caso de no tener uno te retornara un null.</returns>
        public EventHandler GetEventsInMenustrip(string name_operation)
        {
            
            EventHandler _Event = null;

            List<Model_Operations> operations = this.Role._Operations;

            Model_Operations operation = operations.Where(a => a._Operation == name_operation).Select(a => a).First();

            if (operation != null)
            {
                if(operation._Module == "Empleados")
                {
                    switch (operation._Operation)
                    {
                        case ("Ver empleados"):
                            _Event = (object sender, EventArgs e) =>
                            {
                                Visual_Empleados window = new Visual_Empleados(_view);
                                _view.OpenForm(window);
                            };
                            return _Event;
                    }
                }

                if (operation._Module == "Asistencias")
                {
                    switch (operation._Operation)
                    {
                        case ("Ver asistencias"):
                            _Event = (object sender, EventArgs e) =>
                            {
                                Registros_GeneralesAsistencias window = new Registros_GeneralesAsistencias(this.User);
                                _view.OpenForm(window);
                            };
                            return _Event;
                    }
                }

                if (operation._Module == "Permisos")
                {
                    switch (operation._Operation)
                    {
                        case ("Ver permisos"):
                            _Event = (object sender, EventArgs e) =>
                            {
                                Registros_GeneralesPermisos window = new Registros_GeneralesPermisos(_view);
                                _view.OpenForm(window);
                            };
                            return _Event;

                    }
                }

                if (operation._Module == "Reportes de RRHH")
                {
                    switch (operation._Operation)
                    {
                        case ("Exportar reporte"):
                            _Event = (object sender, EventArgs e) =>
                            {
                                ExportarReportesRRHH window = new ExportarReportesRRHH();
                                _view.OpenForm(_view);
                            };
                            return _Event;

                    }
                }

            }
            else
            {
                _Event = null;
            }

            return _Event;

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
                    EventHandler _event = GetEventsInMenustrip(operation._Operation);

                    if(_event == null )
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
