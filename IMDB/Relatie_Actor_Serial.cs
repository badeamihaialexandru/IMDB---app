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
    
    public partial class Relatie_Actor_Serial
    {
        public int ID_Actor { get; set; }
        public int ID_Serial { get; set; }
        public string Nume_in_Serial { get; set; }
    
        public virtual Actori Actori { get; set; }
        public virtual Seriale Seriale { get; set; }
    }
}
