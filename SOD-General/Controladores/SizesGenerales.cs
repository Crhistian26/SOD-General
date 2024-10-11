using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;

namespace SOD_General.Controladores
{
    public class SizesGenerales
    {
        //cambio
        public Dictionary<DayOfWeek, (TimeSpan JobStart, TimeSpan JobEnd)> Days = new Dictionary<DayOfWeek, (TimeSpan JobStart, TimeSpan JobEnd)>
        {
            {DayOfWeek.Monday,(new TimeSpan(8,30,0),new TimeSpan(17,30,0))},
            {DayOfWeek.Tuesday,(new TimeSpan(8,30,0),new TimeSpan(17,30,0))},
            {DayOfWeek.Wednesday,(new TimeSpan(9,0,0),new TimeSpan(17,30,0))},
            {DayOfWeek.Thursday,(new TimeSpan(8,30,0),new TimeSpan(17,30,0))},
            {DayOfWeek.Friday,(new TimeSpan(8,30,0),new TimeSpan(17,30,0))},
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

        /// <summary>
        /// Este metodo transforma un <see cref="TimeSpan/> con dias en un texto con las horas totales de los dias y los minutos
        /// </summary>
        /// <param name="_hours">El TimeSpan a convertir</param>
        /// <returns>Un string que te dira la cantidad de horas totales</returns>
        public string ConvertTSWithDays(TimeSpan _hours)
        {
            string Hours = "";
            int h = _hours.Days * 24;
            h += _hours.Hours;
            Hours = $"{h}:{_hours.Minutes}";
            return Hours;
        }

        public string FiltarHoras(TimeSpan hora)
        {
            string minutes = "";
            if (hora.Minutes > 9)
            {
                minutes = hora.Minutes.ToString();
            }
            if (hora.Minutes <= 9 || hora.Minutes == 0)
            {
                minutes = $"0{hora.Minutes.ToString()}";
            }

            if (hora.Hours > 12)
            {
                if (hora.Minutes == 0)
                {
                    return $"{hora.Hours - 12}:{minutes} PM";
                }
                else
                {
                    return $"{hora.Hours - 12}:{minutes} PM";
                }

            }
            else if (hora.Hours == 12)
            {
                if (hora.Minutes == 0)
                {
                    return $"{hora.Hours}:{minutes} PM";
                }
                else
                {
                    return $"{hora.Hours}:{minutes} PM";
                }
            }
            else
            {
                if (hora.Minutes == 0)
                {
                    return $"{hora.Hours}:{minutes} AM";
                }
                else
                {
                    return $"{hora.Hours}:{minutes} AM";
                }
            }
        }

        public (string, string, string) FiltrarHorasComb(TimeSpan hora)
        {
            string minutes = "";
            if(hora.Minutes > 9)
            {
                minutes = hora.Minutes.ToString();
            }
            if (hora.Minutes <= 9 || hora.Minutes == 0)
            {
                minutes = $"0{hora.Minutes.ToString()}";
            }

            if (hora.Hours > 12)
            {
                return ((hora.Hours - 12).ToString(), minutes, "PM");
            }
            else if (hora.Hours == 12)
            {
                return (hora.Hours.ToString(), minutes, "PM");
            }
            else if (hora.Hours == 24)
            {
                return (hora.Hours.ToString(), minutes, "AM");
            }
            else
            {
                return (hora.Hours.ToString(), minutes, "AM");
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

        public TimeSpan CreateTS(DateTime date)
        {
            return new TimeSpan(date.Hour, date.Minute, 0);
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
