using Microsoft.AspNetCore.Identity;

namespace Identity框架1
{
	public class MyUser:IdentityUser<long>
	{
		public string? WeiXinAccount { get; set; }
	}
}
