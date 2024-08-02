using System;
using System.Drawing;

namespace SOD_General.Controladores
{
    internal class SizesGenerales
    {
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
            if(hora.Hours > 12)
            {
                if(hora.Minutes == 0)
                {
                    return $"{hora.Hours - 12}:{hora.Minutes}0 PM";
                }
                else
                {
                    return $"{hora.Hours - 12}:{hora.Minutes} PM";
                }
               
            }
            else if(hora.Hours == 12)
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
    }
}
