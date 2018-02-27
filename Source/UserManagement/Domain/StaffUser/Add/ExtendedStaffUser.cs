using System;
using Concepts;

namespace Domain.StaffUser.Add
{
    public abstract class ExtendedStaffUser : BaseStaffUser
    {
        public Location Location { get; set; }
        public int YearOfBirth { get; set; }
        public Sex Sex { get; set; }
        public Guid NationalSociety { get; set; }
        public Language PreferredLanguage { get; set; }
        public string[] PhoneNumbers { get; set; }
    }
}