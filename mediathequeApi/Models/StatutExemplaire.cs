//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mediathequeApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StatutExemplaire
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StatutExemplaire()
        {
            this.Exemplaire = new HashSet<Exemplaire>();
        }
    
        public int IdStatutExemplaire { get; set; }
        public string LibelleStatutExemplaire { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exemplaire> Exemplaire { get; set; }
    }
}
