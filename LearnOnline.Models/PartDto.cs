namespace LearnOnline.Models
{
    public class PartDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public byte[] Record { get; set; }
        public int Score { get; set; }
        public int CategoryId { get; set; }
        public int SkillId { get; set; }
        public int LevelId { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public string Question1 { get; set; }
        public string Question2 { get; set; }
        public string Question3 { get; set; }
        public string Question4 { get; set; }
        public string Question5 { get; set; }
        public string Result1 { get; set; }
        public string Result2 { get; set; }
        public string Result3 { get; set; }
        public string Result4 { get; set; }
        public string Result5 { get; set; }
    }
}
