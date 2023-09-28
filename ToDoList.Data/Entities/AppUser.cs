using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Data.Entities
{
    public class AppUser
    {
        [Key]
        public int Id { get; set; }
        public string Task { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set;}
    }
}
