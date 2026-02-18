using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace QS.Data
{
    public class QSDbContextFactory : IDesignTimeDbContextFactory<QSDbContext>
    {
        public QSDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<QSDbContext>();

            optionsBuilder.UseSqlServer(
                "Server=.;Database=QS;Trusted_Connection=True;TrustServerCertificate=True");

            return new QSDbContext(optionsBuilder.Options);
        }
    }
}
