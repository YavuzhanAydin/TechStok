//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class vUrunler
    {
        public int ParcaId { get; set; }
        public string ParcaAdi { get; set; }
        public string KategoriAdi { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string TeknikDetaylar { get; set; }
        public Nullable<int> StokAdeti { get; set; }
        public Nullable<decimal> BirimFiyati { get; set; }
        public Nullable<System.DateTime> EklenmeTarihi { get; set; }
        public Nullable<System.DateTime> GuncellemeTarihi { get; set; }
        public Nullable<int> KategoriID { get; set; }
    }
}
