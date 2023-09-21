namespace Book_Store.Classes
{
	public class Store
	{
		List<Rent> booksRented;
		List<Rent> booksDelayed;

		List<Sale> booksSell;

		Sale lastSale;
		Rent lastRent;

		public void rentBook(Rent rent)
		{
			lastRent = rent;
			booksRented.Add(lastRent);
		}

		public void sellBook(Sale sale)
		{
			lastSale = sale;
			booksSell.Add(lastSale);
		}

		public List<Rent> toReturn()
		{
			List<Rent> books = new List<Rent>();
			foreach (Rent book in booksRented)
			{
				if (book.ReturnDateTime.Day == DateTime.Now.Day)
				{
					books.Add(book);
				}
			}
			return books;
		}

		public void bookReturned(Rent book)
		{
			if (booksRented.Contains(book))
			{
				booksRented.Remove(book);
			}
			//(booksRented.Contains(book)) ? booksRented.Remove(book) : ;
		}

		public bool putSale()
		{
			if (checkLastRentTransactionDuration() || checkLastSaleTransactionDuration())
			{
				return true;
			}

			return false;
		}

		public bool checkLastRentTransactionDuration()
		{
			if (DateTime.Now.Day - lastRent.DateTime.Day >= 14)
			{
				return true;
			}

			return false;
		}

		public bool checkLastSaleTransactionDuration()
		{
			if (DateTime.Now.Day - lastSale.DateTime.Day >= 14)
			{
				return true;
			}

			return false;
		}
	}
}
