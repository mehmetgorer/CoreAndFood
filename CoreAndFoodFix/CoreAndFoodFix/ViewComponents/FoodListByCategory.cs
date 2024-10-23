using CoreAndFoodFix.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreAndFoodFix.ViewComponents
{
	public class FoodListByCategory :ViewComponent
	{
		public IViewComponentResult Invoke(int id)
		{
			//id = 1;
			FoodRepository foodRepository = new FoodRepository();
			var foodlist = foodRepository.List( x=>x.CategoryID ==id);
			return View(foodlist);
		}
	}
}
