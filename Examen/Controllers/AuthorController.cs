using Examen.Models.Author.Dto;
using Examen.Models.Author.Dto.WithBooks;
using Examen.Services.AuthorService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AuthorResponseDto>>> GetAuthors()
        {
            var authors = await _authorService.GetAuthors();
            return Ok(authors);
        }

        [HttpPost]
        public async Task<ActionResult<AuthorResponseDto>> CreateAuthor(AuthorRequestDto author)
        {
            var newAuthor = await _authorService.CreateAuthor(author);
            return Ok(newAuthor);
        }

        [HttpPost("books")]
        public async Task<ActionResult<AuthorWithBooksResponseDto>> CreateAuthorWithBooks(AuthorWithBooksRequestDto author)
        {
            var newAuthor = await _authorService.CreateAuthorWithBooks(author);
            return Ok(newAuthor);
        }
    }
}