﻿namespace HRIS.Models
{
    public class UserForAuthModel
    {
        public int Id { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
