using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SOD_General.Controladores
{
    public class SizesGenerales
    {
        public Dictionary<DayOfWeek, (TimeSpan JobStart, TimeSpan JobEnd)> Days = new Dictionary<DayOfWeek, (TimeSpan JobStart, TimeSpan JobEnd)>
        {
            {DayOfWeek.Monday,(new TimeSpan(8,30,0),new TimeSpan(17,45,0))},
            {DayOfWeek.Tuesday,(new TimeSpan(8,30,0),new TimeSpan(17,45,0))},
            {DayOfWeek.Wednesday,(new TimeSpan(9,0,0),new TimeSpan(17,45,0))},
            {DayOfWeek.Thursday,(new TimeSpan(8,30,0),new TimeSpan(17,45,0))},
            {DayOfWeek.Friday,(new TimeSpan(8,30,0),new TimeSpan(17,45,0))},
            {DayOfWeek.Saturday,(new TimeSpan(8,30,0),new TimeSpan(13,0,0))},
            {DayOfWeek.Sunday,(new TimeSpan(0,0,0),new TimeSpan(0,0,0))},
        };

        /// <summary>
        /// Te centran los elementos en X y en Y acorde al panel o contenedor que introduzcas.
        /// </summary>
        /// <param name="Elemento">El elemento que quieras centrar.</param>
        /// <param name="Panel">El panel o contenerdor padre.</param>
        /// <returns>Te retorna la nueva Location</returns>
        public Point CentrarElementosXY(Size Elemento, Size Panel)
        {
            int posicionX = 0, posicionY = 0;
            int panel = Panel.Width;
            int element = Elemento.Width;
            posicionX = (panel - element) / 2;
            panel = Panel.Height;
            element = Elemento.Height;
            posicionY = (panel - element) / 2;

            Point punto = new Point();
            punto = new Point(posicionX, posicionY);
            return punto;
        }

        /// <summary>
        /// Te centran los elementos en X acorde al panel o contenedor que introduzcas.
        /// </summary>
        /// <param name="ElementoP">La Location anterior del elemento.</param>
        /// <param name="ElementoS">El tamaño del elemento.</param>
        /// <param name="PanelSize">El tamaño del panel o contenedor padre</param>
        /// <returns>Te retorna la nueva Location</returns>
        public Point CentrarElementosX(Point ElementoP, Size ElementoS, Size PanelSize)
        {
            int posicion = 0;
            int panel = PanelSize.Width;
            int element = ElementoS.Width;
            posicion = (panel - element) / 2;
            Point punto = new Point();
            punto = new Point(posicion, ElementoP.Y);
            return punto;
        }

        public string FiltarHoras(TimeSpan hora)
        {
            if (hora.Hours > 12)
            {
                if (hora.Minutes == 0)
                {
                    return $"{hora.Hours - 12}:{hora.Minutes}0 PM";
                }
                else
                {
                    return $"{hora.Hours - 12}:{hora.Minutes} PM";
                }

            }
            else if (hora.Hours == 12)
            {
                if (hora.Minutes == 0)
                {
                    return $"{hora.Hours}:{hora.Minutes}0 PM";
                }
                else
                {
                    return $"{hora.Hours}:{hora.Minutes} PM";
                }
            }
            else
            {
                if (hora.Minutes == 0)
                {
                    return $"{hora.Hours}:{hora.Minutes}0 AM";
                }
                else
                {
                    return $"{hora.Hours}:{hora.Minutes} AM";
                }
            }
        }

        public (string, string, string) FiltrarHorasComb(TimeSpan hora)
        {
            if (hora.Hours > 12)
            {
                return ((hora.Hours - 12).ToString(), hora.Minutes.ToString(), "PM");
            }
            else if (hora.Hours == 12)
            {
                return (hora.Hours.ToString(), hora.Minutes.ToString(), "PM");
            }
            else if (hora.Hours == 24)
            {
                return (hora.Hours.ToString(), hora.Minutes.ToString(), "AM");
            }
            else
            {
                return (hora.Hours.ToString(), hora.Minutes.ToString(), "AM");
            }
        }

        public TimeSpan ConvertComboForTimeSpan(int hour, int minutes, string Meridiem)
        {

            if (Meridiem == "AM" && hour < 12)
            {
                return new TimeSpan(hour,minutes,0);
            }
            else if (Meridiem == "AM" && hour == 12)
            {
                return new TimeSpan(0,minutes,0);
            }
            else if (Meridiem == "PM" && hour < 12)
            {
                return new TimeSpan(hour + 12, minutes, 0);
            }
            else
            {
                return new TimeSpan(hour, minutes, 0);
            }
        }

        public TimeSpan CreateTS(string hour, string min, string merides)
        {
            TimeSpan time = new TimeSpan();
            int _hour = Convert.ToInt32(hour);
            int _min = Convert.ToInt32(min);
            if (merides == "PM" && _hour != 12)
            {
                time = new TimeSpan(_hour + 12, _min, 0);
            }
            else if (merides == "AM" && _hour != 12)
            {
                time = new TimeSpan(_hour, _min, 0);
            }
            else if (merides == "PM" && _hour == 12)
            {
                time = new TimeSpan(_hour, _min, 0);
            }
            else if (merides == "AM" && _hour == 12)
            {
                time = new TimeSpan(0, _min, 0);
            }
            return time;
        }

        public void CloseForm(Form formulario)
        {
            var windows = Application.OpenForms.OfType<Form>().Where(f => f.GetType() == formulario.GetType()).ToList();
            
            if (windows.Count > 1)
            {
                var window = windows.First();
                window.Close();
            }
        }

        public void ChechekConnection(SqlConnection conex)
        {
            if (conex.State != System.Data.ConnectionState.Closed)
            {
                conex.Close();
            }
        }
    }
}
