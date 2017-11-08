namespace MyZoo.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Species
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Species()
        {
            Animal = new HashSet<Animal>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string SName { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        public int EnviormentId { get; set; }

        public int FoodTypeId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Animal> Animal { get; set; }

        public virtual Enviorment Enviorment { get; set; }

        public virtual FoodType FoodType { get; set; }
    }
}
