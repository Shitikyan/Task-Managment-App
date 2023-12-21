using System;
using System.ComponentModel.DataAnnotations;

namespace TaskTimeManager.Models
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
    }
}
