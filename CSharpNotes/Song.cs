using System;
namespace CSharpNotes
{
	public class Song
	{
		// a static attribute is fixed, is about the attribute of the class, not unique to each one of the objects
		public static int songCount = 0;  // how many song objects have been created
		// normal attribute is different for each objects, there are attribute of the objects, not the class itself
		public string title;
		public string artist;
		public int duration;

		public Song(string aTitle, string aArtist, int aDuration)
		{
			title = aTitle;
			artist = aArtist;
			duration = aDuration;
			songCount++;
		}

		public int getSongCount()
		{
			return songCount;
		}
	}
}

