using BookApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    private readonly AppDbContext _databaseContext;
    public BooksController(AppDbContext databaseContext)
    {
        _databaseContext = databaseContext;
    }


    [HttpGet]
    public async Task<ActionResult<List<Book>>> GetAllBooks()
    {
        return await _databaseContext.Books
            .Include(b => b.Author)
            .ToListAsync();
    }


    [HttpPost("borrow")]
    public async Task<ActionResult<BorrowRecord>> BorrowBook(BorrowRecord record)
    {
        _databaseContext.BorrowRecords.Add(record);
        await _databaseContext.SaveChangesAsync();
        return Created("", record);
    }
}

