using Modelos.Control_de_usuarios;
using SOD_General;
using SOD_General.Recursos_Humanos.Empleados;
using SOD_General.Taller.Control_calidad;
using SOD_General.Taller.Registro_peticiones;
using SOD_General.Vistas.Control_de_usuarios.Operaciones;
using SOD_General.Vistas.Control_de_usuarios.Roles;
using SOD_General.Vistas.Control_de_usuarios.Usuarios;
using SOD_General.Vistas.Recursos_Humanos.Exportar;
using SOD_General.Vistas.Recursos_Humanos.Motivos;
using SOD_General.Vistas.Recursos_Humanos.Registros;
using SOD_General.Vistas.Taller.Clientes;
using SOD_General.Vistas.Taller.Control_calidad;
using SOD_General.Vistas.Taller.Equipos;
using SOD_General.Vistas.Taller.Pruebadiseño;
using SOD_General.Vistas.Taller.Registro_peticiones;
using SOD_General.Vistas_Taller.Taller_Recepcion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Controladores
{
    public class ControlOperaciones
    {
        #region Nuevo filtro de operaciones

        public Model_User User;
        public Model_Role Role;
        public AppVistaGeneral _view;
        public Dictionary<(string, string), EventHandler> OperationsEvents;

        public ControlOperaciones()
        {
            this._view = Application.OpenForms.OfType<AppVistaGeneral>().First();
            this.User = _view.user;
            this.Role = User._Role;
            this.OperationsEvents = DictionaryData();
        }

        public ControlOperaciones(Model_User User, AppVistaGeneral view)
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
        public Dictionary<(string, string), EventHandler> DictionaryData()
        {
            
            return
                new Dictionary<(string, string), EventHandler>
                {
                    {
                        (("Empleados", "Ver empleados")),  (object sender, EventArgs e) =>{Visual_Empleados window = new Visual_Empleados(); _view.OpenForm(window); }

                    },
                    {
                        ("Asistencias","Ver asistencias"),
                        (object sender, EventArgs e) =>
                        {
                            Registros_GeneralesAsistencias window = new Registros_GeneralesAsistencias();
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
                            _view.OpenForm(window);
                        }
                    },
                    {
                        ("Permisos","Ver motivos"),
                        (object sender, EventArgs e) =>
                        {
                            Visual_Motivos window = new Visual_Motivos();
                            _view.OpenForm(window);
                        }
                    },

                    {
                        ("Clientes","Añadir Clientes"),
                        (object sender, EventArgs e) =>
                        {
                            AddLocations window = new AddLocations();
                            _view.OpenForm(window);
                        }
                    },

                    {
                        ("Clientes","Ver Clientes"),
                        (object sender, EventArgs e) =>
                        {
                            VisualizarClientes window = new VisualizarClientes();
                            _view.OpenForm(window);
                        }
                    },
                    //{
                    //    ("Equipos","Añadir Equipo"),
                    //    (object sender, EventArgs e) =>
                    //    {
                    //        AgregarTipoEquipo window = new AgregarTipoEquipo();
                    //        _view.OpenForm(window);
                    //    }
                    //},

                      {
                        ("Equipos","Ver Equipos"),
                        (object sender, EventArgs e) =>
                        {
                            VisualizacionEquipo window = new VisualizacionEquipo();
                            _view.OpenForm(window);
                        }
                    },

                    //  {
                    //    ("Equipos","Añadir Marcas"),
                    //    (object sender, EventArgs e) =>
                    //    {
                    //        AgregarMarcas window = new AgregarMarcas();
                    //        _view.OpenForm(window);
                    //    }
                    //},

                      {
                        ("Equipos","Ver Marcas"),
                        (object sender, EventArgs e) =>
                        {
                            VisualizarMarcas window = new VisualizarMarcas();
                            _view.OpenForm(window);
                        }
                    },

                      {
                        ("Controles de calidad","Ver Controles"),
                        (object sender, EventArgs e) =>
                        {
                            VisualizarControles window = new VisualizarControles();
                            _view.OpenForm(window);
                        }
                    },
                      {
                        ("Controles de calidad","Enlace Equipo Control"),
                        (object sender, EventArgs e) =>
                        {
                            EnlaceControlEquipo window = new EnlaceControlEquipo();
                            _view.OpenForm(window);
                        }
                    },
                      {
                        ("Recepcion","Orden de entrada"),
                        (object sender, EventArgs e) =>
                        {
                            AgregarPeticiones window = new AgregarPeticiones();
                            _view.OpenForm(window);
                        }
                    },

                    {
                        ("Recepcion","Agregar Entradas"),
                        (object sender, EventArgs e) =>
                        {
                            RegistrarSolicitudEquipo window = new RegistrarSolicitudEquipo(0);
                            _view.OpenForm(window);
                        }
                    },

                     {
                        ("Recepcion","Ver Ordenes de entrada"),
                        (object sender, EventArgs e) =>
                        {
                            VisualizarPeticiones window = new VisualizarPeticiones();
                            _view.OpenForm(window);
                        }
                    }
                };



        }

        /// <summary>
        /// Esta funcion es la encargada de llenar el Menustrip de vista general con cada uno de sus items.
        /// </summary>
        public void AddItemsInMenustrip()
        {
            List<Model_Operations> operations = this.Role._Operations;

            if (this.Role.Name == "Administrador")
            {
                List<Model_Operations> data = new List<Model_Operations>();
                foreach (var ope in DictionaryData())
                {
                    data.Add(
                        new Model_Operations(0, ope.Key.Item1, ope.Key.Item2)
                        );
                }
                operations = data;
            }

            var GroupOperations = operations.GroupBy(a => a._Module).Select(a => a).ToList();

            foreach (var operations1 in GroupOperations)
            {
                ToolStripMenuItem head_item = new ToolStripMenuItem();
                head_item.Text = operations1.Key;

                foreach (Model_Operations operation in operations1)
                {
                    EventHandler _event = OperationsEvents.Where(a => a.Key == (operation._Module, operation._Operation)).Select(a => a.Value).FirstOrDefault();

                    if (_event == null)
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
                if (head_item.DropDownItems.Count <= 0)
                {
                    continue;
                }
                else
                {
                    _view.cR_MenuStrip1.Items.Add(head_item);
                }
            }
            
            ToolStripMenuItem login_back = new ToolStripMenuItem();
            login_back.Text = "Volver al login";
            login_back.Click += Login_Click;
            _view.cR_MenuStrip1.Items.Add(login_back);
            _view.cR_MenuStrip1.ForeColor = System.Drawing.Color.White;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


        #endregion
    }
}
