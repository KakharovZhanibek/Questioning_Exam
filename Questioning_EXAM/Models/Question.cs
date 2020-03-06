namespace Questioning_EXAM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            Answers = new HashSet<Answers>();
        }

        public int Id { get; set; }

        [StringLength(2000)]
        public string QuestionText { get; set; }
        public int AnswerId { get; set; }
        public virtual Answer Answers { get; set; }
    }
}
