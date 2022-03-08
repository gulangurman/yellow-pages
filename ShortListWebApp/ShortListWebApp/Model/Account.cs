using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortListWebApp.Model
{
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        // password hash
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}
