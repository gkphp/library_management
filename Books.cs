class Book : LibraryItem
{
    public Book(string Title, string Author, DateOnly PublicationYear) : base(Title)
    {
        this.Title = Title;
        this.Author = Author;
        this.PublicationYear = PublicationYear;
    }

    public string Author { get; set; }
    public DateOnly PublicationYear { get; set; }

}