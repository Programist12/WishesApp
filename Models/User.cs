using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace WishesApp.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        public ICollection<Wish> Wishes { get; set; }

    }
}
