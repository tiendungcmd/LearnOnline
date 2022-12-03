using System.ComponentModel.DataAnnotations;

namespace LearnOnline.API.Entities
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string SkillName { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
    }
}
