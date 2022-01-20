using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Article

         
    {
        static string[] productName = {"apples", "toy", "fish", "potato"}; 
        public string[] ProductName { get { return productName;} } 
        
        string[] shop = {"FruitShop", "ToyShop", "FishShop", "VegetablesShop" };
        public string[] Shop { get { return shop; } }
        
        double[] price = { 12, 45, 20, 8};
        public double[] Price { get { return price; } }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < productName.Length; i++)
                {
                    if (productName[i] == index)
                    {
                        return productName[i] + " - " + shop[i] + " - " + price[i];
                    }
                }

                return string.Format("{0} - нет такого товара", index);
            }

            public string this[int index]
        {
            get
            {
                for (int i = 0; i < productName.Length; i++)
                {
                    if ((i + 1) == index)
                    {
                        return productName[i] + " - " + shop[i] + " - " + price[i];
                    }
                }

                return string.Format("{0} - за пределами массива", index);
            }
        }
    }
}
