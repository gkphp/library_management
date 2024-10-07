class Magazines : LibraryItem
{
    public Magazines(string IssueNumber, string PublicationMonth, string Title) : base(Title)
    {
        this.IssueNumber = IssueNumber;
        this.PublicationMonth = PublicationMonth;
    }
    public string IssueNumber { get; set; }
    public string PublicationMonth { get; set; }
}