namespace MyZoo.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Relations
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }

        public int? ChildId { get; set; }

        public virtual Animal Animal { get; set; }

        public virtual Animal Animal1 { get; set; }
    }
}
