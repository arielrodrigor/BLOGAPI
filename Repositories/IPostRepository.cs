using System.Collections.Generic;
using System.Threading.Tasks;


public interface IPostRepository
{
    Task<IEnumerable<Post>> GetPostsAsync();
    Task<Post> GetPostByIdAsync(int id);
    Task AddPostAsync(Post post);
    Task UpdatePostAsync(Post post);
    Task DeletePostAsync(int id);
}