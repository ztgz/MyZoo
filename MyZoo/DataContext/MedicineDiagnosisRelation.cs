namespace MyZoo.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MedicineDiagnosisRelation")]
    public partial class MedicineDiagnosisRelation
    {
        public int Id { get; set; }

        public int DiagnosisId { get; set; }

        public int MedicineId { get; set; }

        public virtual Diagnosis Diagnosis { get; set; }

        public virtual Medicine Medicine { get; set; }
    }
}
