//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testN
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRESENTATION
    {
        public PRESENTATION()
        {
            this.MEDICAMENT = new HashSet<MEDICAMENT>();
        }
    
        public int code_present { get; set; }
        public string libelle_present { get; set; }
    
        public virtual ICollection<MEDICAMENT> MEDICAMENT { get; set; }
    }
}
