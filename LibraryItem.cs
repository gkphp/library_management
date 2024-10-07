class LibraryItem
{
    public LibraryItem(string Title)
    {
        this.Title = Title;
        this.IsAvailable = true;
    }

    public string Title { get; set; }
    public bool IsAvailable { get; set; }

    public void BorrowItem()
    {
        Console.WriteLine($"Borrowing {Title}");
        IsAvailable = false;
    }
}