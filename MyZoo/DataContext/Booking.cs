namespace MyZoo.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking")]
    public partial class Booking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Booking()
        {
            Diagnosis = new HashSet<Diagnosis>();
        }

        public int Id { get; set; }

        public int Animal { get; set; }

        public int StartDate { get; set; }

        public int EndDate { get; set; }

        public int VeterinaryId { get; set; }

        public virtual Veterinary Veterinary { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diagnosis> Diagnosis { get; set; }
    }
}
