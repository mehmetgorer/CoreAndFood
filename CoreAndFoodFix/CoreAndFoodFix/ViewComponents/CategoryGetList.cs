using CoreAndFoodFix.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;

namespace CoreAndFoodFix.ViewComponents
{

    public class CategoryGetList:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            var categoryList = categoryRepository.TList();
            return View(categoryList);
        }
    }
}
