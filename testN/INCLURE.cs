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
    
    public partial class INCLURE
    {
        public int inc_qte { get; set; }
        public Nullable<int> inc_montant { get; set; }
        public string ff_mois { get; set; }
        public string tf_Code { get; set; }
    
        public virtual FICHE_FRAIS FICHE_FRAIS { get; set; }
        public virtual TYPE_FRAIS TYPE_FRAIS { get; set; }
    }
}