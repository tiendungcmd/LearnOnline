using System.ComponentModel.DataAnnotations;

namespace LearnOnline.Models.Entities
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Question Question { get; set; }
    }
}
