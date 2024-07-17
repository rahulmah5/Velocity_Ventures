//Stock Form
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace velocityVentures
{
    public partial class stockForm : Form
    {
        public stockForm()
        {
            InitializeComponent();
        }

        /*stockFormLoad generates the stock report on a new form
         * and also generates a stock report on the debug folder
         */
        public void stockFormLoad(String[] sizeAbb, String[] sportsItems, String[] itemSize, int[,] liveStock)
        {
            string row, firstRow;
            string stockReportPath;
            string currentDate = DateTime.Now.ToString("MM-dd-yyyy");
            string currentTime = DateTime.Now.ToString("HH:mm:ss");

            stockReportPath = "Stock_Report_" + currentDate+".txt";
            //Add the appropriate details of stock report to a list
            List<string> stockReportLines = new List<string>();

            //Sizeabb is the first row for the stock report with column headers
            firstRow = String.Join("\t", sizeAbb);
            stockReportLines.Add($"Date Generated- {currentDate}\t\tTime Generated- {currentTime} ");
            stockReportLines.Add("\n");
            stockReportLines.Add(firstRow);
            stockReportLines.Add("\n");

            for (int i = 0; i < sportsItems.Length; i++)
            {
                 row = sportsItems[i];
                for (int j = 0; j < itemSize.Length; j++)
                {
                    row += "\t" + liveStock[i, j];
                }
                stockReportLines.Add(row);
            }
            //Write to file with the help of the list
            try
            {
                File.WriteAllLines(stockReportPath, stockReportLines);
                reportGenLabel.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in processing the file. Error- " + ex.Message, "Error", MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }

            //Display the stock report in the list box
            for (int i=0; i<sportsItems.Length; i++)
            {
                row = "";
                for(int j=0; j<itemSize.Length; j++)
                {
                    row += "\t" + liveStock[i, j];
                }
                stockList.Items.Add(row);
            }
            dateOutput.Text = currentDate;
            timeOutput.Text = currentTime;
        }

        /*exitStockButtonClick closes the stock report form
         */
        private void exitStockButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
