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

	    public double GetCharge(int daysRented)
	    {
            double thisAmount = 0;
            switch (PriceCode)
            {
                case PriceCodes.Regular:
                    thisAmount += 2;
                    if (daysRented > 2)
                    {
                        thisAmount += (daysRented - 2) * 1.5;
                    }
                    break;

                case PriceCodes.NewRelease:
                    thisAmount += daysRented * 3;
                    break;

                case PriceCodes.Childrens:
                    thisAmount += 1.5;
                    if (daysRented > 3)
                    {
                        thisAmount = (daysRented - 3) * 1.5;
                    }
                    break;
            }
            return thisAmount;
        }
	}
}
