using System.Collections;

namespace StartingPoint
{
    /// <summary>
    /// Customer represents a customer of the store.
    /// </summary>
    public class Customer
	{
		/* Fields */
        private ArrayList  m_Rentals = new ArrayList();

		/* Constructor */
		public Customer(string name)
		{
			Name = name;
		}

		/* Properties */
		public string Name { get; }

        /* Methods */
		public void AddRental(Rental arg)
		{
			m_Rentals.Add(arg);
		}

		public string Statement()
		{
			double totalAmount = 0;
			int frequentRenterPoints = 0;
			IEnumerator rentals = m_Rentals.GetEnumerator();
			string result = "Rental record for " + Name + "\n";
            while (rentals.MoveNext())
            {
                Rental each = (Rental)rentals.Current;

                //frequentRenterPoints += each.GetFrequentRenterPoints();

                // Show figures for this rental
                result += "\t" + each.Movie.Title + "\t" + each.GetCharge() + "\n";
                //totalAmount += each.GetCharge();
            }

            // Add footer lines
            result += "Amount owed is " + GetTotalCharge() + "\n";
            result += "You earned " + GetTotalFrequentRentalPoints() + " frequent renter points.";
			return result;
		}

        private double GetTotalFrequentRentalPoints()
        {
            double result = 0;
            IEnumerator rentals = m_Rentals.GetEnumerator();
            while (rentals.MoveNext())
            {
                Rental each = (Rental)rentals.Current;
                result += each.GetFrequentRenterPoints();
            }
            return result;
        }

        private double GetTotalCharge()
        {
            double result = 0;
            IEnumerator rentals = m_Rentals.GetEnumerator();
            while (rentals.MoveNext())
            {
                Rental each = (Rental)rentals.Current;
                result += each.GetCharge();
            }
            return result;
        }
	}
}
