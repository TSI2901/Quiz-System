using Microsoft.AspNetCore.Identity;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Quiz>()
                .HasMany(x => x.Questions)
                .WithOne(x => x.Quiz)
                .HasForeignKey(x => x.QuizId);

            modelBuilder.Entity<Question>()
                .HasMany(x => x.Answers)
                .WithOne(x => x.Question)
                .HasForeignKey(x => x.QuestionId);

            modelBuilder.Entity<Question>()
               .HasOne(x => x.Media)
               .WithMany(x => x.Questions)
               .HasForeignKey(x => x.MediaId);

            //modelBuilder.Entity<ApplicationUser>()
            //    .HasMany(e => e.UsersRoles)
            //    .WithOne(e => e.User)
            //    .HasForeignKey(ur => ur.UserId)
            //    .IsRequired();

            //modelBuilder.Entity<ApplicationRole>()
            //    .HasMany(e => e.UsersRoles)
            //    .WithOne(e => e.Role)
            //    .HasForeignKey(ur => ur.RoleId)
            //    .IsRequired();

            //modelBuilder.Entity<ApplicationUserRole>()
            //    .HasOne(e => e.Role)
            //    .WithMany(e => e.UsersRoles)
            //    .HasForeignKey(ur => ur.RoleId)
            //    .IsRequired();

            //modelBuilder.Entity<ApplicationUserRole>()
            //    .HasOne(e => e.User)
            //    .WithMany(e => e.UsersRoles)
            //    .HasForeignKey(ur => ur.UserId)
            //    .IsRequired();

        }

    }
}
