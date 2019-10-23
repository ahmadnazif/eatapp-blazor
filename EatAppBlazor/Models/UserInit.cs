using EatAppBlazor.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatAppBlazor.Models
{
    public class UserInit
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public UserRole Role { get; set; }
    }
}
