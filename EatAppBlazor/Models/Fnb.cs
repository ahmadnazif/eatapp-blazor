using EatAppBlazor.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatAppBlazor.Models
{
    public class Fnb
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FnbType FnbType { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
