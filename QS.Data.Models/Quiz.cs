using System;
using System.Collections.Generic;
using System.Text;

namespace QS.Data.Models
{
	public class Quiz
	{
		public int QuizId { get; set; }
		public string Title { get; set; }
		public string? Description { get; set; }
		public int? TimeLimit { get; set; }
		public DateTime CreatedAt { get; set; }

		public virtual ICollection<Question> Questions { get; set; }
	}
}
