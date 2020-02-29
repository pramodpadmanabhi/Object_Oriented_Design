using System;
using System.Collections.Generic;
using System.Text;
namespace Object_Oriented_Design
{
    public class Guitar
    {
        private string serialNumber, model;
        private EnumDefinition.Type type;
        private EnumDefinition.Builder builder;
        private EnumDefinition.Wood backWood;
        private EnumDefinition.Wood topWood;
        
        private double price;

        public Guitar() { }
        public Guitar(string serialNumber,double price, EnumDefinition.Builder builder,string model, EnumDefinition.Type type, EnumDefinition.Wood backWood, EnumDefinition.Wood topWood)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
        }

        public string getSerialNumber()
        {
            return serialNumber;
        }
        public double getPrice()
        {
            return price;
        }
        public void setPrice(float newPrice)
        {
            this.price = newPrice;
        }
        public string getBuilder()
        {
            return builder.ToString();
        }
        public string getModel()
        {
            return model;
        }
        public string getType()
        {
            return type.ToString();
        }
        public string getBackWood()
        {
            return backWood.ToString();
        }
        public string getTopWood()
        {
            return topWood.ToString();
        }
    }

}
