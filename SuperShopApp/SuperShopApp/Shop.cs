using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopApp
{
   public class Shop
    {
        private string name;
        private string address;
        private Product aProduct;

        public String  NAME { get; set; }
        public String Address { get; set; }

        List<Product> productList=new List<Product>();

       public string AddItem(string productId, int quantity)
       {
           string msg = "";
           if (HasThisProductIdExist(productId))
           {
               aProduct.Quantity += quantity;
               msg = "Already exist! Quantity added";
           }

       else
           {
               aProduct = new Product();
               aProduct.ProductId = productId;
               aProduct.Quantity = quantity;
               productList.Add(aProduct);
               msg="Item added";
           }
           return msg;
       }

       public string ShowDetails(string shopName,string address)
       {
           string msg = string.Empty;
           msg += "Name: " + shopName + "\n" + "Address: " + address + "\n\n"+"Product Id"+"\t \t"+"Quantitiy"+"\n";

           foreach (Product aProduct in productList)
           {
               msg += aProduct.ProductId + "\t\t" + aProduct.Quantity + "\n";
           }
           return msg;
       }

       private bool HasThisProductIdExist(string prouctId)
        {
            foreach (Product product in productList)
            {
                if (product.ProductId== prouctId)
                {
                    aProduct = product;
                    return true;
                }

            }
           return false;
        }
       
    }
}
