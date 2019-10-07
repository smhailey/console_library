using System;
using console_library.Models;

namespace console_library
{
  class Program
  {
    public bool InLibrary { get; set; }
    InLibrary = true;

    static void Main(string[] args)
    {
      Book whereTheSidewalkEnds = new Book("Where the Sidewalk Ends", "Shel Silverstein");
      Book theHobbit = new Book("The Hobbit", "J.R.R.Tolkien");
      // TODO Add more books?
      Library myLibrary = new Library("The Library");

      Console.Clear();
      Console.WriteLine($"Welcome to { myLibrary.Name}");

      myLibrary.AddBook(whereTheSidewalkEnds);
      myLibrary.AddBook(theHobbit);

      Enum activeMenu = Menus.CheckoutBook;
    }

    public static enum Menus
    {
      CheckoutBook,
      ReturnBook
    }


    public void PrintBooks()
    {
      for (int i = 0; i < Books.Count; i++)
      {
        Console.WriteLine($"{i + 1} {Books[i].Title} - {Books[i].Author}");
      }
    }


    



while (InLibrary)
{
    myLibrary.PrintBooks();
    string selection = Console.ReadLine();
    myLibrary.Checkout(selection);

// Welcome to The Library!

// Available Books:
// 1) Shel Silverstein - Where the Sidewalk Ends
// 2) J.R.R.Tolkien - The Hobbit
// 3) C.S.Lewis - The Lion, The Witch, and the Wardrobe
// 4) J.K.Rowling - Harry Potter and the Sorcerer's Stone

// Select a book number to checkout(Q)uit, or(R)eturn a book



            switch (activeMenu)
            {
                case Menus.CheckoutBook:
                    myLibrary.PrintBooks();
                    break;
                case Menus.ReturnBook:
                    myLibrary.PrintCheckedOut();
                    break;
            }



  string selection = Console.ReadLine();
        switch (selection)
        {
            case "R":
                Console.Clear();
                activeMenu = Menus.ReturnBook;
                break;
            case "A":
                Console.Clear();
                activeMenu = Menus.CheckoutBook;
                break;
            default:
                if (activeMenu.Equals(Menus.CheckoutBook))
                {
                    myLibrary.Checkout(selection);
                }
                else
                {
                    myLibrary.ReturnBook(selection);
                }
                break;
        }





  

string selection = Console.ReadLine();
myLibrary.Checkout(selection);




  }
}
}