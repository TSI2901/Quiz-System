using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QS.Data.Models
{
	public class Quiz
	{
        public Quiz()
        {
            QuizId = Guid.NewGuid();
			Questions = new HashSet<Question>();
        }
		[Key]
        public Guid QuizId { get; set; }
		[Required]
		public string Title { get; set; } = null!;
		public string? Description { get; set; }
		public int? TimeLimit { get; set; }
		public DateTime CreatedAt { get; set; }

		public virtual ICollection<Question> Questions { get; set; }
	}
}
