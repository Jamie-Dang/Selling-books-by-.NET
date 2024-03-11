using Books.Data;
using Books.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;

namespace Books.Controllers
{
	public class HomeController : Controller
	{
		private readonly AppDBContext _context;
		private readonly ILogger<HomeController> _logger;

		
		public HomeController(ILogger<HomeController> logger, AppDBContext context)
		{
			_logger = logger;
			_context = context;
		}

		//public IActionResult CategoryList()
		//{
		//	List<Product> products = this._context.Products.ToList<Product>();
		//	return View(products);
		//	//return View();
		//}

		public IActionResult Index()
		{
			List<Product> products = this._context.Products.ToList<Product>();
			return View(products);
			//return View();
		}

		

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}