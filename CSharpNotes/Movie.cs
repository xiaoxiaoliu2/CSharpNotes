using System;
namespace CSharpNotes
{
	class Movie
	{
		public string title;
		public string director;
        //public string rating;
        private string rating;   // can be used only in Movie class


		public Movie(string aTitle, string aDirector, string aRating)
		{
			title = aTitle;
			director = aDirector;
			rating = aRating;
		}


		// getters, and setters: to get the rating attribute, set/modify the rating attribute, so can be used in program even it's private
		public string Rating
		{
			get { return rating; }
			set {
				if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
				{
					rating = value;
				} else
				{
					rating = "NR";
				}
			}
		}


	}
}

