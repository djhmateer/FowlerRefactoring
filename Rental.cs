namespace StartingPoint
{
    /// <summary>
    /// Rental represents a customer renting a movie.
    /// </summary>
    public class Rental
	{
		/* Fields */

		// Data members

	    /* Constructor */

		public Rental(Movie movie, int daysRented)
		{
			Movie = movie;
			DaysRented = daysRented;
		}

		/* Properties */
		public int DaysRented { get; }
	    public Movie Movie { get; }
	}
}
