using System.ComponentModel.DataAnnotations;

namespace LearnOnline.Models.Entities
{
    public class Answer
    {
        [Key]
        public string Id { get; set; }
        public int PartId { get; set; }
        public string Content { get; set; }

        public bool CorrectAnswer { get; set; }
        public Part Part { get; set; }
    }
}
