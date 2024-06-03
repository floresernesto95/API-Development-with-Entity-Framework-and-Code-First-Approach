using Clase_1.Dtos;
using Clase_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Clase_1.Controllers
{
    [ApiController] // Specifies that this class is a controller with API-specific features.
    [Route("api/[controller]")] // Defines the route template for this controller.
    public class ToDoItemController : Controller
    {
        private ToDoContext toDoContext; // Context for accessing database through Entity Framework.

        // Constructor initializes a new database context.
        public ToDoItemController()
        {
            toDoContext = new ToDoContext();
        }

        // GET method to fetch all ToDoItem entries.
        [HttpGet]
        public ActionResult Get()
        {
            // Retrieve all items and include related 'Categoria' data.
            var listaItems = toDoContext.Items.Include(x => x.Categoria).ToList();

            // Create a list to hold DTOs.
            List<DtoItem> listaDto = new List<DtoItem>();

            // Convert domain models to DTOs.
            foreach (var item in listaItems)
            {
                listaDto.Add(new DtoItem
                {
                    Id = item.Id,
                    NombreTarea = item.NombreTarea,
                    EstaCompleta = item.EstaCompleta,
                    CategoriaNombre = item.Categoria.Nombre
                });

            }

            // Return 404 NotFound if no items found, otherwise return 200 OK with data.
            if (listaDto == null) 
                return NotFound();
            return Ok(listaDto);
        }

        [HttpPost]
        public ActionResult Create([FromBody] DtoItemPost itemPost)
        {
            // Create a new ToDoItem from the DTO data.
            ToDoItem item = new ToDoItem
            {
                Id = Guid.NewGuid(),
                NombreTarea = itemPost.NombreTarea,
                EstaCompleta = itemPost.EstaCompleta,
                CategoriaId = itemPost.CategoriaId
            };

            // Add the new item to the context and save changes.
            var entity = toDoContext.Items.Add(item).Entity;
            var response = toDoContext.SaveChanges();

            // Check if the item was saved successfully.
            if (response == 0)
            {
                return BadRequest("No se pudo guardar en la base.");
            }
            return Ok("Se guardo exitosamente.");
        }

        [HttpPut]
        public ActionResult Put([FromBody] DtoItemPut dtoItemPut)
        {
            // Find the existing item.
            var item = toDoContext.Items.FirstOrDefault(x => x.Id == dtoItemPut.Id);

            // Update properties from the DTO.
            item.NombreTarea = dtoItemPut.NombreTarea;
            item.EstaCompleta = dtoItemPut.EstaCompleta;
            item.CategoriaId = dtoItemPut.CategoriaId;

            // Update the item in the database.
            toDoContext.Items.Update(item);
            var response = toDoContext.SaveChanges();
            
            if (response == 0)
            {
                return BadRequest("No se pudo guardar en la base.");
            }
            return Ok("Se edito exitosamente.");

        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] Guid id)
        {
            // Find the item to be deleted.
            var item = toDoContext.Items.FirstOrDefault(x => x.Id == id);
            if (item == null) return NotFound();

            // Remove the item from the database.
            toDoContext.Items.Remove(item);
            var response = toDoContext.SaveChanges();
            
            if (response == 0)
            {
                return BadRequest("No se pudo guardar en la base.");
            }
            return Ok("El registro se elimino con exito.");
        }
    }
}
