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
    
    public partial class AVOIR
    {
        public Nullable<int> quantite_donne { get; set; }
        public string depot_legal { get; set; }
        public int matricule_col { get; set; }
    
        public virtual MEDICAMENT MEDICAMENT { get; set; }
        public virtual COLLABORATEUR COLLABORATEUR { get; set; }
    }
}