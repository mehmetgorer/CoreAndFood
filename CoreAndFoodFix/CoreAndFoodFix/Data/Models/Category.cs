using System.ComponentModel.DataAnnotations;

namespace CoreAndFoodFix.Data.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Required(ErrorMessage ="Category Name Not Empty")]
        [StringLength(20, ErrorMessage = "You can use 4-20 characters ",MinimumLength =3)]
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public bool Status { get; set; }

        public List<Food> Foods { get; set; }
    }
}
