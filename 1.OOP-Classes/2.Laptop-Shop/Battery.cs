
namespace LaptopShop
{
    using System;
    using System.Text;
    public class Battery
    {
        private string type;
        private double lifeInHours;

        public Battery()
        {

        }

        public Battery(string type, double lifeInHours = 0)
        {
            this.Type = type;
            this.LifeInhours = lifeInHours;
        }

        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException();
                }
                this.type = value;
            }
        }
        public double LifeInhours
        {
            get
            {
                return this.lifeInHours;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                this.lifeInHours = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("Battery type: ");
            result.Append(this.Type);
            if (this.lifeInHours != 0)
            {
                result.Append(" Battery life: ");
                result.Append(this.lifeInHours);
                result.Append("hours");
            }


            return result.ToString();
        }

    }
}
