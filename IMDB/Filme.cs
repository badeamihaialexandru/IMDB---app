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
    
    public partial class Filme
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Filme()
        {
            this.Relatie_actor_film = new HashSet<Relatie_actor_film>();
            this.Relatie_Filme_Premii = new HashSet<Relatie_Filme_Premii>();
            this.Genuris = new HashSet<Genuri>();
            this.Regizoris = new HashSet<Regizori>();
        }
    
        public int ID_Film { get; set; }
        public string Nume { get; set; }
        public string An_aparitie { get; set; }
        public string Nota { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Relatie_actor_film> Relatie_actor_film { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Relatie_Filme_Premii> Relatie_Filme_Premii { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Genuri> Genuris { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Regizori> Regizoris { get; set; }
    }
}
