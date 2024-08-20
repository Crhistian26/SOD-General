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
        public DateTime Begin_Date { get; set; }
        public DateTime End_Date { get; set; }

        public Record_Permission(int IdRecord,string Reason,string descip, DateTime fecha1, DateTime fecha2)
        {
            this.IdRecord = IdRecord;
            this._Reason = Reason;
            this._Description = descip;
            this.Begin_Date = fecha1;
            this.End_Date = fecha2;
        }

        public Record_Permission(int IdRecord, string Reason, string Name, string descip, DateTime fecha1, DateTime fecha2)
            :this(IdRecord,Reason,descip,fecha1,fecha2)
        {
            this._Name = Name;
        }

        public Record_Permission(int IdRecord,string Name, DateTime fecha1, DateTime fecha2, string Reason)
        {
            this.IdRecord = IdRecord;
            this._Name = Name;
            this._Reason = Reason;
            this.Begin_Date = fecha1;
            this.End_Date = fecha2;
        }

        public string Get_Hours_Ausent(DateTime date1, DateTime date2)
        {
            return null;   
        }
            

    }
}
