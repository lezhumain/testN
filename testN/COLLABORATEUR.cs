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
    
    public partial class COLLABORATEUR
    {
        public COLLABORATEUR()
        {
            this.ACTIVITE_COMPLEMENTAIRE = new HashSet<ACTIVITE_COMPLEMENTAIRE>();
            this.AVOIR = new HashSet<AVOIR>();
            this.ETRE_RESPONSABLE = new HashSet<ETRE_RESPONSABLE>();
            this.FICHE_FRAIS = new HashSet<FICHE_FRAIS>();
            this.GERE = new HashSet<GERE>();
            this.RAPPORT_DE_VISITE = new HashSet<RAPPORT_DE_VISITE>();
            this.ACTIVITE_COMPLEMENTAIRE1 = new HashSet<ACTIVITE_COMPLEMENTAIRE>();
        }
    
        public int matricule_col { get; set; }
        public string nom_col { get; set; }
        public string prenom_col { get; set; }
        public string adresse_col { get; set; }
        public string cp_col { get; set; }
        public string ville_col { get; set; }
        public string mdp_col { get; set; }
        public System.DateTime date_embauche { get; set; }
    
        public virtual ICollection<ACTIVITE_COMPLEMENTAIRE> ACTIVITE_COMPLEMENTAIRE { get; set; }
        public virtual ICollection<AVOIR> AVOIR { get; set; }
        public virtual DIRECTEUR_REGIONAL DIRECTEUR_REGIONAL { get; set; }
        public virtual ICollection<ETRE_RESPONSABLE> ETRE_RESPONSABLE { get; set; }
        public virtual ICollection<FICHE_FRAIS> FICHE_FRAIS { get; set; }
        public virtual ICollection<GERE> GERE { get; set; }
        public virtual ICollection<RAPPORT_DE_VISITE> RAPPORT_DE_VISITE { get; set; }
        public virtual RESPONSABLE_DE_SECTEUR RESPONSABLE_DE_SECTEUR { get; set; }
        public virtual ICollection<ACTIVITE_COMPLEMENTAIRE> ACTIVITE_COMPLEMENTAIRE1 { get; set; }
        public virtual REGION REGION { get; set; }
    }
}
