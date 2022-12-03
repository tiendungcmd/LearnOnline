using System.ComponentModel.DataAnnotations;

namespace LearnOnline.API.Entities
{
    public class Part
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        public int IdSkill { get; set; }
        public int IdLevel { get; set; }
        public int IdCategory { get; set; }
        public byte Record { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Answer { get; set; }
        [StringLength(255)]
        public string Style { get; set; }
        public int Score { get; set; }
        public string Note { get; set; }
    }
}
