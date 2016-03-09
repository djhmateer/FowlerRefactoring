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
            double thisAmount = 0;
            switch (Movie.PriceCode)
            {
                case PriceCodes.Regular:
                    thisAmount += 2;
                    if (DaysRented > 2)
                    {
                        thisAmount += (DaysRented - 2) * 1.5;
                    }
                    break;

                case PriceCodes.NewRelease:
                    thisAmount += DaysRented * 3;
                    break;

                case PriceCodes.Childrens:
                    thisAmount += 1.5;
                    if (DaysRented > 3)
                    {
                        thisAmount = (DaysRented - 3) * 1.5;
                    }
                    break;
            }
            return thisAmount;
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
