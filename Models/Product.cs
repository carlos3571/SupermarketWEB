using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketWEB.Models
{
    public class Product
    {
        // [Key] -> Anotacion si la propiedad no se llama Id, ejemplo ProductIf
        public int Id { get; set; } // Sera la llave primaria

        public required string Name { get; set; }

        [Column(TypeName = "decimal(6,2)")]

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public int CategoryId { get; set; } // Sera la llave foranea

        public required Category Category { get; set; } // Propiedad de navegacion

    }
}
