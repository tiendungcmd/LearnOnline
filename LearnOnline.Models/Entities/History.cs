using LearnOnline.Models.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace LearnOnline.Models
{
    public class History
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Part Part { get; set; }
        public int PartId { get; set; }
        public int TotalScore { get; set; }
        public User User { get; set; }
        public int IdUser { get; set; }
        public string Email { get; set; }
    }
}
