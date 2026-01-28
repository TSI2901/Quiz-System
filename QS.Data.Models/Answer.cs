using System;
using System.Collections.Generic;
using System.Text;

namespace QS.Data.Models
{
	public class Answer
	{
		public Guid AnswerId { get; set; }
		public Guid QuestionId { get; set; }
		public string AnswerText { get; set; }
		public bool IsCorrect { get; set; }

		public virtual Question Question { get; set; }
	}
}
