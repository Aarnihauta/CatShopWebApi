namespace CatShopWebApi.Models
{
    public class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public bool Bought { get; set; }
        public bool Order { get; set; }
    }
}
