using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714240058
{
    internal class ProductTest_714240058
    {
        static void Main(string[] args)
        {
            //Product_714240058 myProduct = new Product_714240058();
            
            //myProduct.MyType = "DVD";

            //Console.WriteLine(myProduct.MyType);
            Book_714240058 product1 = new Book_714240058("Book", "C# Object Oriented Solution", "300");
            DVD_714240058 product2 = new DVD_714240058("Ethernal Sunshine Of The Spotless Mind", "145");

            product1.DisplayInfo();
            product2.DisplayInfo();
        }
    }
}
