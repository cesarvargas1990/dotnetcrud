namespace MyApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Propiedad inicializada
        public decimal Price { get; set; }
    }
}
