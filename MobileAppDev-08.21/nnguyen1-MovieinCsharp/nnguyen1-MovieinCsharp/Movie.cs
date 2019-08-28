using System;
namespace nnguyen1_MovieinCsharp
{
    public class Movie
    {
        public Movie(string name, Rating rating, Genre genre)
        {
            this.name = name;
            this.rating = rating;
            this.genre = genre;
        }

        public string name { get; set; }
        public Rating rating { get; set; }
        public Genre genre { get; set; }

        public override bool Equals(Object obj)
        {
            if (this == obj) return true;
            if (!(obj is Movie)) return false;
            Movie movie = (Movie)obj;
            return name == movie.name &&
                rating == movie.rating &&
                genre == movie.genre;
        }

        public override int GetHashCode()
        {
            int result = (name != null ? name.GetHashCode() : 0);
            result = (result * 397) ^ rating.GetHashCode();
            result = (result * 397) ^ genre.GetHashCode();
            return result;
        }

        public override string ToString()
        {
            return "Movie{" +
                "name='" + name + '\'' +
                ", rating=" + rating +
                ", genre=" + genre +
                '}';
        }
    }
}
