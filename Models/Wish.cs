using System.ComponentModel.DataAnnotations;

namespace WishesApp.Models
{
    public class Wish
    {
        [Key]
        public int WishId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public DateTime Estimate { get; set; }
        [Required]
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public User User { get; set; }
        public string Status { get; set; }
        public string Links { get; set; }
        public string Desires { get; set; }

    }
}
