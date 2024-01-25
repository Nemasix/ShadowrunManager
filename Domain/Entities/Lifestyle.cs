using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Lifestyle : BaseEntity
    {
        public string? Name { get; set; }
        public int? Cost { get; set; }
        public int? Level { get; set; }
        public string? Address { get; set; }
        public string? Town { get; set; }
        public string? Country { get; set; }
        public string? Notes { get; set; }
    }
}