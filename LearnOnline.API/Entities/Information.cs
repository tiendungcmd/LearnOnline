using System.ComponentModel.DataAnnotations;

namespace LearnOnline.API.Entities
{
    public class Information
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
    }
}
