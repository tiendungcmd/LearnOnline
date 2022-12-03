using System.ComponentModel.DataAnnotations;

namespace LearnOnline.API.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
