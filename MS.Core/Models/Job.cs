using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS.Core.Models
{
    public class Job
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime Deadline { get; set; }
        public ReCreationTime ReCreationTime { get; set; }
        public State State { get; set; }
        public int Complexity { get; set; }
        public User User { get; set; }
        public Department Department { get; set; }
    }
}
