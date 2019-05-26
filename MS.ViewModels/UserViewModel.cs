using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS.Core.ViewModels
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool? Sex { get; set; }
        public long Wage { get; set; }
        public int AccessModifier { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public double Rating { get; set; }
    }
}
