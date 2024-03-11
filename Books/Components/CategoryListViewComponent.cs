using Books.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// Đặt tên bắt buộc phải có ViewComponent nếu không có thì sẽ không nhận diện được
// Và được kế thừa từ ViewComponent
// AppDBContext: có nghĩa là service: để lấy dữ liệu
// ViewComponent phải để trong thư mục Shared   và tên thư mục phải là CategoryList vì "categorylistViewComponent" và tên class phải là Default
namespace Books.Components
{
    public class CategoryListViewComponent: ViewComponent
    {
        private readonly AppDBContext _context;
        public CategoryListViewComponent(AppDBContext context) {
            this._context = context;
        }
        // có 2 dạng: đồng bộ và bất đồng bộ
        // ở trên view chỉ cho gọi bất đồng bộ
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var cateList = await this._context.Categories.ToListAsync();
            return View(cateList);
        }
        
    }
}
