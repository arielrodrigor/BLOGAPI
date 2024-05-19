using System.Collections.Generic;
using System.Threading.Tasks;

public interface ICommentRepository
{
    Task<IEnumerable<Comment>> GetCommentsByPostIdAsync(int postId);
    Task AddCommentAsync(Comment comment);
}