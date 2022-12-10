﻿using System.Collections.Generic;

namespace LearnOnline.API.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Email { get; set; }
        public ICollection<New> News { get; set; }
    }
}
