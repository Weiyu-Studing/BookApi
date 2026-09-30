namespace BookApi.Models;

public class Category
{
    public int Id { get; set; }
    public string CategoryName { get; set; }

    public List<BookCategory> BookCategories { get; set; } = new();
}

