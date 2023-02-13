namespace WishesApp.DTO
{
    public class DtoWish
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime Estimate { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public string Status { get; set; }
        public string Links { get; set; }
        public string Desires { get; set; }
    }
}
