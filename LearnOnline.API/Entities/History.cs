using System;
using System.ComponentModel.DataAnnotations;

namespace LearnOnline.API.Entities
{
    public class History
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Part Part { get; set; }
        public int PartId { get; set; }
        public int TotalScore { get; set; }
    }
}
