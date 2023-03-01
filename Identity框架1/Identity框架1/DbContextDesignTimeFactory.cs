using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Identity框架1
{
	public class DbContextDesignTimeFactory : IDesignTimeDbContextFactory<MyDbContext>
	{
		public MyDbContext CreateDbContext(string[] args)
		{
			DbContextOptionsBuilder<MyDbContext> builder =
				new DbContextOptionsBuilder<MyDbContext>();

			builder.UseSqlServer("Server=.;Database=Power;Trusted_Connection=True;TrustServerCertificate=true;MultipleActiveResultSets=true");

			return new MyDbContext(builder.Options);
		}
	}
}
