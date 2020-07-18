using System;
using System.Collections.Generic;

namespace Mikechat.Models
{
    public partial class LoginByUsernamePassword
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
