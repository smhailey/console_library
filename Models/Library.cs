using System;
using System.Collections.Generic;
namespace console_library.Models
{
  public class Library
  {
    public string Name { get; private set; }
    private List<Book> Books { get; set; }
    public void AddBook(Book book)
    {
      Books.Add(book);
    }
    public List<Book> CheckedOut { get; set; }
    public void PrintBooks()
    {
      foreach (Book book in Books)
      {
        Console.WriteLine($"{book.Title} by {book.Author} - {(book.Available ? "Available" : "Checked out")}");
      }
    }



    public void Checkout(string selection)
    {
      Book selectedBook = ValidateBook(selection, Books);

      if (selectedBook == null)
      {
        Console.Clear();
        System.Console.WriteLine(@"Invalid Selection");
        return;
      }
    }





    private Book ValidateBook(string selection, List<Book> bookList)
    {
      //we start the index at 0 (this will make sense later).
      int bookIndex = 0;
      bool valid = Int32.TryParse(selection, out bookIndex);
      if (!valid || bookIndex < 1 || bookIndex > bookList.Count)
      {
        return null;
      }
      return bookList[bookIndex - 1];
    }






    public void ReturnBook(string selection)
    {
      // REVIEW Should ValidBook below be ValidateBook?
      Book selectedBook = ValidateBook(selection, CheckedOut);

      if (selectedBook == null)
      {
        System.Console.WriteLine(@"Invalid Selection, please make a valid selection.
        ");
        return;
      }
      selectedBook.Available = true;
      Books.Add(selectedBook);
      CheckedOut.Remove(selectedBook);
      Console.Clear();
      Console.WriteLine("Successfully Returned Book!");
    }





    public Library(string name)
    {
      Name = name;
      Books = new List<Book>();
      List<Book> CheckedOut = new List<Book>();
    }
  }
}