namespace velocityVentures
{
    partial class salesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(salesForm));
            this.salesList = new System.Windows.Forms.ListBox();
            this.exitSalesButton = new System.Windows.Forms.Button();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.salesLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.exitSalesToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // salesList
            // 
            this.salesList.FormattingEnabled = true;
            this.salesList.HorizontalScrollbar = true;
            this.salesList.ItemHeight = 20;
            this.salesList.Location = new System.Drawing.Point(61, 242);
            this.salesList.Name = "salesList";
            this.salesList.Size = new System.Drawing.Size(528, 264);
            this.salesList.TabIndex = 0;
            // 
            // exitSalesButton
            // 
            this.exitSalesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.exitSalesButton.Location = new System.Drawing.Point(212, 538);
            this.exitSalesButton.Name = "exitSalesButton";
            this.exitSalesButton.Size = new System.Drawing.Size(172, 36);
            this.exitSalesButton.TabIndex = 13;
            this.exitSalesButton.Text = "Ex&it";
            this.exitSalesToolTip.SetToolTip(this.exitSalesButton, "Press to close the Sales Report");
            this.exitSalesButton.UseVisualStyleBackColor = false;
            this.exitSalesButton.Click += new System.EventHandler(this.exitSalesButtonClick);
            // 
            // logoPicture
            // 
            this.logoPicture.Image = ((System.Drawing.Image)(resources.GetObject("logoPicture.Image")));
            this.logoPicture.Location = new System.Drawing.Point(222, 29);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(202, 159);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPicture.TabIndex = 14;
            this.logoPicture.TabStop = false;
            // 
            // salesLabel
            // 
            this.salesLabel.AutoSize = true;
            this.salesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesLabel.Location = new System.Drawing.Point(57, 210);
            this.salesLabel.Name = "salesLabel";
            this.salesLabel.Size = new System.Drawing.Size(100, 20);
            this.salesLabel.TabIndex = 15;
            this.salesLabel.Text = "Total Value";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(247, 210);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(76, 20);
            this.quantityLabel.TabIndex = 16;
            this.quantityLabel.Text = "Quantity";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(401, 210);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(71, 20);
            this.productLabel.TabIndex = 17;
            this.productLabel.Text = "Product";
            // 
            // exitSalesToolTip
            // 
            this.exitSalesToolTip.IsBalloon = true;
            this.exitSalesToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.exitSalesToolTip.ToolTipTitle = "Info";
            // 
            // salesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 631);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.salesLabel);
            this.Controls.Add(this.logoPicture);
            this.Controls.Add(this.exitSalesButton);
            this.Controls.Add(this.salesList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "salesForm";
            this.Text = "Velocity Ventures Sales Report";
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox salesList;
        private System.Windows.Forms.Button exitSalesButton;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.Label salesLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.ToolTip exitSalesToolTip;
    }
}