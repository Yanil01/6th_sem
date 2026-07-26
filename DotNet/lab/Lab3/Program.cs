class Book
{
    private string title;
    private string author;
    private int pages;
    
    public Book(string title, string author, int pages)
    {
        this.title = title;
        this.author = author;
        this.pages = pages;
    }
    public void PrintSummary()
    { 
        Console.WriteLine($"Title: {title}, Author: {author}, Pages: {pages}");
    }
   
}

class Program
{
    static void Main(string[] args)
    {
        Book b1 = new Book("The Hobbit", "Rayan Dawson", 300);
        Book b2 = new Book("The Lord of the Rings", "Harry Mark", 700);
        b1.PrintSummary();
        b2.PrintSummary();
        
    }
}