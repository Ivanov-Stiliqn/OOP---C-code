using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCatalog
{
    public class Computer
    {
        private string name;
        private Component processor;
        private Component graphicsCard;
        private Component motherBoard;
        private Component screen;
        private Component wirelessCard;
        private double price;

        public Computer(string name)
        {
            this.PCName = name;
        }
        public Computer(string name, Component processor = null, Component graphicsCard = null,
            Component motherBoard = null, Component screen = null, Component wirelessCard = null)
            :this(name)
        {
            this.Processor = processor;
            this.GraphicsCard = graphicsCard;
            this.Motherboard = motherBoard;
            this.Screen = screen;
            this.WirelessCard = wirelessCard;
            this.Price = getPrice(this.processor, this.graphicsCard, this.motherBoard, this.screen, this.wirelessCard);
        }
        
        public string PCName
        {
            get
            {
                return this.name;
            }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new Exception("PC name cannot be empty string");
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public Component Processor
        {
            get
            {
                return this.processor;
            }
            private set
            {
                this.processor = value;
            }
        }
        public Component Motherboard
        {
            get
            {
                return this.motherBoard;
            }
            private set
            {
                this.motherBoard = value;
                
            }
        }
        public Component GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }
            private set
            {
                this.graphicsCard = value;
            }
        }
        public Component Screen
        {
            get
            {
                return this.screen;
            }
            private set
            {
                this.screen = value;
            }
        }
        public Component WirelessCard
        {
            get
            {
                return this.wirelessCard;
            }
            set
            {
                this.wirelessCard = value;
            }
        }
        public double Price
        {
            get 
            {
                return this.price;
            }
            private set 
            {
                this.price = value;
            }
        }
        public double getPrice(Component processor, Component graphicsCard,Component motherBoard, Component screen, Component wirelessCard)
        {
            double price = 0;
            if(processor!=null)
            {
                price += processor.Price;
            }
            if (graphicsCard!= null)
            {
                price += graphicsCard.Price;
            }
            if (motherBoard != null)
            {
                price += motherBoard.Price;
            }
            if (screen != null)
            {
                price += screen.Price;
            }
            if (wirelessCard != null)
            {
                price += wirelessCard.Price;
            }
            return price;
        }
        public override string ToString()
        {
            string output = this.name+": ";
            if (this.processor != null)
            {
                output += "\nProcessor - " + this.processor;
            }
            if (this.graphicsCard != null)
            {
                output += "\nGraphics card - " + this.graphicsCard;
            }
            if (this.motherBoard != null)
            {
                output += "\nMotherboard - " + this.motherBoard;
            }
            if (this.screen != null)
            {
                output += "\nScreen - " + this.screen;
            }
            if (this.wirelessCard != null)
            {
                output += "\nWireless card - " + this.wirelessCard;
            }
            output += "\nTotal computer price: " + getPrice(this.processor, this.graphicsCard, this.motherBoard, this.screen, this.wirelessCard)+"\n";
            return output;
        }
    }
}
