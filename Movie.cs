using System;
namespace newToCsharp
{
    public class Movie
    {
        //CLASS ATTRIBUTES
        public string title;
        public string director;
        private string rating;


        //CONSTRUCTOR
        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        //SETTER AND GETTER
        public string Rating
        {
            get { return rating; }
            set {
                if (value == "G" )
                {
                    rating = value;
                }
                else if(value == "PG")
                {
                    rating = value;
                }
                else if (value == "PG-13")
                {
                    rating = value;
                }
                else if (value == "R")
                {
                    rating = value;
                }
                else if (value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
