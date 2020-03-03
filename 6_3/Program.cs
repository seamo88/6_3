using System;
using System.Collections.Generic;
using System.Text;

namespace _6_3
{
    class Program

    {
        static void Main(String[]arg)
        {
            Animal animal1 = new Animal(4, 0, "Cat", "Snowball", true);
            Animal animal2 = new Animal(8, 0, "Spider", "Friendly the Spider", false);
            Animal animal3 = new Animal(2, 2, "Monkey", "Bobo", false);
            animal1.ShowDetails();
            animal2.ShowDetails();
            animal3.ShowDetails();

            CoffeeMugs mug1 = new CoffeeMugs("white", "black", "World's Best Daddy", 16);
            CoffeeMugs mug2 = new CoffeeMugs("black", "gold", "Rise & Shine", 12);

            mug1.Fill();
            mug1.Drink();
            mug1.Drink();
            mug1.Fill();
            mug1.Fill();
            mug1.Drink();

        }
      

       
    }
}
