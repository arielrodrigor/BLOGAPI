using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class CommentsController : ControllerBase
{
    private readonly ICommentRepository _commentRepository;

    public CommentsController(ICommentRepository commentRepository)
    {
        _commentRepository = commentRepository;
    }

    [HttpGet("post/{postId}")]
    public async Task<ActionResult<IEnumerable<Comment>>> GetCommentsByPostId(int postId)
    {
        var comments = await _commentRepository.GetCommentsByPostIdAsync(postId);
        return Ok(comments);
    }

    [HttpPost]
    public async Task<ActionResult> CreateComment(Comment comment)
    {
        await _commentRepository.AddCommentAsync(comment);
        return CreatedAtAction(nameof(GetCommentsByPostId), new { postId = comment.PostId }, comment);
    }
}