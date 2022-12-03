using System.ComponentModel.DataAnnotations;

namespace LearnOnline.API.Entities
{
    public class UserHistory
    {
        [Key]
        public int IdUser { get; set; }
        [Key]
        public int IdHistory { get; set; }
    }
}
