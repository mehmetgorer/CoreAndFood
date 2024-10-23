using CoreAndFoodFix.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreAndFoodFix.ViewComponents
{
	public class FoodGetList:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			FoodRepository foodRepository = new FoodRepository();
			var foodlist = foodRepository.TList();
			return View(foodlist);
		}
	}
}
