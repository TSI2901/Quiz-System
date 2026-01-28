using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QS.Data.Models;
using System.Security.Cryptography;

namespace QS.Data
{
    public class QSDbContext(DbContextOptions<QSDbContext> options) : IdentityDbContext(options)
    {
		public DbSet<Quiz> Quizzes { get; set; }
		public DbSet<Question> Questions { get; set; }
		public DbSet<Answer> Answers { get; set; }
		public DbSet<Media> Media { get; set; }
	}
}
