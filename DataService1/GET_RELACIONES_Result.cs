//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataService1
{
    using System;
    
    public partial class GET_RELACIONES_Result
    {
        public string Mensaje { get; set; }
        public Nullable<decimal> AjusteID { get; set; }
        public Nullable<decimal> AlimID { get; set; }
        public string AlimName { get; set; }
        public Nullable<int> TotalHours { get; set; }
        public string periodo { get; set; }
        public string Entrega_Day { get; set; }
        public Nullable<System.TimeSpan> Entrega_Time { get; set; }
        public string Recogido_Day { get; set; }
        public Nullable<System.TimeSpan> Recogido_time { get; set; }
        public byte[] MONTHS { get; set; }
        public byte[] DAYS { get; set; }
        public Nullable<bool> Edited { get; set; }
        public Nullable<bool> deleted { get; set; }
        public Nullable<bool> Added { get; set; }
    }
}
