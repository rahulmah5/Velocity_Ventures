namespace velocityVentures
{
    partial class velocityVenturesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(velocityVenturesForm));
            this.itemtypeListBox = new System.Windows.Forms.ListBox();
            this.itemTypeLabel = new System.Windows.Forms.Label();
            this.itemSizeListBox = new System.Windows.Forms.ListBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.quantityNumeric = new System.Windows.Forms.NumericUpDown();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.totalPriceOutput = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.completeOrderButton = new System.Windows.Forms.Button();
            this.orderListBox = new System.Windows.Forms.ListBox();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.subTotalOutput = new System.Windows.Forms.Label();
            this.unitPriceLabel = new System.Windows.Forms.Label();
            this.unitPriceOutput = new System.Windows.Forms.Label();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.stockButton = new System.Windows.Forms.Button();
            this.salesButton = new System.Windows.Forms.Button();
            this.viewSearchButton = new System.Windows.Forms.Button();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchResultsLabel = new System.Windows.Forms.Label();
            this.clearSearchButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchList = new System.Windows.Forms.ListBox();
            this.formatLabel = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.dateRadio = new System.Windows.Forms.RadioButton();
            this.transactionRadio = new System.Windows.Forms.RadioButton();
            this.shopItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.orderedItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.cartOrderLabel = new System.Windows.Forms.Label();
            this.addToOrder = new System.Windows.Forms.ToolTip(this.components);
            this.clearToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.searchToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.salesToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.stockToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.exitToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.searchGpToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.clearGpToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.purchaseToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.buttonPanel.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.shopItemsGroupBox.SuspendLayout();
            this.orderedItemsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemtypeListBox
            // 
            this.itemtypeListBox.FormattingEnabled = true;
            this.itemtypeListBox.ItemHeight = 20;
            this.itemtypeListBox.Items.AddRange(new object[] {
            "Running Shoe",
            "Sports Jersey",
            "Dumbbell",
            "Backpack",
            "Swimsuit",
            "Surfboard",
            "Basketball",
            "Football",
            "Bicycles",
            "Golf club",
            "Skateboard",
            "Snowboard",
            "Fishing Rod"});
            this.itemtypeListBox.Location = new System.Drawing.Point(144, 48);
            this.itemtypeListBox.Name = "itemtypeListBox";
            this.itemtypeListBox.Size = new System.Drawing.Size(220, 304);
            this.itemtypeListBox.TabIndex = 0;
            this.itemtypeListBox.SelectedIndexChanged += new System.EventHandler(this.selectedIndexUpDownChanged);
            // 
            // itemTypeLabel
            // 
            this.itemTypeLabel.AutoSize = true;
            this.itemTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTypeLabel.Location = new System.Drawing.Point(140, 25);
            this.itemTypeLabel.Name = "itemTypeLabel";
            this.itemTypeLabel.Size = new System.Drawing.Size(144, 20);
            this.itemTypeLabel.TabIndex = 1;
            this.itemTypeLabel.Text = "Select Item Type";
            // 
            // itemSizeListBox
            // 
            this.itemSizeListBox.FormattingEnabled = true;
            this.itemSizeListBox.ItemHeight = 20;
            this.itemSizeListBox.Items.AddRange(new object[] {
            "Kids",
            "Extra Small",
            "Small",
            "Medium",
            "Large",
            "Extra Large"});
            this.itemSizeListBox.Location = new System.Drawing.Point(418, 48);
            this.itemSizeListBox.Name = "itemSizeListBox";
            this.itemSizeListBox.Size = new System.Drawing.Size(202, 124);
            this.itemSizeListBox.TabIndex = 2;
            this.itemSizeListBox.SelectedIndexChanged += new System.EventHandler(this.selectedIndexUpDownChanged);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLabel.Location = new System.Drawing.Point(414, 25);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(100, 20);
            this.sizeLabel.TabIndex = 3;
            this.sizeLabel.Text = "Select Size";
            // 
            // quantityNumeric
            // 
            this.quantityNumeric.Location = new System.Drawing.Point(173, 110);
            this.quantityNumeric.Name = "quantityNumeric";
            this.quantityNumeric.Size = new System.Drawing.Size(128, 26);
            this.quantityNumeric.TabIndex = 4;
            this.quantityNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityNumeric.ValueChanged += new System.EventHandler(this.selectedIndexUpDownChanged);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(15, 110);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(132, 20);
            this.quantityLabel.TabIndex = 5;
            this.quantityLabel.Text = "Select Quantity";
            // 
            // totalPriceOutput
            // 
            this.totalPriceOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceOutput.Location = new System.Drawing.Point(173, 210);
            this.totalPriceOutput.Name = "totalPriceOutput";
            this.totalPriceOutput.Size = new System.Drawing.Size(128, 26);
            this.totalPriceOutput.TabIndex = 6;
            this.totalPriceOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(15, 210);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(94, 20);
            this.totalPriceLabel.TabIndex = 7;
            this.totalPriceLabel.Text = "Total Price";
            // 
            // logoPicture
            // 
            this.logoPicture.Image = ((System.Drawing.Image)(resources.GetObject("logoPicture.Image")));
            this.logoPicture.Location = new System.Drawing.Point(418, 210);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(202, 159);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPicture.TabIndex = 8;
            this.logoPicture.TabStop = false;
            // 
            // addOrderButton
            // 
            this.addOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.addOrderButton.Location = new System.Drawing.Point(48, 40);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(172, 36);
            this.addOrderButton.TabIndex = 9;
            this.addOrderButton.Text = "&Add to Order";
            this.addToOrder.SetToolTip(this.addOrderButton, "Click to Add Products to Order");
            this.addOrderButton.UseVisualStyleBackColor = false;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButtonClick);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.clearButton.Location = new System.Drawing.Point(48, 110);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(172, 36);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "&Clear";
            this.clearToolTip.SetToolTip(this.clearButton, "Click to Clear Cart for New Product Selection");
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButtonClick);
            // 
            // completeOrderButton
            // 
            this.completeOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.completeOrderButton.Enabled = false;
            this.completeOrderButton.Location = new System.Drawing.Point(442, 253);
            this.completeOrderButton.Name = "completeOrderButton";
            this.completeOrderButton.Size = new System.Drawing.Size(172, 36);
            this.completeOrderButton.TabIndex = 11;
            this.completeOrderButton.Text = "C&omplete Order";
            this.purchaseToolTip.SetToolTip(this.completeOrderButton, "Click to Purchase the Orders Added to Cart");
            this.completeOrderButton.UseVisualStyleBackColor = false;
            this.completeOrderButton.Click += new System.EventHandler(this.completeOrderButtonClick);
            // 
            // orderListBox
            // 
            this.orderListBox.FormattingEnabled = true;
            this.orderListBox.HorizontalScrollbar = true;
            this.orderListBox.ItemHeight = 20;
            this.orderListBox.Location = new System.Drawing.Point(373, 70);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.Size = new System.Drawing.Size(372, 164);
            this.orderListBox.TabIndex = 12;
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.Location = new System.Drawing.Point(15, 160);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(87, 20);
            this.subTotalLabel.TabIndex = 14;
            this.subTotalLabel.Text = "Sub-Total";
            // 
            // subTotalOutput
            // 
            this.subTotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subTotalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalOutput.Location = new System.Drawing.Point(173, 160);
            this.subTotalOutput.Name = "subTotalOutput";
            this.subTotalOutput.Size = new System.Drawing.Size(128, 26);
            this.subTotalOutput.TabIndex = 13;
            this.subTotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unitPriceLabel
            // 
            this.unitPriceLabel.AutoSize = true;
            this.unitPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceLabel.Location = new System.Drawing.Point(15, 60);
            this.unitPriceLabel.Name = "unitPriceLabel";
            this.unitPriceLabel.Size = new System.Drawing.Size(87, 20);
            this.unitPriceLabel.TabIndex = 16;
            this.unitPriceLabel.Text = "Unit Price";
            // 
            // unitPriceOutput
            // 
            this.unitPriceOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unitPriceOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceOutput.Location = new System.Drawing.Point(173, 60);
            this.unitPriceOutput.Name = "unitPriceOutput";
            this.unitPriceOutput.Size = new System.Drawing.Size(128, 26);
            this.unitPriceOutput.TabIndex = 15;
            this.unitPriceOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPanel
            // 
            this.buttonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonPanel.Controls.Add(this.exitButton);
            this.buttonPanel.Controls.Add(this.stockButton);
            this.buttonPanel.Controls.Add(this.salesButton);
            this.buttonPanel.Controls.Add(this.viewSearchButton);
            this.buttonPanel.Controls.Add(this.addOrderButton);
            this.buttonPanel.Controls.Add(this.clearButton);
            this.buttonPanel.Location = new System.Drawing.Point(896, 138);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(253, 479);
            this.buttonPanel.TabIndex = 17;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.exitButton.Location = new System.Drawing.Point(48, 390);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(172, 36);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "&Exit";
            this.exitToolTip.SetToolTip(this.exitButton, "Click to Close the Application");
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButtonClick);
            // 
            // stockButton
            // 
            this.stockButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.stockButton.Location = new System.Drawing.Point(48, 320);
            this.stockButton.Name = "stockButton";
            this.stockButton.Size = new System.Drawing.Size(172, 36);
            this.stockButton.TabIndex = 13;
            this.stockButton.Text = "S&tock Report";
            this.stockToolTip.SetToolTip(this.stockButton, "Click to Generate the Stock Report");
            this.stockButton.UseVisualStyleBackColor = false;
            this.stockButton.Click += new System.EventHandler(this.stockButtonClick);
            // 
            // salesButton
            // 
            this.salesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.salesButton.Location = new System.Drawing.Point(48, 250);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(172, 36);
            this.salesButton.TabIndex = 12;
            this.salesButton.Text = "Sa&les Report";
            this.salesToolTip.SetToolTip(this.salesButton, "Click to View the Sales Report for the Day");
            this.salesButton.UseVisualStyleBackColor = false;
            this.salesButton.Click += new System.EventHandler(this.salesButtonClick);
            // 
            // viewSearchButton
            // 
            this.viewSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.viewSearchButton.Location = new System.Drawing.Point(48, 180);
            this.viewSearchButton.Name = "viewSearchButton";
            this.viewSearchButton.Size = new System.Drawing.Size(172, 36);
            this.viewSearchButton.TabIndex = 11;
            this.viewSearchButton.Text = "&Search";
            this.searchToolTip.SetToolTip(this.viewSearchButton, "Click to View the Search");
            this.viewSearchButton.UseVisualStyleBackColor = false;
            this.viewSearchButton.Click += new System.EventHandler(this.viewSearchButtonClick);
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.searchResultsLabel);
            this.searchGroupBox.Controls.Add(this.clearSearchButton);
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.searchList);
            this.searchGroupBox.Controls.Add(this.formatLabel);
            this.searchGroupBox.Controls.Add(this.searchText);
            this.searchGroupBox.Controls.Add(this.dateRadio);
            this.searchGroupBox.Controls.Add(this.transactionRadio);
            this.searchGroupBox.Location = new System.Drawing.Point(25, 60);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(683, 385);
            this.searchGroupBox.TabIndex = 18;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search Orders";
            this.searchGroupBox.Visible = false;
            // 
            // searchResultsLabel
            // 
            this.searchResultsLabel.AutoSize = true;
            this.searchResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResultsLabel.Location = new System.Drawing.Point(416, 23);
            this.searchResultsLabel.Name = "searchResultsLabel";
            this.searchResultsLabel.Size = new System.Drawing.Size(132, 20);
            this.searchResultsLabel.TabIndex = 12;
            this.searchResultsLabel.Text = "Search Results";
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.clearSearchButton.Location = new System.Drawing.Point(388, 319);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(172, 36);
            this.clearSearchButton.TabIndex = 11;
            this.clearSearchButton.Text = "Clea&r";
            this.clearGpToolTip.SetToolTip(this.clearSearchButton, "Click to clear the textbox and search results");
            this.clearSearchButton.UseVisualStyleBackColor = false;
            this.clearSearchButton.Click += new System.EventHandler(this.clearSearchButtonClick);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.searchButton.Location = new System.Drawing.Point(30, 233);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(172, 36);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Sea&rch";
            this.searchGpToolTip.SetToolTip(this.searchButton, "Click to search for transaction details");
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButtonClick);
            // 
            // searchList
            // 
            this.searchList.FormattingEnabled = true;
            this.searchList.HorizontalScrollbar = true;
            this.searchList.ItemHeight = 20;
            this.searchList.Location = new System.Drawing.Point(324, 59);
            this.searchList.Name = "searchList";
            this.searchList.Size = new System.Drawing.Size(315, 244);
            this.searchList.TabIndex = 4;
            // 
            // formatLabel
            // 
            this.formatLabel.ForeColor = System.Drawing.Color.Red;
            this.formatLabel.Location = new System.Drawing.Point(26, 145);
            this.formatLabel.Name = "formatLabel";
            this.formatLabel.Size = new System.Drawing.Size(283, 32);
            this.formatLabel.TabIndex = 3;
            // 
            // searchText
            // 
            this.searchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchText.Location = new System.Drawing.Point(30, 180);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(180, 26);
            this.searchText.TabIndex = 2;
            this.searchText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateRadio
            // 
            this.dateRadio.AutoSize = true;
            this.dateRadio.Location = new System.Drawing.Point(30, 107);
            this.dateRadio.Name = "dateRadio";
            this.dateRadio.Size = new System.Drawing.Size(69, 24);
            this.dateRadio.TabIndex = 1;
            this.dateRadio.TabStop = true;
            this.dateRadio.Text = "Date";
            this.dateRadio.UseVisualStyleBackColor = true;
            this.dateRadio.CheckedChanged += new System.EventHandler(this.radioCheckedChanged);
            // 
            // transactionRadio
            // 
            this.transactionRadio.AutoSize = true;
            this.transactionRadio.Location = new System.Drawing.Point(30, 59);
            this.transactionRadio.Name = "transactionRadio";
            this.transactionRadio.Size = new System.Drawing.Size(135, 24);
            this.transactionRadio.TabIndex = 0;
            this.transactionRadio.Text = "Transaction Id";
            this.transactionRadio.UseVisualStyleBackColor = true;
            this.transactionRadio.CheckedChanged += new System.EventHandler(this.radioCheckedChanged);
            // 
            // shopItemsGroupBox
            // 
            this.shopItemsGroupBox.Controls.Add(this.itemTypeLabel);
            this.shopItemsGroupBox.Controls.Add(this.itemtypeListBox);
            this.shopItemsGroupBox.Controls.Add(this.sizeLabel);
            this.shopItemsGroupBox.Controls.Add(this.itemSizeListBox);
            this.shopItemsGroupBox.Controls.Add(this.logoPicture);
            this.shopItemsGroupBox.Location = new System.Drawing.Point(44, 56);
            this.shopItemsGroupBox.Name = "shopItemsGroupBox";
            this.shopItemsGroupBox.Size = new System.Drawing.Size(787, 404);
            this.shopItemsGroupBox.TabIndex = 19;
            this.shopItemsGroupBox.TabStop = false;
            this.shopItemsGroupBox.Text = "Shop Items";
            // 
            // orderedItemsGroupBox
            // 
            this.orderedItemsGroupBox.Controls.Add(this.cartOrderLabel);
            this.orderedItemsGroupBox.Controls.Add(this.unitPriceLabel);
            this.orderedItemsGroupBox.Controls.Add(this.totalPriceOutput);
            this.orderedItemsGroupBox.Controls.Add(this.totalPriceLabel);
            this.orderedItemsGroupBox.Controls.Add(this.orderListBox);
            this.orderedItemsGroupBox.Controls.Add(this.completeOrderButton);
            this.orderedItemsGroupBox.Controls.Add(this.subTotalOutput);
            this.orderedItemsGroupBox.Controls.Add(this.quantityNumeric);
            this.orderedItemsGroupBox.Controls.Add(this.subTotalLabel);
            this.orderedItemsGroupBox.Controls.Add(this.quantityLabel);
            this.orderedItemsGroupBox.Controls.Add(this.unitPriceOutput);
            this.orderedItemsGroupBox.Location = new System.Drawing.Point(44, 485);
            this.orderedItemsGroupBox.Name = "orderedItemsGroupBox";
            this.orderedItemsGroupBox.Size = new System.Drawing.Size(787, 357);
            this.orderedItemsGroupBox.TabIndex = 9;
            this.orderedItemsGroupBox.TabStop = false;
            this.orderedItemsGroupBox.Text = "Ordered Items";
            // 
            // cartOrderLabel
            // 
            this.cartOrderLabel.AutoSize = true;
            this.cartOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartOrderLabel.Location = new System.Drawing.Point(521, 33);
            this.cartOrderLabel.Name = "cartOrderLabel";
            this.cartOrderLabel.Size = new System.Drawing.Size(93, 20);
            this.cartOrderLabel.TabIndex = 12;
            this.cartOrderLabel.Text = "Order Cart";
            // 
            // addToOrder
            // 
            this.addToOrder.IsBalloon = true;
            this.addToOrder.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.addToOrder.ToolTipTitle = "Info";
            // 
            // clearToolTip
            // 
            this.clearToolTip.IsBalloon = true;
            this.clearToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.clearToolTip.ToolTipTitle = "Info";
            // 
            // searchToolTip
            // 
            this.searchToolTip.IsBalloon = true;
            this.searchToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.searchToolTip.ToolTipTitle = "Info";
            // 
            // salesToolTip
            // 
            this.salesToolTip.IsBalloon = true;
            this.salesToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.salesToolTip.ToolTipTitle = "Info";
            // 
            // stockToolTip
            // 
            this.stockToolTip.IsBalloon = true;
            this.stockToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.stockToolTip.ToolTipTitle = "Info";
            // 
            // exitToolTip
            // 
            this.exitToolTip.IsBalloon = true;
            this.exitToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.exitToolTip.ToolTipTitle = "Info";
            // 
            // searchGpToolTip
            // 
            this.searchGpToolTip.IsBalloon = true;
            this.searchGpToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.searchGpToolTip.ToolTipTitle = "Info";
            // 
            // clearGpToolTip
            // 
            this.clearGpToolTip.IsBalloon = true;
            this.clearGpToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.clearGpToolTip.ToolTipTitle = "Info";
            // 
            // purchaseToolTip
            // 
            this.purchaseToolTip.IsBalloon = true;
            this.purchaseToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.purchaseToolTip.ToolTipTitle = "Info";
            // 
            // velocityVenturesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1861, 917);
            this.Controls.Add(this.orderedItemsGroupBox);
            this.Controls.Add(this.shopItemsGroupBox);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.buttonPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "velocityVenturesForm";
            this.Text = "Velocity Ventures";
            this.Load += new System.EventHandler(this.velocityVenturesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.shopItemsGroupBox.ResumeLayout(false);
            this.shopItemsGroupBox.PerformLayout();
            this.orderedItemsGroupBox.ResumeLayout(false);
            this.orderedItemsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox itemtypeListBox;
        private System.Windows.Forms.Label itemTypeLabel;
        private System.Windows.Forms.ListBox itemSizeListBox;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.NumericUpDown quantityNumeric;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label totalPriceOutput;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button completeOrderButton;
        private System.Windows.Forms.ListBox orderListBox;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label subTotalOutput;
        private System.Windows.Forms.Label unitPriceLabel;
        private System.Windows.Forms.Label unitPriceOutput;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.RadioButton dateRadio;
        private System.Windows.Forms.RadioButton transactionRadio;
        private System.Windows.Forms.ListBox searchList;
        private System.Windows.Forms.Label formatLabel;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.GroupBox shopItemsGroupBox;
        private System.Windows.Forms.GroupBox orderedItemsGroupBox;
        private System.Windows.Forms.Button clearSearchButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button viewSearchButton;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Button stockButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolTip addToOrder;
        private System.Windows.Forms.ToolTip clearToolTip;
        private System.Windows.Forms.ToolTip searchToolTip;
        private System.Windows.Forms.ToolTip salesToolTip;
        private System.Windows.Forms.ToolTip stockToolTip;
        private System.Windows.Forms.ToolTip exitToolTip;
        private System.Windows.Forms.ToolTip searchGpToolTip;
        private System.Windows.Forms.ToolTip clearGpToolTip;
        private System.Windows.Forms.Label cartOrderLabel;
        private System.Windows.Forms.ToolTip purchaseToolTip;
        private System.Windows.Forms.Label searchResultsLabel;
    }
}

