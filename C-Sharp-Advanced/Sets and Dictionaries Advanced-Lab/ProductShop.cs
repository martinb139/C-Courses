using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Product_Shop
{
    internal class ProductShop
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> productShop =
                new Dictionary<string, Dictionary<string, double>>();

            string[] shopInput = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.None).ToArray();

            while (shopInput[0] != "Revision")
            {
                double price = double.Parse(shopInput[2]);
                if (!productShop.ContainsKey(shopInput[0]))
                {
                    productShop.Add(shopInput[0], new Dictionary<string, double>());
                    productShop[shopInput[0]].Add(shopInput[1], price);
                }
                else
                {
                    productShop[shopInput[0]].Add(shopInput[1], price);
                }

                shopInput = Console.ReadLine()
                    .Split(new string[] { ", " }, StringSplitOptions.None).ToArray();
            }

            foreach (var shop in productShop.Keys.OrderBy(x => x).ToList())
            {
                Console.WriteLine(shop + "->");
                foreach (var product in productShop[shop])
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
