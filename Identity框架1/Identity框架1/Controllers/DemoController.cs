using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Identity框架1.Controllers
{
	public class DemoController : Controller
	{
		private readonly UserManager<MyUser> userManager;
		private readonly RoleManager<MyRole> roleManager;

		public DemoController(UserManager<MyUser> _userManager,RoleManager<MyRole> _roleManager)
		{
			userManager = _userManager;
			roleManager = _roleManager;
		}

		public IActionResult Index()
		{
			return View();
		}
	}
}
