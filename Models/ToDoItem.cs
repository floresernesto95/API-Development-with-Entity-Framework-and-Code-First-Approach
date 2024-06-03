using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clase_1.Models
{
    // Define a public class named ToDoItem which will be mapped to a database table.
    public class ToDoItem
    {
        // [Key] denotes that this property 'Id' is the primary key in the database table.
        [Key]
        public Guid Id { get; set; } // Unique identifier for each ToDoItem.

        // [Required] indicates that this field must not be null when saving to the database.
        // [MaxLength(255)] limits the length of the string to 255 characters to match database schema constraints.
        [Required]
        [MaxLength(255)]
        public string NombreTarea { get; set; } // Name or description of the to-do task.
        
        // Simple boolean property to track whether the task is complete or not.
        public bool EstaCompleta { get; set; }

        // [ForeignKey("CategoriaId")] specifies that this property links to the Categoria class using the CategoriaId foreign key.
        [ForeignKey("CategoriaId")]
        public int CategoriaId { get; set; }

        // Navigation property allowing Entity Framework to automatically handle relationships and lazy loading.
        public Categoria Categoria { get; set; } // Category object associated with this to-do item.
    }
}
