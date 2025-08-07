using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Release Date is required")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Genre is required")]
        [StringLength(30)]
        public string Genre { get; set; }

        [Range(1, 100, ErrorMessage = "Price must be between 1 and 100")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
