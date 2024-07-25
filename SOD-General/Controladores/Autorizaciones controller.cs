using Modelos.Usuarios_Empleados;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General.Controladores
{
    internal class Autorizaciones_controller
    {
        //cadena de conexion y la propia conexion.
        static string cadena = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        SqlConnection conex = new SqlConnection(cadena);

        AppVistaGeneral vista;
        string department;

        public Autorizaciones_controller(AppVistaGeneral vista, string department)
        {
            this.vista = vista;
            this.department = department;
        }

        /// <summary>
        /// Este metodo se encarga de filtrar la lista de autorizaciones que le pongas, por su id, osea no habra dos funciones con IDs diferentes.
        /// </summary>
        /// <param name="authorizations">La lista de autorizaciones</param>
        /// <returns>Una nueva lista ya filtrada.</returns>
        public List<MAuthorization> Filtrar(List<MAuthorization> authorizations)
        {
            // la lista a devolver
            List<MAuthorization> lista = new List<MAuthorization>();
            /*El filtro:
             * Lo que este hace es agrupar (GroupBy) los elementos por su ID.
             * Luego se seleccionan (select) el primero de cada grupo.
             * Y se devuelve en una lista.
            */
            lista = authorizations.GroupBy(a => a.IdAuthorization).Select(a => a.First()).ToList();
            return lista;
        }

        /// <summary>
        /// Este metodo se encarga de crear cada uno de los elementos del menustrip, aunque es muy extenso.
        /// Solamente pon la lista de autorizaciones y lo demas lo hace solo.
        /// </summary>
        /// <param name="authorizations">La lista de autorizaciones a introducir.</param>
        public void elementos(List<MAuthorization> authorizations)
        {
            //Este es 
            var DepartamentosExtra = from aut in authorizations
                                orderby aut._AuthotizationType descending
                                where aut._AuthotizationType != department
                                group aut by aut._AuthotizationType.ToList();

            List<string> DepartExtFiltrados = new List<string>();
            List<string> autorizaciones = new List<string>();
            foreach(var a in DepartamentosExtra)
            {
                for(int i = 0; i < a.Count(); i++)
                {
                    
                }
            }

            List<ToolStripMenuItem> items = new List<ToolStripMenuItem>();

            ToolStripMenuItem itemdepartment = new ToolStripMenuItem();
            itemdepartment.Text = department;
            
            items.Add(itemdepartment);

            if(DepartExtFiltrados != null)
            {
                foreach(string departamento in DepartExtFiltrados)
                {
                    ToolStripMenuItem departAdd = new ToolStripMenuItem();
                    if (departamento == "AAAdicional")
                    {
                        departAdd.Text = "Adicional";
                    }
                    else
                    {
                        departAdd.Text = departamento;
                    }
                    items.Add(departAdd);
                }
            }

            foreach(ToolStripMenuItem item in items)
            {
                vista.cR_MenuStrip1.Items.Add(item);
            }
            

        }

        
    }
}
