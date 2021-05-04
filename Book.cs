using System;
namespace newToCsharp
{
    class Book
    {
        //CLASS ATTRIBUTES
        public string title;
        public string author;
        public int pages;


        //construtor --> A method inside of a class that gets
        //...called when we create an instance(object) of the class
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
