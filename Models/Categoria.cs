﻿namespace Clase_1.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<ToDoItem> ToDoItems { get; set; }
    }
}