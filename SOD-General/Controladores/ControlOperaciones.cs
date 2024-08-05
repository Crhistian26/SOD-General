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
        #region Anterior filtro de operaciones

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

        //Esta es la funcion que se encarga de agregar los items al menustrip.
        public void Agregar_Items()
        {
            /*
            Esta es la lista de agrupaciones por modulo.
            Por ejemplo: tenemos Empleados(agregar,editar, ver) y Permisos(ver)
            En lugar de verse todo junto(agregar,editar,ver y ver)     
            Me crea un objeto que contenga cada uno de sus elementos
            Pasamos de (agregar,editar,ver y ver) a (Empleados,Permisos)
             */
            var Seleccion = operations.GroupBy(a => a.Module_Name).Select(a => a).ToList();


            //Este foreach me recorre las listas anteriores (Empleados,Permisos).
            foreach (var operation in Seleccion)
            {
                //Me crea el encabezado.
                ToolStripMenuItem headitem = new ToolStripMenuItem();
                //le pone el nombre del modulo. Ej: Empleados
                headitem.Text = operation.Key;

                //almacena el modulo actual
                string selec = headitem.Text;

                /*
                Me recorre el elemento de operation que es Empleados
                Recordemos que esto no es una lista comun (agregar,editar,ver y ver).
                Sino que la lista nueva (Empleados,Permisos) es basicamente una lista para las listas
                Osea Empleados contiene (agregar,editar y ver) y cuando este pase por Permisos tendra (ver)
                */
                foreach (var ope2 in operation)
                {
                    //Funcion encargada de filtrar si la operacion estara o no en el menu strip
                    if (OperacionEnMenuStrip(selec, ope2))
                    {
                        //El item del menustrip
                        ToolStripMenuItem item = new ToolStripMenuItem();
                        //El nombre que sera la misma operacion.
                        item.Text = ope2._Operation;
                        //El evento que lo ubicara en la funcion eventos.
                        EventHandler evento = Eventos(selec, ope2);
                        //En caso que tenga evento se le agregara el mismo al darle click al item
                        if (evento != null)
                        {
                            item.Click += evento;
                        }
                        //Se agrega al encabezado.
                        headitem.DropDownItems.Add(item);
                    }
                }
                //Siempre y cuando tenga objetos dentro del mismo el encabezado se agregara.
                if (headitem.DropDownItems != null)
                {
                    //Se agrega el encabezado con todos sus items al menustrip
                    vista.cR_MenuStrip1.Items.Add(headitem);
                }
            }
        }

        //Se encarga crear un booleano con la informacion de la operacion
        public bool BuscarAutorizacion(string Operation_Name)
        {
            //Se encarga de buscar la operacion por su ID entre la lista de operaciones.
            var ope = from a in operations
                      where a._Operation == Operation_Name
                      select a;

            //En caso de encontrar alguna similitud es verdadero.
            if (ope.Count() != 0)
            {
                return true;
            }
            //En caso de no encontrala es falso.
            else
            {
                return false;
            }
        }

        //Esta es la lista negra de las operaciones
        //Te devuelve un bool dependiendo de su estancia en la lista
        public bool OperacionEnMenuStrip(string selecc, C_Operation operacion)
        {
            //booleano que se retornara al final para ver el resultado
            bool a = true;

            //para hacer la validacion de la lista negra segun por modulo
            //El id de la operacion.
            string id = operacion._Operation;
            if (selecc == "Empleados")
            {
                //En caso de tener id la operacion pasara a la ejecucion de los if
                if (id != null)
                {
                    //Si esta es igual a 2 el id de agregar empleados, devolvera false para decir que este no ira al menustrip.
                    if (id == "Agregar empleados")
                    {
                        a = false;
                    }
                    //Lo mismo
                    if (id == "Editar empleados")
                    {
                        a = false;
                    }
                }
            }

            else if (selecc == "Asistencias")
            {
                if (id != null)
                {
                    if (id == "Agregar asistencias")
                    {
                        a = false;
                    }

                    if (id == "Editar asistencias")
                    {
                        a = false;
                    }
                }
            }

            else if (selecc == "Permisos")
            {
                if (id != null)
                {
                    if (id == "Agregar permisos")
                    {
                        a = false;
                    }

                    if (id == "Editar permisos")
                    {
                        a = false;
                    }
                }
            }

            //Id de la operacion
            else if (selecc == "Recepcion")
            {

                if (id != null)
                {
                    if (id == "Editar Entrada")
                    {
                        a = false;
                    }

                    if (id == "Editar Clientes")
                    {
                        a = false;
                    }
                }
            }

            else if (selecc == "Cotizacion")
            {
                if (id == "Editar Cotizacion")
                {
                    a = false;
                }

                if (id == "Editar equipos aprobados")
                {
                    a = false;
                }

                if (id == "Aprobar control de calidad")
                {
                    a = false;
                }


            }
            //en caso de que no se ejecutara la lista negra a sera igual al valor con el que fue definida (true)
            return a;
        }

        //Esto es un metodo el cual te devuelve un evento, dependiendo del id de la operacion.
        public EventHandler Eventos(string selec, C_Operation ope)
        {


            if (selec == "Administrador de empleados")

                MessageBox.Show(selec.ToString());
            if (selec == "Empleados")

            {
                //En caso que el id de la operacion sea el 5 (visualizar empleados) se creara el evento de abrir ese formulario.
                if (ope.Id == 23)
                {
                    //El evento.
                    EventHandler evento = delegate (object sender, EventArgs e)
                    {
                        //El metodo que tiene el evento.
                        Empleados ventana = new Empleados(vista);
                        vista.AbrirFormulario(ventana);
                    };

                    //Se retorna el evento.
                    return evento;
                }

                if (ope._Operation == "Ver empleados")
                {
                    EventHandler evento = delegate (object sender, EventArgs e)
                    {
                        Visual_Empleados ventana = new Visual_Empleados(vista);
                        vista.AbrirFormulario(ventana);
                    };

                    return evento;
                }

            }

            if (selec == "Cotizacion")
            {
                if (ope._Operation == "Añadir Cotizacion")
                {
                    EventHandler evento = delegate (object sender, EventArgs e)
                    {
                        AgregarCotizaciones ventana = new AgregarCotizaciones();
                        vista.AbrirFormulario(ventana);

                    };

                    return evento;
                }

                if (ope._Operation == "Ver Cotizacion")
                {
                    EventHandler evento = delegate (object sender, EventArgs e)
                    {
                        VisualizarCotizacion ventana = new VisualizarCotizacion();
                        vista.AbrirFormulario(ventana);
                    };

                    return evento;
                }

                if (ope._Operation == "Ver Equipos aprobados")
                {
                    EventHandler evento = delegate (object sender, EventArgs e)
                    {
                        //VisualizarEquiposControl ventana = new VisualizarEquiposControl();
                        //vista.AbrirFormulario(ventana);
                    };

                    return evento;
                }

                if (ope._Operation == "Ver Ordenes de entrada")
                {
                    EventHandler evento = delegate (object sender, EventArgs e)
                    {
                        VisualizarPeticiones ventan = new VisualizarPeticiones();
                        vista.AbrirFormulario(ventan);
                    };

                    return evento;
                }
            }

            if (selec == "Recepcion")
            {
                if (ope._Operation == "Añadir Entrada")
                {
                    EventHandler evento = delegate (object sender, EventArgs e)
                    {
                        AgregarPeticiones ventana = new AgregarPeticiones(vista);
                        vista.AbrirFormulario(ventana);

                    };

                    return evento;
                }

                if (ope._Operation == "Ver Entrada")
                {
                    EventHandler evento = delegate (object sender, EventArgs e)
                    {
                        VisualizarEntradas ventana = new VisualizarEntradas();
                        vista.AbrirFormulario(ventana);
                    };

                    return evento;
                }

                if (ope._Operation == "Añadir Clientes")
                {
                    EventHandler evento = delegate (object sender, EventArgs e)
                    {
                        AgregarClientes ventana = new AgregarClientes();
                        vista.AbrirFormulario(ventana);
                    };

                    return evento;
                }

                if (ope._Operation == "Ver Clientes")
                {
                    EventHandler evento = delegate (object sender, EventArgs e)
                    {
                        VisualizarClientes ventana = new VisualizarClientes();
                        vista.AbrirFormulario(ventana);
                    };

                    return evento;
                }

                if (ope._Operation == "Ver Cotizacion")
                {
                    EventHandler evento = delegate (object sender, EventArgs e)
                    {
                        VisualizarCotizacion ventana = new VisualizarCotizacion();
                        vista.AbrirFormulario(ventana);
                    };

                    return evento;
                }
            }

            if (selec == "Asistencias")
            {
                if (ope._Operation == "Ver asistencias")
                {
                    EventHandler evento = delegate (object sender, EventArgs e)
                    {
                        Registros_GeneralesAsistencias ventana = new Registros_GeneralesAsistencias(vista);
                        vista.AbrirFormulario(ventana);
                    };

                    return evento;
                }

            }

            if (selec == "Permisos")
            {
                if (ope._Operation == "Ver permisos")
                {
                    EventHandler evento = delegate (object sender, EventArgs e)
                    {
                        Registros_GeneralesPermisos ventana = new Registros_GeneralesPermisos(vista);
                        vista.AbrirFormulario(ventana);
                    };

                    return evento;
                }
            }

            if (selec == "Reportes de RRHH")
            {
                if (ope._Operation == "Exportar reporte" && ope.Module_Name == "Reportes de RRHH")
                {
                    EventHandler evento = delegate (object sender, EventArgs e)
                    {
                        ExportarReportesRRHH ventana = new ExportarReportesRRHH();
                        vista.AbrirFormulario(ventana);
                    };

                    return evento;
                }
            }
            return null;
        }


        #endregion


        #region Nuevo filtro de operaciones

        public Model_User User;
        public Model_Role Role;

        public ControlOperaciones(Model_User User)
        {
            this.User = User;
            this.Role = User._Role;
        }


        public EventHandler GetEvents(string name_operation)
        {
            EventHandler _Event = null;

            List<Model_Operations> operations = this.Role._Operations;

            string operation_select = operations.Where(a => a._Operation == name_operation).Select(a => a._Operation).First();

            if (operation_select != null)
            {
                switch(operation_select)
                {
                    case ("Ver asistencias"):
                        _Event = (object sender, EventArgs e) => 
                        {
                            MessageBox.Show("Hola");
                        };
                        return _Event;

                }
            }
            else
            {
                _Event = null;
            }


            return _Event;

        }

        public void AddItemsInMenustrip(Model_Role Role)
        {
            List<Model_Operations> operations = Role._Operations;

            var GroupOperations = operations.GroupBy(a => a._Module).ToList();

        }
        #endregion
    }
}
