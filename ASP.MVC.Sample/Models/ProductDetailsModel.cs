using System.ComponentModel.DataAnnotations;

namespace DellChallenge.D2.Web.Models
{
    public class ProductDetailsModel
    {
        [Required]
        public string Name { get; set; }
        public string Category { get; set; }
    }
}
