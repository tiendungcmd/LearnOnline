using System;

namespace LearnOnline.Models
{
    public class HistoryDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int PartId { get; set; }
        public int TotalScore { get; set; }
        public string UserName { get; set; }
        public int IdUser { get; set; }
        public string PartTitle { get; set; }

        public string Skill { get; set; }
    }
}
