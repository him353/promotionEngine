using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class PromotionEngine
    {
        public static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.WriteLine(Constants.ACTIVEPROMOTIONS + '\n');
            Console.WriteLine(Constants.TOTALORDER);
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(Constants.ORDERTYPE);
                string type = Console.ReadLine();
                Product p = new Product(type);
                products.Add(p);
            }
            FinalPrice fp = new FinalPrice();
            int totalPrice = fp.TotalPrice(products);
            Console.WriteLine('\n'+"======="+ '\n'+"Total" +"  " + totalPrice);
            Console.ReadLine();
        }
    }
}