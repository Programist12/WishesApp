using System.ComponentModel.DataAnnotations;

namespace WishesApp.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string SecondName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [StringLength(500)]
        public string About { get; set; }

        public ICollection<Wish> Wishes { get; set; }

    }
}
