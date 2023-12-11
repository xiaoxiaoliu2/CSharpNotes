using System;
namespace CSharpNotes
{
	class Book
	{
		// attributes about a book
		public string title;
		public string author;
		public int pages;


		// a constructor
		public Book(string aTitle, string aAuthor, int aPages)
		{
			title = aTitle;
			author = aAuthor;
			pages = aPages;
		}


	}
}

