namespace PublisherDomain;

/// <summary>
/// 
/// </summary>
/// <remarks>One book Can be written by only one Author</remarks>
public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public DateTime PublishDate { get; set; }
    public decimal BasePrice { get; set; }

    public Author Author { get; set; }
    public int AuthorId { get; set; }
}