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
    
    public partial class DOSAGE
    {
        public DOSAGE()
        {
            this.PRESCRIRE = new HashSet<PRESCRIRE>();
        }
    
        public int code_dosage { get; set; }
        public string unite_dosage { get; set; }
        public double quantite_dosage { get; set; }
    
        public virtual ICollection<PRESCRIRE> PRESCRIRE { get; set; }
    }
}