using System.ComponentModel.DataAnnotations;

namespace LearnOnline.Models
{
    public class New
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public byte[] Image { get; set; }
        public string Spelling { get; set; }
        public string  Topic { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }

    }
}
