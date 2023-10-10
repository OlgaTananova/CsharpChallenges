using System;
namespace movienight
{
    // MARK: Write your solution in this class
    public class Movie
    {
        public string title;
        public string rating;
        public int reviewScore;
        
        public bool Fresh { get; set; }

        public Movie(string title, string rating, int score)
        {
            this.title = title;
            this.reviewScore = score;
            this.rating = rating;
            if (reviewScore >= 75)
            {
                Fresh = true;
            }
            else
            {
                Fresh = false;
            }
        }

        public override string ToString()
        {
            return $"{title}\n\tRating: {rating}\n\t{reviewScore}% on RT {(Fresh? "- Certified Fresh": null)}";
        }
    }
}