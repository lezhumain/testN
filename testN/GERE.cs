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
    
    public partial class GERE
    {
        public int matricule_col { get; set; }
        public string code_region { get; set; }
        public System.DateTime JJMMAAAA_DEB { get; set; }
        public System.DateTime JJMMAAAA_FIN { get; set; }
    
        public virtual CALENDRIER CALENDRIER { get; set; }
        public virtual COLLABORATEUR COLLABORATEUR { get; set; }
        public virtual REGION REGION { get; set; }
    }
}