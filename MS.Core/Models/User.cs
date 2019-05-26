using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS.Core.Models
{
    public class User : IdentityUser<Guid>,IComparer<User>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime BirthDate { get; set; }
        public bool? Sex { get; set; }
        public long Wage { get; set; }
        public int AccessModifier { get; set; }
        public Department Department { get; set; }
        public string Position { get; set; }
        public double Rating { get; set; }
        public virtual List<Job> Jobs { get; set; }

        public int Compare(User x, User y)
        {
            return (int)(x.Rating - y.Rating);
        }
    }
}
