namespace StartingPoint
{
    /// <summary>
    /// Price codes
    /// </summary>
    public enum PriceCodes
	{
		Regular,
		NewRelease,
		Childrens
	}
	/// <summary>
	/// Movie is just a simple data class.
	/// </summary>
	public class Movie
	{
		/* Fields */

		// Price code constants changed to enum

		// Data members

		public Movie(string title, PriceCodes priceCode)
		{
			Title = title;
			PriceCode = priceCode;
		}

		/* Properties */
		public PriceCodes PriceCode { get; set; }
	    public string Title { get; }
	}
}
