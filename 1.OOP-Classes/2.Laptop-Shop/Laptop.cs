namespace LaptopShop
{
    using System;
    using System.Text;
    public class Laptop
    {

        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hardDisc;
        private string screen;
        private decimal price;



        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, decimal price, string manufacturer = null, string processor = null, string ram = null,
            string graphicsCard = null, string hardDisc = null, string screen = null, Battery battery = null)
            : this(model, price)
        {
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.HardDisc = hardDisc;
            this.Screen = screen;
            this.Battery = battery;

        }
        public Laptop(string model, decimal price, string manufacturer, string processor, string ram,
           string graphicsCard, string hardDisc, string screen, string batteryType, double batteryLifeInHours)
            : this(model, price, manufacturer, processor, ram, graphicsCard, hardDisc, screen, new Battery(batteryType, batteryLifeInHours))
        {

            this.Battery = new Battery(batteryType, batteryLifeInHours);

        }



        public string Model
        {

            get
            {
                return this.model;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException();
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {

                return this.manufacturer;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException();
                } this.manufacturer = value;
            }
        }

        public string Processor
        {
            get
            {

                return this.processor;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException();
                }
                this.processor = value;
            }
        }

        public string Ram
        {
            get
            {

                return this.ram;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException();
                }
                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get
            {

                return this.graphicsCard;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException();
                }
                this.graphicsCard = value;
            }
        }

        public string HardDisc
        {
            get
            {

                return this.hardDisc;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException();
                }
                this.hardDisc = value;
            }
        }

        public string Screen
        {
            get
            {

                return this.screen;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException();
                }
                this.screen = value;
            }
        }

        public Battery Battery { get; set; }
        public decimal Price
        {
            get
            {

                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Model: ");
            result.Append(this.Model);
            if (this.Manufacturer != null)
            {
                result.Append("; Manufacturer: ");
                result.Append(this.Manufacturer);
            }
            if (this.Processor != null)
            {
                result.Append("; Processor: ");
                result.Append(this.Processor);
            }
            if (this.Ram != null)
            {
                result.Append("; Ram: ");
                result.Append(this.Ram);
            }
            if (this.GraphicsCard != null)
            {
                result.Append("; GraphicsCard: ");
                result.Append(this.GraphicsCard);
            }
            if (this.HardDisc != null)
            {
                result.Append("; HDD: ");
                result.Append(this.HardDisc);
            }
            if (this.Screen != null)
            {
                result.Append("; Screen: ");
                result.Append(this.Screen);
            }
            if (this.Battery != null)
            {
                result.Append("; Battery: ");
                result.Append(this.Battery);
            }
            result.Append("; Price: ");
            result.Append(this.Price);
            result.Append(" lv.");


            return result.ToString();
        }
    }
}
