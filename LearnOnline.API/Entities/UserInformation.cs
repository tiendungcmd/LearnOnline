using System.ComponentModel.DataAnnotations;

namespace LearnOnline.API.Entities
{
    public class UserInformation
    {
        public User User { get; set; }  
        [Key]
        public int UserId { get; set; }
        public Information Information { get; set; }
        [Key]
        public int InformationId { get; set; }
    }
}
