using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identity框架1
{
	public class MyDbContext:IdentityDbContext<MyUser,MyRole,long>
	{
		public MyDbContext(DbContextOptions<MyDbContext> options)
			: base(options)
		{

		}
	}
}
