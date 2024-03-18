namespace Mission11_Foote.Models.ViewModels
{
    //since the index page can only take one thing, we package the books and PaginationInfo in here to pass to intex
    public class BookListModel
    {
        public IQueryable<Book> Books { get; set;}
        public PaginationInfo PaginationInfo { get; set;}=new PaginationInfo();
    }
}
