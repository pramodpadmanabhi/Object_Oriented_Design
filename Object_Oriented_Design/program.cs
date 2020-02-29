using System;
using System.Collections.Generic;

namespace Object_Oriented_Design
{
    class program
    {
  
   
        static void Main(string[] args)
        {
            
            Inventory inventory = new Inventory();
            InitializeInventory(inventory);
            Guitar guitarsILike = new Guitar("", 0, EnumDefinition.Builder.FENDER, "Stratocastor", EnumDefinition.Type.ELECTRIC, EnumDefinition.Wood.ALDER, EnumDefinition.Wood.ALDER);
            List<Guitar> guitars = inventory.Search(guitarsILike);
            if (guitars.Count>0)
            {
               foreach(var item in guitars)
                {
                    Console.WriteLine("Builder : " +item.getBuilder()+"\n"+"Model : "+"Model : "+ item.getModel()+"\n"+"Type:"+item.getType()+"\n"+"BackWood : "+item.getBackWood()+"\n"+"TopWood : "+item.getTopWood()+"\n"+"Price : "+item.getPrice());
                }
            }
            else
            {
                Console.WriteLine("We have Nothing For You");
            }
            // add params
            //inventory.addGuitar();
            //inventory.getGuitar();
            // Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
        public static void InitializeInventory(Inventory inventory)
        {
            inventory.addGuitar("V95693", 1499.95, EnumDefinition.Builder.FENDER, "Stratocastor", EnumDefinition.Type.ELECTRIC, EnumDefinition.Wood.ALDER, EnumDefinition.Wood.ALDER);
        }
    }
}
