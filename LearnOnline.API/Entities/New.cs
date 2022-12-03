﻿using System.ComponentModel.DataAnnotations;

namespace LearnOnline.API.Entities
{
    public class New
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public int IdUser { get; set; }
    }
}
