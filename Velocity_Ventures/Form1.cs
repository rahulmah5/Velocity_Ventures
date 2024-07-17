/* Date:22/12/2023
 * Velocity Ventures is a sports goods company
 * which sells various sports products for different sizes. It is an EPOS system
 * which is used to track real time inventory and sales of the product.
 * This system can also be used for searching the transaction details of customer
 * for generating insights of customer behavior.
 * It also provides real time comprehensive reports like sales report and 
 * stock report in order so that the business can make better business decisions 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace velocityVentures
{
    public partial class velocityVenturesForm : Form
    {
        //Global Constants
        readonly private static string[] SIZEABBREVIATED = { "Sports Products", "K", "XS", "S", "M", "L", "XL" };
        readonly private static string[] SPORTSITEMS = {"Running Shoe", "Sports Jersey", "Dumbbell", "Backpack", "Swimsuit",
                                                 "Surfboard", "Basketball", "Football", "Bicycles", "Golf club",
                                                 "Skateboard", "Snowboard", "Fishing Rod"};
        readonly private static string[] ITEMSIZE = { "Kids", "Extra Small", "Small", "Medium", "Large", "Extra Large" };

        readonly static decimal[,] ITEMPRICES =
        {
        {2.55M, 3.05M, 3.55M, 4.00M, 4.45M, 4.90M},
        {2.60M, 2.99M, 3.38M, 3.99M, 4.60M, 5.20M},
        {4.55M, 5.69M, 6.83M, 6.99M, 7.99M, 8.99M},
        {2.40M, 2.90M, 3.40M, 3.59M, 3.78M, 3.97M},
        {3.49M, 3.99M, 4.49M, 4.99M, 5.49M, 5.99M},
        {2.19M, 3.12M, 4.05M, 4.49M, 4.93M, 5.37M},
        {3.99M, 4.49M, 5.50M, 6.51M, 7.52M, 8.53M},
        {7.89M, 8.89M, 9.89M, 10.89M, 11.89M, 12.89M},
        {3.45M, 3.75M, 4.25M, 4.75M, 5.25M, 5.75M},
        {3.67M, 3.97M, 4.50M, 5.03M, 5.56M, 6.09M},
        {4.55M, 5.00M, 5.36M, 5.72M, 6.08M, 6.44M},
        {5.00M, 5.50M, 6.00M, 6.50M, 7.00M, 7.50M},
        {1.23M, 2.23M, 3.23M, 4.23M, 5.23M, 6.23M}
        };

        //Global Variables
        private int[,] sportsItemOpeningStock = new int[SPORTSITEMS.Length, ITEMSIZE.Length];
        private int[,] sportsItemTempStock = new int[SPORTSITEMS.Length, ITEMSIZE.Length];
        private int[,] sportsItemLiveStock = new int[SPORTSITEMS.Length, ITEMSIZE.Length];

        private decimal totalPrice = 0;
        private string STOCKFILENAME = "Stock.txt";
        private string TXNFILENAME = "Transactions.txt";
        private const char SEPARATOR = ',';
        private string transactionId, currentDate;
        private const int minTxnId = 1000;
        private const int maxTxnId = 9999;
        private const int maxAlpha = 26;
        private const string DATETIMEFORMAT = "MM-dd-yyyy HH:mm:ss";
        private const int FIRSTPOSITEMS = 3;
        private const int TXNOPOS = 0;
        private const int DATEPOS = 1;
        private const int TOTALPOS = 2;
        public velocityVenturesForm()
        {
            InitializeComponent();
        }


        /* Form Load function is used to load the stock array from file
         * and store it in opening stock later copy to temporary and live count 
         * stock arrays
         */
        private void velocityVenturesForm_Load(object sender, EventArgs e)
        {
            string[] readText;
            string[] stockLevels;
            
            //Copy from file to stock array
            try
            {
                readText = File.ReadAllLines(STOCKFILENAME);

                for (int row = 0; row < SPORTSITEMS.Length; row++)
                {
                    stockLevels = readText[row].Split(SEPARATOR);

                    for (int col = 0; col < ITEMSIZE.Length; col++)
                    {
                        sportsItemOpeningStock[row, col] = int.Parse(stockLevels[col]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in processing the file. Error- " + ex.Message, "Error", MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
            //Copy the opening stock array to temporary and live stock arrays
            copy2DIntegerArray(sportsItemOpeningStock, ref sportsItemTempStock);
            copy2DIntegerArray(sportsItemOpeningStock, ref sportsItemLiveStock);
        }
        
        /* Function which copies the one 2D array
         * to another 2D array
         */
        private void copy2DIntegerArray(int[,] fromArray, ref int[,] toArray)
        {
            for (int row = 0; row < fromArray.GetLength(0); row++)
            {
                for (int col = 0; col < fromArray.GetLength(1); col++)
                {
                    toArray[row, col] = fromArray[row, col];
                }
            }
        }

        /* selectedIndexUpDownChanged dynamically updates the unit price
        * and sub total based on the user selections
        */
        private void selectedIndexUpDownChanged(object sender, EventArgs e)
        {
            decimal subTotal;
            if (itemSizeListBox.SelectedIndex != -1 && itemtypeListBox.SelectedIndex != -1 && quantityNumeric.Value > 0)
            {
                subTotal = quantityNumeric.Value * ITEMPRICES[itemtypeListBox.SelectedIndex, itemSizeListBox.SelectedIndex];

                unitPriceOutput.Text = ITEMPRICES[itemtypeListBox.SelectedIndex, itemSizeListBox.SelectedIndex].ToString("C2");
                subTotalOutput.Text = subTotal.ToString("C2");
            }
            else
            {
                unitPriceOutput.Text = 0.ToString("C2");
                subTotalOutput.Text = 0.ToString("C2");
            }

        }

        /* Add to order add function adds the products to cart
         * based on validation of all the required fields
         * also tracks the temporary stock count so that customer
         * does not overbuy certain products which is more than the inventory
         */
        private void addOrderButtonClick(object sender, EventArgs e)
        {
            decimal itemTotalPrice;
            int quantity, typeSelected, sizeSelected;
            string sportsItem, itemSize, orderItem;

            typeSelected = itemtypeListBox.SelectedIndex;
            sizeSelected = itemSizeListBox.SelectedIndex;
           
            //Check if type is selected
            if (typeSelected != -1)
            {
                //Check if size is selected
                if (sizeSelected != -1)
                {
                    //Check valid value for numeric up down
                    if ((int)quantityNumeric.Value != 0)
                    {
                        if ((int)quantityNumeric.Value <= sportsItemTempStock[itemtypeListBox.SelectedIndex, itemSizeListBox.SelectedIndex])
                        {

                            quantity = (int)quantityNumeric.Value;
                            sportsItem = SPORTSITEMS[typeSelected];
                            itemSize = ITEMSIZE[sizeSelected];

                            //Calculate the prices and update the inventory
                            itemTotalPrice = ITEMPRICES[typeSelected, sizeSelected] * quantity;
                            sportsItemTempStock[typeSelected, sizeSelected] -= quantity;
                            totalPrice += itemTotalPrice;

                            //Display the order details in list box
                            orderItem = String.Format($"{sportsItem}-{itemSize}\t{quantity}\t{itemTotalPrice.ToString("C2")}");
                            orderListBox.Items.Add(orderItem);
                            totalPriceOutput.Text = totalPrice.ToString("C2");

                            //Clear the selection post adding to cart
                            itemtypeListBox.ClearSelected();
                            itemSizeListBox.ClearSelected();
                            quantityNumeric.Value = 0;
                            completeOrderButton.Enabled = true;
                        }
                        else
                        {
                            //Message if no stock available for a size
                            if (sportsItemTempStock[typeSelected, sizeSelected] == 0)
                            {
                                MessageBox.Show("Selected Size is unavailable. Please Select some other size", "Selected Quantity Unavailable", MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation);
                                quantityNumeric.Value = 0;
                                itemSizeListBox.Focus();
                            }

                            //Message if selected quantity is not available
                            else
                            {
                                MessageBox.Show($"Selected quantity unavailable. Available quantity- {sportsItemTempStock[typeSelected, sizeSelected]} Units.", "Selected Quantity Unavailable", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                                quantityNumeric.Value = sportsItemTempStock[typeSelected, sizeSelected];
                                quantityNumeric.Focus();

                            }
                        }
                    }

                    //Message if quantity is 0
                    else
                    {
                        MessageBox.Show("Enter a valid value for quantity", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        quantityNumeric.Focus();
                        quantityNumeric.Select();
                    }
                }
                //Message if the size list box is not selected
                else
                {
                    MessageBox.Show("A size is required to proceed", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    itemSizeListBox.Focus();
                }
            }

            //Message if type listbox is not selected
            else
            {
                MessageBox.Show("A type is required to proceed", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                itemtypeListBox.Focus();
            }
        }

        /*Clear button clears the Order cart and brings the user back to 
         * the initial state of the form
         */
        private void clearButtonClick(object sender, EventArgs e)
        {
            itemtypeListBox.ClearSelected();
            itemSizeListBox.ClearSelected();
            quantityNumeric.Value = 0;
            orderListBox.Items.Clear();
            totalPrice = 0;
            totalPriceOutput.Text = "";
            completeOrderButton.Enabled = false;
            shopItemsGroupBox.Visible = true;
            orderedItemsGroupBox.Visible = true;
            searchGroupBox.Visible = false;

            //Copy live stock array to temp if the sale was unsuccessful
            copy2DIntegerArray(sportsItemLiveStock, ref sportsItemTempStock);
        }
        /*completeOrderButtonClick method displays a confirmation message to 
         * the user for order confirmation and stores the transaction
         * details of customer to a text file, if the order is confirmed.
         */
        private void completeOrderButtonClick(object sender, EventArgs e)
        {
            string orderDetails;
            transactionId = getUniqueRandomTransactionId();
            currentDate = DateTime.Now.ToString(DATETIMEFORMAT);
           
            //Store the details of transaction in a string array
            String[] orderItems = new string[FIRSTPOSITEMS + orderListBox.Items.Count];
            orderItems[TXNOPOS] = transactionId;
            orderItems[DATEPOS] = currentDate;
            orderItems[TOTALPOS] = totalPrice.ToString("C2");
            for (int i=0; i<orderListBox.Items.Count; i++)
            {

                orderItems[3+i] = orderListBox.Items[i].ToString();
            }
            //Message for order details
            orderDetails = $"Order Details -\n\nTransaction Id - {transactionId}\nDate - {currentDate}\nOrdered Items -\n";
            foreach (var item in orderListBox.Items)
            {
                orderDetails += item.ToString() + "\n";
            }
            orderDetails += $"***********************************************\nTotal Price - {totalPrice:C2}";

            //Check If user selects yes for order confirmation
            if (DialogResult.Yes == MessageBox.Show(orderDetails, "Order Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                try
                {
                    StreamWriter txnOutputFile;
                    using (txnOutputFile = File.AppendText(TXNFILENAME))
                    {
                        txnOutputFile.WriteLine($"Transaction Id: {orderItems[TXNOPOS]}");
                        txnOutputFile.WriteLine($"Date: {orderItems[DATEPOS]}");
                        txnOutputFile.WriteLine("Ordered Items: ");
                        for (int i = 3; i < orderItems.Length; i++)
                        {
                            txnOutputFile.WriteLine(orderItems[i].ToString());
                        }
                        txnOutputFile.WriteLine($"Total Price: {orderItems[TOTALPOS]}");
                        txnOutputFile.WriteLine();
                    }
                }
                //Message if failure to write to the file
                catch (Exception ec)
                {
                    MessageBox.Show("Error in processing the file. Error- " + ec.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                MessageBox.Show("Order Purchased Successfully", "Order Success", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                //Update the Live stock array
                copy2DIntegerArray(sportsItemTempStock, ref sportsItemLiveStock);
                //Update the stock file
                write2DIntegerArrayFile(STOCKFILENAME, ref sportsItemLiveStock);
                clearButtonClick(sender, e);
            }
        }

        /*write2DIntegerArrayFile method is used to write the 2D array
         * to a file for updation of inventory
         */
        private void write2DIntegerArrayFile(string fileName, ref int[,] record)
        {
            int row = 0;
            int[] recordRow = new int[record.GetLength(1)];
            try
            {
                using (StreamWriter stream = File.CreateText(fileName))
                {
                    for (row = 0; row < record.GetLength(0); row++)
                    {
                        for (int col = 0; col < record.GetLength(1); col++)
                        {
                            recordRow[col] = record[row, col];

                        }
                        stream.WriteLine(String.Join(SEPARATOR.ToString(), recordRow));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in processing the file. Error- " + ex.Message, "Error", MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
        }
        /* getUniqueRandomTransactionId is used to generate a unique
         * 5 character alphanumeric transaction id which is not repeated
         * in the transactions file
         */
        private string getUniqueRandomTransactionId()
        {
            string randTransactionId;
            string randomNumber;
            char randomLetter;
            Random rand = new Random();
            do
            {
                //Generating a random alphabet as a first character 
                randomLetter = (char)('A' + rand.Next(0, maxAlpha));

                //Generating a random number with lower and upper limits
                randomNumber = rand.Next(minTxnId, maxTxnId + 1).ToString();
                randTransactionId = $"{randomLetter}{randomNumber}";
            }
            //Exit the loop only if transaction id is unique
            while (transactionIdExistCheck(randTransactionId));

            //Return the transaction id
            return randTransactionId;
        }

        /*transactionIdExistCheck checks if the generated
         * random transaction id is already present in the 
         * transaction file or not
         */
        private bool transactionIdExistCheck(string transactionId)
        {
            string[] readText;
            bool found;
            try
            {
                readText = File.ReadAllLines(TXNFILENAME);
                found = readText.Contains(transactionId);
                return found;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in processing the file. Error- " + ex.Message, "Error", MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
            return false;
        }

        /*radioCheckedChanged event displays the labels for search
         * depending on the radio button selection
         */
        private void radioCheckedChanged(object sender, EventArgs e)
        {
            if (transactionRadio.Checked)
            {
                formatLabel.Text = "Enter a transaction Id";
            }
            else
            {
                formatLabel.Text = "Enter a Date (MM-DD-YYYY)";
            }
        }
        /*searchButtonClick searches the transaction file based on the  
         * user input in the search textbox. Also displays the appropriate
         * message if search is not found
         */
        private void searchButtonClick(object sender, EventArgs e)
        {
            string[] allLines;
            string search;
            bool dateFlag = false;

            //Check if search text box is empty
            if (searchText.Text.Equals(""))
            {
                return;
            }
            searchList.Items.Clear();
            search = searchText.Text;
            try
            {
                //Read all the lines in the file
                allLines = File.ReadAllLines(TXNFILENAME);
                //Check if transaction radio is checked
                if (transactionRadio.Checked)
                {
                    //Get the index of the record which matches with the transaction file
                    int index = searchByUniqueIndex(search, allLines);

                    if (index != -1)
                    { 
                        //Parse the string array till a blank space is found
                        while (!String.IsNullOrWhiteSpace(allLines[index]))
                        {
                            searchList.Items.Add(allLines[index]);
                            index++;
                        }
                        searchList.Items.Add("*********************************************");
                    }
                    //Message if search is not found
                    else
                    {
                        searchList.Items.Add("No search results found");
                    }
                }
                //When Date Radio is checked
                else
                {
                    int index = searchByUniqueIndex(search, allLines);
                    
                    while(index != -1)
                    {
                        dateFlag = true;
                        index--;
                        //Parse the string array till a blank space is found
                        while (!String.IsNullOrWhiteSpace(allLines[index]))
                        {
                            searchList.Items.Add(allLines[index]);
                            index++;
                        }
                        searchList.Items.Add("**********************************************");
                        //Search further for other trnsactions with the same date search term
                        index = searchNextUniqueIndex(search, allLines, index);
                    }
                    //Message if search is not found
                    if (dateFlag == false)
                    {
                        searchList.Items.Add("No search results found");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in processing the file. Error- " + ex.Message, "Error", MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
        }

        /* searchByUniqueIndex returns the index of the array if the search is found
         * and returns -1 if index is not found
         */ 
        private int searchByUniqueIndex(string searchValue, String[] arrayToSearch)
        {
            for(int i = 0; i < arrayToSearch.Length; i++)
            {
                if (arrayToSearch[i].Contains(searchValue))
                {
                    return i;
                }
            }
            return -1;
        }
        /* searchNextUniqueIndex searches the array based on the index of the array
         * and and returns -1 if index is not found
         */
        private int searchNextUniqueIndex(string searchValue, String[] arraytoSearch, int startingIndex)
        {
            for (int i = startingIndex; i< arraytoSearch.Length; i++)
            {
                if (arraytoSearch[i].Contains(searchValue))
                {
                    return i;
                }
            }
            return -1;
        }

        /*clearSearchButtonClick clears the search listbox
         */
        private void clearSearchButtonClick(object sender, EventArgs e)
        {
            searchList.Items.Clear();
            searchText.Clear();

        }
        /*salesButtonClick opens a new form with sales report
         * A new dialog will be shown to the user on top of the main form
         */
        private void salesButtonClick(object sender, EventArgs e)
        {
            salesForm mySales = new salesForm();
            mySales.salesLoad(SPORTSITEMS, ITEMSIZE, sportsItemOpeningStock, sportsItemLiveStock, ITEMPRICES);

            mySales.ShowDialog();

            clearButtonClick(sender, e);
        }
        /*stockButtonClick opens a new form with the stock report
         * A new dialog will be shown to the user on top of the main form
         */
        private void stockButtonClick(object sender, EventArgs e)
        {
            stockForm myStockForm = new stockForm();
            myStockForm.stockFormLoad(SIZEABBREVIATED, SPORTSITEMS, ITEMSIZE, sportsItemLiveStock);

            myStockForm.ShowDialog();

            clearButtonClick(sender, e);
        }

        /*viewSearchButtonClick displays the search groupbox and 
         * buttons panel for a cleaner UI
         */
        private void viewSearchButtonClick(object sender, EventArgs e)
        {
            searchGroupBox.Visible = true;
            shopItemsGroupBox.Visible = false;
            orderedItemsGroupBox.Visible = false;
        }

        /*Exit button closes the application and also
         * updates the closing stock to the stock file
         */
        private void exitButtonClick(object sender, EventArgs e)
        {
            write2DIntegerArrayFile(STOCKFILENAME, ref sportsItemLiveStock);
            this.Close();
        }

    }
}
