using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    public enum Genre
    {
        Action = 1,
        Comedy,
        Drama,
        Horror,
        SciFi
    }
    internal class Movie
    {
        public int Id;
        public string Name;
        public int Year;
        public Genre Genre;
        public int Views;
        public int Likes;

        public double GetRating()
        {
            return Math.Sqrt(Math.Pow(Likes, 2) / Views);
        }

        public override string ToString()
        {
            string year = "(" + Year + ")";
            return $"{Id,4}{Name,-15}{year,-8}{Genre,-12}{GetRating(),8:F3}";
        }
    }
}
