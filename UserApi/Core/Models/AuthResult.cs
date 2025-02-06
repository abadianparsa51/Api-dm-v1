﻿namespace UserApi.Core.Models
{
    public class AuthResult
    {
        public string Token { get; set; } = "";
        public string Email { get; set; } = "";
        public bool Result { get; set; }
        public List<string>? Errors { get; set; }

    }
}
