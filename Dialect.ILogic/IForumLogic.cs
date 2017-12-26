﻿using System.Collections.Generic;
using Dialect.Model;

namespace Dialect.ILogic
{
    public interface IForumLogic
    {
        int InsertForum(Forum forum);
        IEnumerable<Forum> GetForums();
    }
}
