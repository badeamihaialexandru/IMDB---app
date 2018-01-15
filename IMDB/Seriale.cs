//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IMDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Seriale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Seriale()
        {
            this.Genuris = new HashSet<Genuri>();
            this.Relatie_Actor_Serial = new HashSet<Relatie_Actor_Serial>();
            this.WatchlistSeriales = new HashSet<WatchlistSeriale>();
            this.YourRatingsSerials = new HashSet<YourRatingsSerial>();
        }
    
        public int ID_Serial { get; set; }
        public string Nume { get; set; }
        public Nullable<int> An_aparitie { get; set; }
        public Nullable<int> Numar_sezoane { get; set; }
        public Nullable<int> Total_episoade { get; set; }
        public string Nota { get; set; }
        public byte[] Photo { get; set; }
        public Nullable<double> Nota_finala { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Genuri> Genuris { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Relatie_Actor_Serial> Relatie_Actor_Serial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WatchlistSeriale> WatchlistSeriales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YourRatingsSerial> YourRatingsSerials { get; set; }
    }
}
