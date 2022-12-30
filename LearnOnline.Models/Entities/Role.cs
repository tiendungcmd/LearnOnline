using System.ComponentModel.DataAnnotations;

namespace LearnOnline.Models
{
    public class Role
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string RoleName { get; set; }
    }
}
