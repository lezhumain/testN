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
    
    public partial class CALENDRIER
    {
        public CALENDRIER()
        {
            this.ETRE_RESPONSABLE = new HashSet<ETRE_RESPONSABLE>();
            this.GERE = new HashSet<GERE>();
        }
    
        public System.DateTime JJMMAAAA { get; set; }
    
        public virtual ICollection<ETRE_RESPONSABLE> ETRE_RESPONSABLE { get; set; }
        public virtual ICollection<GERE> GERE { get; set; }
    }
}
