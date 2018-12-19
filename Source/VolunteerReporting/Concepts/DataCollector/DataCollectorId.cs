/*---------------------------------------------------------------------------------------------
 *  Copyright (c) The International Federation of Red Cross and Red Crescent Societies. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System;
using Dolittle.Concepts;

namespace Concepts.DataCollector
{
    public class DataCollectorId : ConceptAs<Guid>
    {
        public static readonly DataCollectorId NotSet = Guid.Empty;
        
        public static implicit operator DataCollectorId(Guid id)
        {
            return new DataCollectorId { Value = id };
        }        
    }
}