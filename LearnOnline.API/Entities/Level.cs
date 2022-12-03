﻿using System.ComponentModel.DataAnnotations;

namespace LearnOnline.API.Entities
{
    public class Level
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string LevelName { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
    }
}
