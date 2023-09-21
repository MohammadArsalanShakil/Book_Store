using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store.Classes
{
    public class Rent
    {
        Book book;
        DateTime dateTime;
		DateTime returnDateTime;

		public Rent(Book book, DateTime dateTime)
		{
			this.book = book;
			this.DateTime = dateTime;
			this.ReturnDateTime = dateTime.AddDays(7);
		}

		public Book Book { get => book; set => book = value; }
		public DateTime DateTime { get => dateTime; set => dateTime = value; }
		public DateTime ReturnDateTime { get => returnDateTime; set => returnDateTime = value; }
	}
}
