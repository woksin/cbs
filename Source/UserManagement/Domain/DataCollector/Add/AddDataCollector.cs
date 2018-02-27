/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2017 International Federation of Red Cross. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System;
using Concepts;
using doLittle.Commands;

namespace Domain.DataCollector.Add
{
    public class AddDataCollector : ICommand
    {
        public Guid DataCollectorId { get; set; }

        public string FullName { get; set; }
        public string DisplayName { get; set; }
        public int YearOfBirth { get; set; }
        public Sex Sex { get; set; }
        public Guid NationalSociety { get; set; }
        public Language PreferredLanguage { get; set; }
        public Location GpsLocation { get; set; }
        public string[] MobilePhoneNumbers { get; set; }
        public string Email { get; set; }
    }
}