class Library
{
    private readonly List<LibraryItem> items;
    public Library(List<LibraryItem> list)
    {
        items = [.. list];
    }
    public void AddItemsToLibraryItems(LibraryItem item)
    {

        items.Add(item);
    }
    public void ShowAvailableItems()
    {

        Console.WriteLine("List of available items");
        foreach (var item in items)
        {
            if (item.IsAvailable)
            {
                Console.WriteLine(item.Title);
            }
        }
    }
    public void showBorrowedItems()
    {
        Console.WriteLine("List of Borrowed items");
        foreach (var item in items)
        {
            if (!item.IsAvailable)
            {
                Console.WriteLine(item.Title);
            }
        }
    }
}
/*
I need to implement
AddItemsToLibraryItems
ShowAvailableItems
*/