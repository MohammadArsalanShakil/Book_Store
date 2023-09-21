using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store.Classes
{
    public class Sale
    {
        Book book;
        DateTime dateTime;

		public Sale(Book book, DateTime dateTime)
		{
			this.book = book;
			this.dateTime = dateTime;
		}

		public Book Book { get => book; set => book = value; }
		public DateTime DateTime { get => dateTime; set => dateTime = value; }
	}
}
