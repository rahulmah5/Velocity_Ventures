//Sales Form
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace velocityVentures
{
    public partial class salesForm : Form
    {
        public salesForm()
        {
            InitializeComponent();
        }

        /*salesLoad displays the sales which have taken place throughout the day
         * It is displayed based on the opening stock and the live stock of the array
         * custom message is displayed if no sale has taken place
         */
        public void salesLoad(String[] sportsItem, String[] itemSize, int[,] openingStock, int[,] liveStock, decimal[,] prices)
        {
            bool soldFlag=false;
            decimal totalSales=0;
            decimal totalPrice;
            for(int i = 0; i < openingStock.GetLength(0); i++)
            {
                for(int j = 0; j < openingStock.GetLength(1); j++)
                {
                    //Check any differences with opening and live stock
                    int stockDifference = openingStock[i,j] - liveStock[i,j];
                        //Get the prices of products sold
                        totalPrice = stockDifference * prices[i,j];
                        //Running counter for the total sales
                        totalSales += totalPrice;
                        string productDetails = $"{totalPrice:C2}\t\t\t{stockDifference}\t{sportsItem[i]} - {itemSize[j]}";
                        //Add the details of the product sold to the list box
                        salesList.Items.Add(productDetails);
                }
            }
            //Adding the total sales to the list box
                salesList.Items.Add("*******************************************************************************");
                salesList.Items.Add($"Total Sales- {totalSales:C2}");
        }

        /*exitSalesButtonClick exits the sales form
         */
        private void exitSalesButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
