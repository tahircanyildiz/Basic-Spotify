//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MuzikDosyam_Prolab3
{
    using System;
    using System.Collections.Generic;
    
    public partial class AlbumSanatci
    {
        public int Id { get; set; }
        public Nullable<int> AlbumID { get; set; }
        public Nullable<int> SanatciID { get; set; }
    
        public virtual Album Album { get; set; }
        public virtual Sanatci Sanatci { get; set; }
    }
}
