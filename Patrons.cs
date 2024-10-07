class Patrons
{
    public Patrons(string Name)
    {
        this.Name = Name;
        BorrowItems = new List<LibraryItem>();
    }
    public string Name { get; set; }
    public List<LibraryItem> BorrowItems { get; set; }
    public void BorrowItem(LibraryItem item)
    {

        if (item.IsAvailable)
        {
            Console.WriteLine($"Borrowing item {item.Title}");
            item.IsAvailable = false;
            BorrowItems.Add(item);
        }
        else
        {
            Console.WriteLine($"Item {item.Title} is currently unavailable");
        }


    }
    public void ShowBorrowedItems()
    {
        Console.WriteLine($"Borrowed items by {Name}");
        foreach (var item in BorrowItems)
        {
            Console.WriteLine(item.Title);
        }
    }
}

