namespace LabWebApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        public string? Name { get; set; }  // Nullable string
        
        public int Price { get; set; }
        
        public string? Description { get; set; }  // Nullable string
    }
}
