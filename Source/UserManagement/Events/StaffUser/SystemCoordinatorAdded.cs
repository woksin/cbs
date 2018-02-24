using System;
using System.Collections.Generic;
using System.Text;
using doLittle.Events;

namespace Events.StaffUser
{
    public class SystemCoordinatorAdded : IEvent
    {
        public Guid Id { get; private set; }
        public string FullName { get; private set; }
        public string DisplayName { get; private set; }
        public string Email { get; private set; }
        public int YearOfBirth { get; private set; }
        public int Sex { get; private set; }
        public Guid NationalSociety { get; private set; }
        public int PreferredLanguage { get; private set; }
        public double LocationLongitude { get; private set; }
        public double LocationLatitude { get; private set; }
        public string MobilePhoneNumber { get; private set; }
        public bool MobilePhoneNumberConfirmed { get; } = true;
        public Guid AssignedNationalSociety { get; private set; }

        public SystemCoordinatorAdded(Guid id, string fullName, string displayName, string email, 
            int yearOfBirth, int sex, Guid nationalSociety, int preferredLanguage, double locationLongitude, 
            double locationLatitude, string mobilePhoneNumber, Guid assignedNationalSociety)
        {
            Id = id;
            FullName = fullName;
            DisplayName = displayName;
            Email = email;
            YearOfBirth = yearOfBirth;
            Sex = sex;
            NationalSociety = nationalSociety;
            PreferredLanguage = preferredLanguage;
            LocationLongitude = locationLongitude;
            LocationLatitude = locationLatitude;
            MobilePhoneNumber = mobilePhoneNumber;
            AssignedNationalSociety = assignedNationalSociety;
        }
    }
}