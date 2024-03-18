namespace Mission11_Foote.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }

}
