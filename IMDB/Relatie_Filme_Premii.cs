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
    
    public partial class Relatie_Filme_Premii
    {
        public int ID_Premiu { get; set; }
        public int ID_Film { get; set; }
        public string Numar_Premii { get; set; }
    
        public virtual Premii Premii { get; set; }
        public virtual Filme Filme { get; set; }
    }
}
