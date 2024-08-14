using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.AsistenciasYPermisos
{
    public class Record_Permission
    {
        public int IdRecord { get; set; }
        public int IdEmployee { get; set; }
        public string _Name { get; set; }
        public int IdReason { get; set; }
        public string _Reason { get; set; }
        public string _Description { get; set; }
        public string Mesure_Time { get; set; }
        public int Count_Time { get; set; }
        public DateTime Permission_Date { get; set; }

        public Record_Permission(int IdRecord,string Reason,string descip, int Count, string Mesure, DateTime fecha)
        {
            this.IdRecord = IdRecord;
            this._Reason = Reason;
            this._Description = descip;
            this.Count_Time = Count;
            this.Mesure_Time = Mesure;
            this.Permission_Date = fecha;
        }

        public Record_Permission(int IdRecord, string Reason, string Name, string descip, int Count, string Mesure, DateTime fecha)
        {
            this.IdRecord = IdRecord;
            this._Reason = Reason;
            this._Name = Name;
            this._Description = descip;
            this.Count_Time = Count;
            this.Mesure_Time = Mesure;
            this.Permission_Date = fecha;
        }

        public Record_Permission(int IdRecord,string Name,string Reason,bool a, int Count, string Mesure, DateTime fecha)
        {
            this.IdRecord = IdRecord;
            this._Name = Name;
            this._Reason = Reason;
            this.Count_Time = Count;
            this.Mesure_Time = Mesure;
            this.Permission_Date = fecha;
        }
    }
}
