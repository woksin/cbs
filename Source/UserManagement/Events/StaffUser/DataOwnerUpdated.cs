using System;
using doLittle.Events;

namespace Events.StaffUser
{
    public class DataOwnerUpdated : IEvent
    {
        public Guid StaffUserId { get; private set; }
        public string FullName { get; private set; }
        public string DisplayName { get; private set; }
        public string Email { get; private set; }

        public double GpsLocationLatitude { get; private set; }
        public double GpsLocationLongitude { get; private set; }

        public Guid NationalSociety { get; private set; }
        public int PreferredLanguage { get; private set; }

        public string Position { get; private set; }

        public DataOwnerUpdated(Guid staffUserId, string fullName, string displayName, string email, 
            double gpsLocationLatitude, double gpsLocationLongitude, Guid nationalSociety, int preferredLanguage, string position)
        {
            StaffUserId = staffUserId;
            FullName = fullName;
            DisplayName = displayName;
            Email = email;
            GpsLocationLatitude = gpsLocationLatitude;
            GpsLocationLongitude = gpsLocationLongitude;
            NationalSociety = nationalSociety;
            PreferredLanguage = preferredLanguage;
            Position = position;
        }
    }
}