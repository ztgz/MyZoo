namespace MyZoo.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Diagnosis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Diagnosis()
        {
            MedicineDiagnosisRelation = new HashSet<MedicineDiagnosisRelation>();
        }

        public int Id { get; set; }

        [StringLength(250)]
        public string Journal { get; set; }

        public int BookingId { get; set; }

        public virtual Booking Booking { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicineDiagnosisRelation> MedicineDiagnosisRelation { get; set; }
    }
}
