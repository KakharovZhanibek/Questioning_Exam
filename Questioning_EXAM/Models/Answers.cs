namespace Questioning_EXAM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Answer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string AnswerText { get; set; }

        public int QuestionOfAnswer { get; set; }

        public virtual Question Questions { get; set; }
    }
}
