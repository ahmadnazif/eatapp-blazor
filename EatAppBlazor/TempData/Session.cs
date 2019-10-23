using EatAppBlazor.Common;
using EatAppBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatAppBlazor.TempData
{
    public class Session
    {
        private static SessionState State { get; set; }

        public static void Add(string username, UserRole role)
        {
            State = new SessionState
            {
                IsAuthenticated = true,
                Username = username,
                Role = role,
                AuthTime = DateTime.Now
            };
        }

        public static bool IsExist => State != null;

        public static SessionState GetCurrent() => State;

        public static void Destroy() => State = null;

    }
}
