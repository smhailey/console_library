using System;
using console_library.Models;
namespace console_library
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Book whereTheSidewalkEnds = new Book("Where the Sidewalk Ends", "Shel Silverstein");
    }
  }

  public void PrintBooks()
  {
    for (int i = 0; i < Books.Count; i++)
    {
      Console.WriteLine($"{i + 1} {Books[i].Title} - {Books[i].Author}");
    }
  }



}
