namespace Mission11_Foote.Models.ViewModels
{
    public class BookListModel
    {
        public IQueryable<Book> Books { get; set;}
        public PaginationInfo PaginationInfo { get; set;}=new PaginationInfo();
    }
}
