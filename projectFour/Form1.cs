using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentFour
{
    public partial class Form1 : Form
    {
        public Form1()                  // C:\Users\zemen\source\repos\AssignmentFour\bin\Debug mycurrentDirectory
        {
            InitializeComponent();
    
            lstInventory.DataSource = Inventory.getInventory().OrderBy(p => p.name).ToList(); // recieves inventory and sets it as data for us to see
        }

        private static string path = "beauty-shop-inventory.txt";


        private void btnSaveProducts_Click(object sender, EventArgs e)
        {
            if (btnSaveProducts.Text.Equals("Add new"))
            {
                disableProduct();  // see method
            }
            else if (btnSaveProducts.Text.Equals("Save new"))
            {
                lblError.Text = "";

                string name = txtboxProductName.Text;

                string description = rtbProductsDescription.Text;

                string price = txtboxProductPrice.Text;

                List<Product> stockList = Inventory.getInventory();

                Product stock = stockList.Find(a => a.name.Equals(txtboxProductName.Text));  // checks if object with same name exists already within list

                bool error = false;

                if (name.Trim().Equals("")) // here are all the checks if something has blank space or if they are numbers and so on 
                {
                    lblError.Text = "Please enter name" + Environment.NewLine;
                    error = true;
                }
                else if (stock != null)
                {
                    lblError.Text = "Please enter unused name" + Environment.NewLine;
                    error = true;
                }

                if (description.Trim().Equals(""))
                {
                    lblError.Text += "Please enter description" + Environment.NewLine;
                    error = true;
                }
                if (price.Trim().Equals(""))
                {
                    lblError.Text = "Please enter price" + Environment.NewLine;
                    error = true;
                }
                else if (!Double.TryParse(price, out _))
                {
                    lblError.Text = "Please enter number for price" + Environment.NewLine;
                    error = true;
                }
                else if (double.Parse(price) < 0)
                {
                    lblError.Text = "Please enter price above 0" + Environment.NewLine;
                    error = true;
                }
               
                if (!error)  // if none of them have any errors within the formatting then we write the new item to our file then reload our list (would it be more optimal to add to the list and show that ? yes)
                {
                    lblError.Text = "";
                    StreamWriter writer = new StreamWriter(path: path, append: true);


                    writer.WriteLine(name + "|" + description + "|" + price);

                    writer.Dispose();

                    lstInventory.DataSource = null;
                    lstInventory.DataSource = Inventory.getInventory().OrderBy(p => p.name).ToList();
                }



            }


        }

        private void lstInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((Product)lstInventory.SelectedItem != null)
            {


                Product item = (Product)lstInventory.SelectedItem;



                if (item.GetType().ToString().Equals("AssignmentFour.Procedure"))   // this checks if its a product or procedure when we display so we know what to display 
                {
                    Procedure items = (Procedure)lstInventory.SelectedItem;
                    txtboxProcedureName.Text = items.name;
                    txtboxProcedureDescription.Text = items.description;
                    txtboxProcedurePrice.Text = Convert.ToString(items.price);
                    txtboxMinutes.Text = Convert.ToString(items.minutes);
                    disableProduct();

                }


                if (item.GetType().ToString().Equals("AssignmentFour.Product"))
                {

                    txtboxProductName.Text = item.name;
                    rtbProductsDescription.Text = item.description;
                    txtboxProductPrice.Text = Convert.ToString(item.price);

                    disableProcedure();

                }
            }
            
       
        }
        public void disableProduct()  // this method basically disables buttons we dont need when working with specific parts of each project and sets fields to blank for when we add a new object to our text file
        {
            txtboxProductName.Text = "";
            rtbProductsDescription.Text = "";
            txtboxProductPrice.Text = "";
            btnUpdateProduct.Enabled = false;
            btnDeleteProduct.Enabled = false;
            btnUpdateProcedure.Enabled = true;
            btnDeleteProcedure.Enabled = true;
            btnSaveProcedure.Text = "Add new";
            btnSaveProducts.Text = "Save new";
            txtboxProductName.ReadOnly = false;
            txtboxProcedureName.ReadOnly = true;
        }

        public void disableProcedure() // mirror the product but for procedure
        {

            txtboxProcedureName.Text = "";
            txtboxProcedureDescription.Text = ""; ;
            txtboxProcedurePrice.Text = "";
            txtboxMinutes.Text = "";
            btnUpdateProcedure.Enabled = false;
            btnDeleteProcedure.Enabled = false;
            btnUpdateProduct.Enabled = true;
            btnDeleteProduct.Enabled = true;
            btnSaveProducts.Text = "Add new";
            btnSaveProcedure.Text = "Save new";
            txtboxProductName.ReadOnly = true;
            txtboxProcedureName.ReadOnly = false;
        }

        private void btnSaveProcedure_Click(object sender, EventArgs e) // basically same functions as product but for procedure
        {
            if (btnSaveProcedure.Text.Equals("Add new"))
            {
                disableProcedure();
                
            }
            else if (btnSaveProcedure.Text.Equals("Save new"))
            {
                lblError.Text = "";
                string name = txtboxProcedureName.Text;

                string description = txtboxProcedureDescription.Text;

                string price = txtboxProcedurePrice.Text;
                string minutes = txtboxMinutes.Text;
                List<Product> stockList = Inventory.getInventory(); 

                Product stock = stockList.Find(a => a.name.Equals(txtboxProcedureName.Text)); 

                bool error = false;

                if (name.Trim().Equals(""))
                {
                    lblError.Text = "Please enter name" + Environment.NewLine ;
                    error = true;
                }
                else if(stock != null)
                {
                    lblError.Text = "Please enter unused name" + Environment.NewLine;
                    error = true;
                }
                if (description.Trim().Equals(""))
                {
                    lblError.Text += "Please enter description" + Environment.NewLine;
                    error = true;
                }
                if (price.Trim().Equals(""))
                {
                    lblError.Text += "Please enter price" + Environment.NewLine;
                    error = true;
                }
                else if (!Double.TryParse(price, out _))
                {
                    lblError.Text += "Please enter number for price" + Environment.NewLine;
                    error = true;
                }
                else if (double.Parse(price)<0)
                {
                    lblError.Text += "Please enter price above 0" + Environment.NewLine;
                    error = true;
                }
                if (minutes.Trim().Equals(""))
                {
                    lblError.Text += "Please enter minutes" + Environment.NewLine;
                    error = true;
                }
                else if(!int.TryParse(minutes,out _))
                {
                    lblError.Text += "Please enter number in minutes" + Environment.NewLine;
                    error = true;
                }
                else if (int.Parse(minutes) <= 0)
                {
                    lblError.Text += "please enter positive number for minutes" + Environment.NewLine;
                    error = true;
                }
                if (!error)
                {
                    lblError.Text = "";
                    StreamWriter writer = new StreamWriter(path: path, append: true);


                    writer.WriteLine(name + "|" + description + "|" + price + "|" + minutes);

                    writer.Dispose();

                    lstInventory.DataSource = null;
                    lstInventory.DataSource = Inventory.getInventory().OrderBy(p => p.name).ToList();

                   
                }

            }


        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            
            List<Product> stockList = Inventory.DeleteStock(txtboxProductName.Text).OrderBy(p => p.name).ToList();  // this deletes  said item from our list 


            lstInventory.DataSource = null;
            lstInventory.DataSource = stockList;

        }

        private void btnDeleteProcedure_Click(object sender, EventArgs e)
        {
            List<Product> stockList = Inventory.DeleteStock(txtboxProcedureName.Text).OrderBy(p => p.name).ToList();


            lstInventory.DataSource = null;
            lstInventory.DataSource = stockList;
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)  // since I worked on update last I decided instead of writing new code ill reuse my code for a delete then b write to file.  that way its technially updating it so its literally combining save and delete
        {


            int index = lstInventory.SelectedIndex;

            string name = txtboxProductName.Text;

            string description = rtbProductsDescription.Text;

            string price = txtboxProductPrice.Text;

            bool error = false;
            List<Product> stockList = Inventory.DeleteStock(txtboxProductName.Text).OrderBy(p => p.name).ToList();



            if (description.Trim().Equals(""))
            {
                lblError.Text += "Please enter description" + Environment.NewLine;
                error = true;
            }
            if (price.Trim().Equals(""))
            {
                lblError.Text = "Please enter price" + Environment.NewLine;
                error = true;
            }
            else if (!Double.TryParse(price, out _))
            {
                lblError.Text = "Please enter number for price" + Environment.NewLine;
                error = true;
            }
            else if (double.Parse(price) < 0)
            {
                lblError.Text = "Please enter price above 0" + Environment.NewLine;
                error = true;
            }

            if (!error)
            {
                lblError.Text = "";
                StreamWriter writer = new StreamWriter(path: path, append: true);


                writer.WriteLine(name + "|" + description + "|" + price);

                writer.Dispose();

                lstInventory.DataSource = null;
                lstInventory.DataSource = Inventory.getInventory().OrderBy(p => p.name).ToList();
            }




            lstInventory.SelectedIndex = index; // selects same item you just worked with

        }

        private void btnUpdateProcedure_Click(object sender, EventArgs e)
        {
            int index = lstInventory.SelectedIndex; 

            string name = txtboxProcedureName.Text;

            string description = txtboxProcedureDescription.Text;

            string price = txtboxProcedurePrice.Text;
            string minutes = txtboxMinutes.Text;

            bool error = false;
            List<Product> stockList = Inventory.DeleteStock(txtboxProcedureName.Text).OrderBy(p => p.name).ToList();
            if (description.Trim().Equals(""))
            {
                lblError.Text += "Please enter description" + Environment.NewLine;
                error = true;
            }
            if (price.Trim().Equals(""))
            {
                lblError.Text += "Please enter price" + Environment.NewLine;
                error = true;
            }
            else if (!Double.TryParse(price, out _))
            {
                lblError.Text += "Please enter number for price" + Environment.NewLine;
                error = true;
            }
            else if (double.Parse(price) < 0)
            {
                lblError.Text += "Please enter price above 0" + Environment.NewLine;
                error = true;
            }
            if (minutes.Trim().Equals(""))
            {
                lblError.Text += "Please enter minutes" + Environment.NewLine;
                error = true;
            }
            else if (!int.TryParse(minutes, out _))
            {
                lblError.Text += "Please enter number in minutes" + Environment.NewLine;
                error = true;
            }
            else if (int.Parse(minutes) <= 0)
            {
                lblError.Text += "please enter positive number for minutes" + Environment.NewLine;
                error = true;
            }
            if (!error)
            {
                lblError.Text = "";

                StreamWriter writer = new StreamWriter(path: path, append: true);


                writer.WriteLine(name + "|" + description + "|" + price + "|" + minutes);

                writer.Dispose();

                lstInventory.DataSource = null;
                lstInventory.DataSource = Inventory.getInventory().OrderBy(p => p.name).ToList();

            }
            lstInventory.SelectedIndex = index;
        }
    }
}
