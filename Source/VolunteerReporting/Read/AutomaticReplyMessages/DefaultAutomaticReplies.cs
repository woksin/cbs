/*---------------------------------------------------------------------------------------------
 *  Copyright (c) The International Federation of Red Cross and Red Crescent Societies. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System;
using MongoDB.Driver;
using System.Collections.Generic;
using Concepts.AutomaticReply;

namespace Read.AutomaticReplyMessages
{
    public class DefaultAutomaticReplies : ExtendedReadModelRepositoryFor<DefaultAutomaticReply>,
        IDefaultAutomaticReplies
    {
        public DefaultAutomaticReplies(IMongoDatabase database)
            : base(database)
        {
        }

        public IEnumerable<DefaultAutomaticReply> GetAll()
        {
            return GetMany(_ => true);
        }
        public void SaveDefaultAutomaticReply(Guid id, int type, string language, string message)
        {
            Update(new DefaultAutomaticReply(id)
            {
                Language = language,
                Message = message,
                Type = (AutomaticReplyType)type
            });
        }


        public DefaultAutomaticReply GetByTypeAndLanguage(AutomaticReplyType type, string language)
        {
            return GetOne(v => v.Type == type && v.Language == language);
        }
    }
}
