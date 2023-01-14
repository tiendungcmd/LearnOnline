using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LearnOnline.Models.Entities
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public int PartId { get; set; }
        public string Content { get; set; }
        public string Result { get; set; }
        public Part Part { get; set; }
    }
}
