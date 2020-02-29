using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Design
{
    public class Inventory
    {
        private List<Guitar> guitars; 

        public Inventory()
        {
            guitars = new List<Guitar>();
        }
        public void addGuitar(string serialNumber,double price, EnumDefinition.Builder builder,string model, EnumDefinition.Type type, EnumDefinition.Wood backWood, EnumDefinition.Wood topWood)
        {
            Guitar guitar = new Guitar(serialNumber, price, builder, model, type, backWood, topWood);
            guitars.Add(guitar);
        }
        public Guitar getGuitar(String serialNumber)
        {
            foreach(var guitar in guitars)
            {
                if (guitar.getSerialNumber().Equals(serialNumber))
                {
                    return guitar;
                }
            }
            return null;
        }
        public List<Guitar> Search(Guitar searchGuitar)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
           foreach(var guitar in guitars)
            {
                if (searchGuitar.getBuilder()!=guitar.getBuilder()) continue;

                string model = searchGuitar.getModel();
                if ((model != null) && (!model.Equals("")) && (!model.Equals(guitar.getModel()))) continue;

                if (searchGuitar.getType() != guitar.getType()) continue;

                if (searchGuitar.getBackWood() != guitar.getBackWood()) continue;

                if (searchGuitar.getTopWood() != guitar.getTopWood()) continue;

                matchingGuitars.Add(guitar);
                //return guitar;

            }
            return matchingGuitars;
        }
    }
}
