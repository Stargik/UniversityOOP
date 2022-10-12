using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Book : Product
    {
        public int PagesCount { get; }
        public string Publisher { get; }
        public List<string> Authors { get; }
        public Book(string name, string description, decimal price, string country, DateTime packageDate, int pagesCount, string publisher, List<string> authors)
            : base(name, description, price, country, packageDate)
        {
            PagesCount = pagesCount;
            Publisher = publisher;
            Authors = authors;
        }
    }
}
