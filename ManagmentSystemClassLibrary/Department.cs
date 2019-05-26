using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystemClassLibrary
{
    public class Department
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual List<User> Employees { get; set; }
    }
}
