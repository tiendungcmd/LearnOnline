using LearnOnline.Models.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LearnOnline.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public ICollection<Part> Parts { get; set; }
    }
}
