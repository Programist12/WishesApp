using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;

namespace WishesApp.DTO
{
    public class DtoUser
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string PhoneNumber { get; set; }
        public string About { get; set; }
        public string Password { get; set; }
    }
}
