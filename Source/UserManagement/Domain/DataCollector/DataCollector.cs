using System;
using System.Collections.Generic;
using Concepts;
using doLittle.Domain;
using Domain.DataCollector.Add;
using Domain.DataCollector.PhoneNumber;
using Domain.DataCollector.Update;
using Events.DataCollector;

namespace Domain.DataCollector
{
    public class DataCollector : AggregateRoot
    {
        private readonly List<string> _numbers;
        public DataCollector(Guid id) : base(id)
        {
            _numbers = new List<string>();
        }

        #region VisibleCommands

        public void AddDataCollector(
            string fullName, string displayName,
            int yearOfBirth, Sex sex, Guid nationalSociety, Language preferredLanguage,
            Location gpsLocation, string email, List<string> phoneNumbers
            )
        {
            Apply(new DataCollectorAdded
            {
                DataCollectorId = EventSourceId,

                FullName = fullName,
                DisplayName = displayName,
                YearOfBirth = yearOfBirth,
                Sex = (int)sex,
                NationalSociety = nationalSociety,
                PreferredLanguage = (int)preferredLanguage,
                RegisteredAt = DateTimeOffset.UtcNow,
                
                LocationLongitude = gpsLocation.Longitude,
                LocationLatitude = gpsLocation.Latitude
                //TODO: Need email?
            });

            AddPhoneNumbers(phoneNumbers);
        }

        public void UpdateDataCollector(
            string fullName, string displayName,
            Guid nationalSociety, Language preferredLanguage,
            Location gpsLocation, string email, List<string> phoneNumbersAdded,
            List<string> phoneNumbersRemoved
            )
        {
            // Apply DataCollectorUpdated event
            Apply(new DataCollectorUpdated
            {
                DataCollectorId = EventSourceId,
                DisplayName = displayName,
                Email = email,
                FullName = fullName,
                LocationLatitude = gpsLocation.Latitude,
                LocationLongitude = gpsLocation.Longitude,
                NationalSociety = nationalSociety,
                PreferredLanguage = (int)preferredLanguage,
                
            });
            AddPhoneNumbers(phoneNumbersAdded);
            RemovePhoneNumbers(phoneNumbersRemoved);
        }

        public void AddPhoneNumber(string number)
        {
            if (_numbers.Contains(number)) return;
            
            Apply(new PhoneNumberAddedToDataCollector(
                EventSourceId,
                number
            ));
        }
        public void RemovePhoneNumber(string number)
        {
            if (!_numbers.Contains(number)) return;
            

            Apply(new PhoneNumberRemovedFromDataCollector(
                EventSourceId,
                number
            ));
        }


        #endregion

        #region PhoneNumber

        private void AddPhoneNumbers(IReadOnlyCollection<string> numbers)
        {
            if (numbers == null || numbers.Count <= 0) return;
            foreach (var number in numbers)
            {
                Apply(new PhoneNumberAddedToDataCollector(
                    EventSourceId, 
                    number
                ));
            }
        }

        private void RemovePhoneNumbers(IReadOnlyCollection<string> numbers)
        {
            if (numbers == null || numbers.Count <= 0) return;
            foreach (var number in numbers)
            {
                Apply(new PhoneNumberRemovedFromDataCollector(
                    EventSourceId,
                    number
                ));
            }
        }
        #endregion

        #region On-methods

        private void On(PhoneNumberAddedToDataCollector @event)
        {
            _numbers.Add(@event.PhoneNumber);
        }

        private void On(PhoneNumberRemovedFromDataCollector @event)
        {
            _numbers.Remove(@event.PhoneNumber);
        }

        #endregion
    }
}
