using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WishesApp.DTO
{
    public class DtoWish
    {
        public string Name { get; set; }
        public string Type { get; set; }
        [BindProperty, DisplayFormat(DataFormatString = "{0:yyyy-MM-ddTHH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Estimate { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public string Status { get; set; }
        public string Links { get; set; }
        public string Desires { get; set; }
        public List<string> AvailableUsersForWish{ get; set; }
        public string SelectedUserEmail { get; set; }
    }
}
