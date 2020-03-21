using System.Linq;
using System;

namespace DotNetCourceOOPBasics
{
    public class PropertiesAndIndexers
    {
        public string Name;
        public string[] Books = { "Book1", "Book2", "Book3" };

        public string GetName()
        {
            return Name;
        }

        public void SetName(string value)
        {
            Name = value;
        }

        public string this[string name]
        {
            get
            {
                return Books.FirstOrDefault(book => book == name);
            }
            set
            {
                SetBook(value, name);
            }
        }

        public string GetBook(string name)
        {
            return Books.FirstOrDefault(book => book == name);
        }

        public void SetBook(string value, string name)
        {
            var index = Array.IndexOf(Books, name);

            if (index < 0)
                return;

            Books[index] = value;
        }
    }
}