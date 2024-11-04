using api.Models;

namespace api.Interfaces;

public interface ICommentRepository
{
    Task<List<Comment>> GetAllComments();
    
    Task<Comment?> GetByIdAsync(int id);
    
    Task<Comment> CreateAsync(Comment commentModel);
}