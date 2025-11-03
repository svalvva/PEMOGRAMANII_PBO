using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714240058
{
    public abstract class Product_714240058
    {
        private string myType;
        private string myTitle;

        public Product_714240058()
        {

        }

        //constructor
        public Product_714240058(string type, string title)
        {
            myType = type;
            myTitle = title;
        }

        //property for myType
        public string MyType
        {
            get { return myType; }
            set { myType = value; }
        }

        //property for myTitle
        public string MyTitle
        {
            get { return myTitle; }
            set { myTitle = value; }
        }

        //metode abstract untuk menampilkan info produk
        public abstract void DisplayInfo();
    }
}
