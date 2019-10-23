using EatAppBlazor.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatAppBlazor.Models
{
    public class SessionState
    {
        public bool IsAuthenticated { get; set; }
        public string Username { get; set; }
        public UserRole Role { get; set; }
        public DateTime AuthTime { get; set; }
    }
}
