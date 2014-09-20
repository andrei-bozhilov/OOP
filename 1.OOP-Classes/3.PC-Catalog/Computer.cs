namespace Catalog
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Computer
    {
        private string name;
        private decimal price;
        private string p1;
        private int p2;


        public Computer()
        {

        }
        public Computer(string name, decimal price, params Components[] components)
        {
            this.Name = name;
            this.Price = price;
            for (int i = 0; i < components.Length; i++)
            {
                this.Components.Add(components[i]);
            }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public List<Components> Components { get; set; }






    }
}
