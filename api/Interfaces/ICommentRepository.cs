using api.Models;

namespace api.Interfaces;

public interface ICommentRepository
{
    Task<List<Comment>> GetAllComments();
    
    Task<Comment> GetByIdAsync(int id);
}