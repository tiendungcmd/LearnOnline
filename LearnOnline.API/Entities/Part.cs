using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LearnOnline.API.Entities
{
    public class Part
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        public int SkillId { get; set; }
        public int LevelId { get; set; }
        public int CategoryId { get; set; }
        public byte Record { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Answer { get; set; }
        [StringLength(255)]
        public string Style { get; set; }
        public int Score { get; set; }
        public string Note { get; set; }
        public Category Category { get; set; }
        public Skill Skill { get; set; }
        public Level Level { get; set; }
        public ICollection<History> Historys { get; set; }
    }
}
