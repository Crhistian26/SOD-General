using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.AsistenciasYPermisos
{
    public class Reason
    {
        public int IdReason {  get; set; }
        public string _Reason { get; set; }
        public Reason(int IdReason,string _Reason) 
        {
            this.IdReason = IdReason;
            this._Reason = _Reason;
        }
    }
}
