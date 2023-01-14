using System;

namespace LearnOnline.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string ImageName { get; set; }
        public byte[] Data { get; set; } 
        public int PartId { get; set; }
    }
}
