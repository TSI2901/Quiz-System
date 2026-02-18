using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QS.Data.Models
{
	public class Media
	{
		public Media()
		{
			MediaId = Guid.NewGuid();
			Questions = new HashSet<Question>();
		}
		public Guid MediaId { get; set; }
		[Required]
		public string FileName { get; set; } = null!;
		[Required]
		public string FilePath { get; set; } = null!;
		[Required]
		public string MediaType { get; set; } = null!;
		[Required]
		public string MimeType { get; set; } = null!;
		public long FileSize { get; set; }
		public DateTime UploadedAt { get; set; }

		public virtual ICollection<Question> Questions { get; set; }
	}
}
