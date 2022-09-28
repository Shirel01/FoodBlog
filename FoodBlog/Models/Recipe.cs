using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace FoodBlog.Models
{
    public class Recipe
    {

        public int Id { get; set; }
        public string Title { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }

        public string PrepInstructions { get; set; }
        
        public string ImageUrl { get; set; }
    }
}

