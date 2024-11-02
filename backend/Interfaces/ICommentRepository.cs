using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;

namespace backend.Interfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetAllAsync();
        Task<Comment?> GetByIdAsync(int id);
        Task<Comment> CreateAsync(Comment commentkModel);
        Task<Comment?> UpdateAsync(int id, Comment commentkModel);
        Task<Comment?> DeleteAsync(int id);
    }
}