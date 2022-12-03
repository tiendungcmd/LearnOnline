using System;
using System.ComponentModel.DataAnnotations;

namespace LearnOnline.API.Entities
{
    public class History
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int IdPart { get; set; }
        public int TotalScore { get; set; }
    }
}
