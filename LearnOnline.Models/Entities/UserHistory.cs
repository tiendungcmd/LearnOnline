using System.ComponentModel.DataAnnotations;

namespace LearnOnline.Models
{
    public class UserHistory
    {
        public User User { get; set; }
        [Key]
        public int UserId { get; set; }
        public History History { get; set; }
        [Key]
        public int HistoryId { get; set; }
    }
}
