﻿using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Data.Repository
{
    public interface IRepository
    {
        Post GetPost(int Id);
        List<Post> GetAllPosts();
       
        void AddPost(Post post);
        void UpdatePost(Post post);
        void RemovePost(int Id);

        Task<bool> SaveChangesAsync();
    }
}
