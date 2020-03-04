namespace Questioning_EXAM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Answers
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Answer { get; set; }

        public int? QuestionOfAnswer { get; set; }

        public virtual Questions Questions { get; set; }
    }
}
