using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QS.Data.Models
{
	public class Question
	{
		public Question()
		{
			QuestionId = Guid.NewGuid();
			Answers = new HashSet<Answer>();
		}
		[Key]
		public Guid QuestionId { get; set; }
		[Required]
		[ForeignKey(nameof(Quiz))]
		public Guid QuizId { get; set; }
		[Required]
		[ForeignKey(nameof(Media))]
		public string QuestionText { get; set; } = null!;
		public string QuestionType { get; set; } = null!;
		public int Points { get; set; }
		public int TimeLimit { get; set; }

		public virtual Quiz Quiz { get; set; } = null!;
		public virtual Media Media { get; set; } = null!;
		public virtual ICollection<Answer> Answers { get; set; } 

	}
}
