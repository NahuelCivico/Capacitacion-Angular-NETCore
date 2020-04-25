using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Data.Entities
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public bool isCompleted { get; set; }
        public string Conclution { get; set; }
    }
}
