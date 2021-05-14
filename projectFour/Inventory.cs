using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentFour
{
    public class Inventory
    {
        private static string path = "beauty-shop-inventory.txt";
        static string name { get; set; }

       static string description { get; set; }
      static  double price { get; set; }

     static   int minutes { get; set; }

        public static List<Product> getInventory() //static
        {
            List<Product> listOfInputs = new List<Product>();

            string currentLine = "";
            StreamReader reader = new StreamReader(path);



            while ((currentLine = reader.ReadLine()) != null)
            {
                
                string[] arrLine = currentLine.Split('|');



                if (arrLine.Length == 3)   // we are determining whether item is a product or procedure based on the array length
                {

                    listOfInputs.Add(new Product(name, description, price)
                    {
                        name = arrLine[0],
                        description = arrLine[1],
                        price = double.Parse(arrLine[2]),
                    });
                }
                else if (arrLine.Length <=1){

                }
                else
                {
                    

                    listOfInputs.Add(new Procedure(name, description, price, minutes)
                    {
                        name = arrLine[0],
                        description = arrLine[1],
                        price = double.Parse(arrLine[2]),
                        minutes= int.Parse(arrLine[3]),

                    });
                }
            }
            reader.Dispose();
            return listOfInputs;
        }
        public static object GetStockByName(string name)  // idont think I actually used this method so my bad
        {
          
            List<Product> stockList = getInventory();

            Product stock = stockList.Find(a => a.name.Equals(name));

            return stock;
        }

        public static List<Product> DeleteStock(string name)
        {
            


            List<Product> stockList = getInventory();



            stockList.Remove(stockList.Find(a => a.name.Equals(name)));  // remove item from list based on name
            StreamWriter writer = new StreamWriter(path: path);     // could make this whole Stream writer into a method to covert any list to file 
 
            foreach (var stock in stockList) // writes each stock to file
            {

                if (stock.GetType().ToString().Equals("AssignmentFour.Product"))
                {

                    writer.WriteLine(stock.name + "|" + stock.description + "|" + stock.price);
                }
                else
                {
                    Procedure item = (Procedure)stock;


                    writer.WriteLine(item.name + "|" + item.description + "|" + item.price+"|"+ item.minutes);

                }
            }

            writer.Dispose();




            return stockList;


        }



           

    }
}