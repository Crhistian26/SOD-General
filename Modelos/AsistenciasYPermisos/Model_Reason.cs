using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.AsistenciasYPermisos
{
    public class Model_Reason
    {
        public int IdReason { get; set; }
        public string _Reason { get; set; }
        public string Mesure_Time1 { get; set; }
        public string Mesure_Time2 { get; set; }
        public int MaximuneCount_Time { get; set; }
        public string MesureMaximune_Time { get; set; }
        public Model_Reason(int IdReason, string _Reason)
        {
            this.IdReason = IdReason;
            this._Reason = _Reason;
        }

        public Model_Reason(int IdReason,string _Reason, string Mesure_Time1, string Mesure_Time2, int MaximuneCount_Time, string MesureMaximunr_Time)
            :this(IdReason,_Reason)
        {
            this.Mesure_Time1 = Mesure_Time1;
            this.Mesure_Time2 = Mesure_Time2;
            this.MaximuneCount_Time = MaximuneCount_Time;
            this.MesureMaximune_Time = MesureMaximunr_Time;

        }
    }
}
