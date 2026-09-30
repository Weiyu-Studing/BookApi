namespace BookApi.Models;

public class BorrowRecord
{
    public int Id { get; set; }
    public string BorrowerName { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; }
}

