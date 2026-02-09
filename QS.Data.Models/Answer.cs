using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QS.Data.Models
{
	public class Answer
	{
        public Answer()
        {
               AnswerId = Guid.NewGuid();
        }
        [Key]
        public Guid AnswerId { get; set; }
        [Required]
        [ForeignKey(nameof(Question))]
		public Guid QuestionId { get; set; }
        [Required]
        public string AnswerText { get; set; } = null!;
		public bool IsCorrect { get; set; }

		public virtual Question Question { get; set; } = null!;
    }
}
