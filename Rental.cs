namespace StartingPoint
{
    /// <summary>
    /// Rental represents a customer renting a movie.
    /// </summary>
    public class Rental
	{
        public int DaysRented { get; }
        public Movie Movie { get; }

        public Rental(Movie movie, int daysRented)
		{
			Movie = movie;
			DaysRented = daysRented;
		}

        public double GetCharge()
        {
            return Movie.GetCharge(DaysRented);
        }

        public int GetFrequentRenterPoints()
        {
            // Add bonus for a two-day new-release rental
            if ((Movie.PriceCode == PriceCodes.NewRelease) && (DaysRented > 1))
            {
                return 2;
            }
            return 1;
        }
	}
}
