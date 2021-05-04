using System;
namespace newToCsharp
{
    public class Song
    {

        //CLASS ATTRIBUTES
        public string title;
        public string artiste;
        public int duration;

        //STATIC ATTRIBUTE
        public static int songCount = 0;

        //CONSTRUCTOR
        public Song(string aTitle, string aArtiste, int aDuration)
        {
            title = aTitle;
            artiste = aArtiste;
            duration = aDuration;
            songCount ++;
        }
    }
}
