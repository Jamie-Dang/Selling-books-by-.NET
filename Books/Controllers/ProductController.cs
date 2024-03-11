using Books.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Books.Controllers
{
	
	public class ProductController : Controller
	{
		private readonly AppDBContext _context;
		public ProductController(AppDBContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			
			return View();
		}


		public IActionResult Detail(int id)
		{
			Product product = this._context.Products.Where(p => p.Id == id).FirstOrDefault();
			return View(product);
		}

		public IActionResult List(int id)
        {
            var product = this._context.Products.Where(p => p.CategoryId == id).ToList();
            return View(product);
        }
    }
}
