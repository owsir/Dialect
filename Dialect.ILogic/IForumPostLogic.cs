﻿using System.Collections.Generic;
using Dialect.Model;

namespace Dialect.ILogic
{
    public interface IForumPostLogic
    {
        int InsertForumPost(ForumPost forumPost);
        IEnumerable<ForumPost> GetForumPosts();
        IEnumerable<ForumPost> GetForumPostsByForumId(int id);
        ForumPost GetForumPostByPostId(int postId);
        IEnumerable<ForumPost> GetPostsByUserId(int userid);
    }
}
