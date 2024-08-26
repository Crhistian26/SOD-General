namespace Modelos.AsistenciasYPermisos
{
    public class Model_Reason
    {
        public int IdReason { get; set; }
        public string _Reason { get; set; }
        public string _Descripcion { get; set; }
        public int MaximuneCount_Time { get; set; }
        public string MesureMaximune_Time { get; set; }
        public string For_mesure { get; set; }
        public Model_Reason(int IdReason, string _Reason)
        {
            this.IdReason = IdReason;
            this._Reason = _Reason;
        }

        public Model_Reason(int IdReason, string _Reason, string _Descripcion, int MaximuneCount_Time, string MesureMaximunr_Time, string for_mesure)
            : this(IdReason, _Reason)
        {
            this._Descripcion = _Descripcion;
            this.MaximuneCount_Time = MaximuneCount_Time;
            this.MesureMaximune_Time = MesureMaximunr_Time;
            this.For_mesure = for_mesure;
        }
    }
}
