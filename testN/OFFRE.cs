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
    
    public partial class OFFRE
    {
        public int quanite_offre { get; set; }
        public int num_rapport { get; set; }
        public string depot_legal { get; set; }
    
        public virtual MEDICAMENT MEDICAMENT { get; set; }
        public virtual RAPPORT_DE_VISITE RAPPORT_DE_VISITE { get; set; }
    }
}