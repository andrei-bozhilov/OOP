using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    public class Components
    {
        private string name;
        private string details;
        private decimal price;

        public Components(string name, decimal price, string details)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }
        public Components(string name, decimal price)
            : this(name, price, null)
        {

        }


        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Name cannot be empty", "Name");
                }
                this.name = value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Cannot put empty string to this field. The field is optional, you can skip it.", "Details");
                }
                this.details = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative");
                }
                this.price = value;
            }
        }

    }
}
