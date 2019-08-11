using System.Collections.Generic;
using System;
namespace console_library.Models
{

  public class Library
  {
    public List<Book> Books { get; set; }

  }
  public void AddBook(Book book)
  {
    Books.Add(book);
  }
}