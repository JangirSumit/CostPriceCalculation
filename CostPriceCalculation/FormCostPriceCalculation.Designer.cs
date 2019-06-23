namespace CostPriceCalculation
{
    partial class FormCostPriceCalculation
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
            this.pnlInputDetails = new System.Windows.Forms.Panel();
            this.lblDateFormate = new System.Windows.Forms.Label();
            this.txtSellDate = new System.Windows.Forms.TextBox();
            this.txtPricePerShare = new System.Windows.Forms.TextBox();
            this.txtSharesSold = new System.Windows.Forms.TextBox();
            this.lblSellDate = new System.Windows.Forms.Label();
            this.lblPricePerShare = new System.Windows.Forms.Label();
            this.lblSharesSold = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.pnlOutputDetails = new System.Windows.Forms.Panel();
            this.lblCostPriceOfRemainingSharesDetail = new System.Windows.Forms.Label();
            this.lblCostPriceOfRemainingShares = new System.Windows.Forms.Label();
            this.lblNumberOfRemainingSharesDetail = new System.Windows.Forms.Label();
            this.lblNumberOfRemainingShares = new System.Windows.Forms.Label();
            this.lblGainLossOnSaleDetails = new System.Windows.Forms.Label();
            this.lblGainLossOnSale = new System.Windows.Forms.Label();
            this.lblCostPriceofSoldSharesDetail = new System.Windows.Forms.Label();
            this.lblCostPriceOfSoldShares = new System.Windows.Forms.Label();
            this.grvDetails = new System.Windows.Forms.DataGridView();
            this.BuyOrSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoOfShares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCostCalculationMethods = new System.Windows.Forms.ComboBox();
            this.pnlInputDetails.SuspendLayout();
            this.pnlOutputDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInputDetails
            // 
            this.pnlInputDetails.BackColor = System.Drawing.Color.DimGray;
            this.pnlInputDetails.Controls.Add(this.lblDateFormate);
            this.pnlInputDetails.Controls.Add(this.txtSellDate);
            this.pnlInputDetails.Controls.Add(this.txtPricePerShare);
            this.pnlInputDetails.Controls.Add(this.txtSharesSold);
            this.pnlInputDetails.Controls.Add(this.lblSellDate);
            this.pnlInputDetails.Controls.Add(this.lblPricePerShare);
            this.pnlInputDetails.Controls.Add(this.lblSharesSold);
            this.pnlInputDetails.Location = new System.Drawing.Point(13, 13);
            this.pnlInputDetails.Name = "pnlInputDetails";
            this.pnlInputDetails.Size = new System.Drawing.Size(537, 182);
            this.pnlInputDetails.TabIndex = 0;
            // 
            // lblDateFormate
            // 
            this.lblDateFormate.AutoSize = true;
            this.lblDateFormate.ForeColor = System.Drawing.Color.Transparent;
            this.lblDateFormate.Location = new System.Drawing.Point(382, 154);
            this.lblDateFormate.Name = "lblDateFormate";
            this.lblDateFormate.Size = new System.Drawing.Size(112, 13);
            this.lblDateFormate.TabIndex = 7;
            this.lblDateFormate.Text = "(Format : mm/dd/yyyy)";
            // 
            // txtSellDate
            // 
            this.txtSellDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSellDate.Location = new System.Drawing.Point(291, 123);
            this.txtSellDate.Name = "txtSellDate";
            this.txtSellDate.Size = new System.Drawing.Size(200, 24);
            this.txtSellDate.TabIndex = 5;
            // 
            // txtPricePerShare
            // 
            this.txtPricePerShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPricePerShare.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPricePerShare.Location = new System.Drawing.Point(291, 73);
            this.txtPricePerShare.Name = "txtPricePerShare";
            this.txtPricePerShare.Size = new System.Drawing.Size(200, 24);
            this.txtPricePerShare.TabIndex = 4;
            // 
            // txtSharesSold
            // 
            this.txtSharesSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSharesSold.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSharesSold.Location = new System.Drawing.Point(291, 24);
            this.txtSharesSold.Name = "txtSharesSold";
            this.txtSharesSold.Size = new System.Drawing.Size(200, 24);
            this.txtSharesSold.TabIndex = 3;
            // 
            // lblSellDate
            // 
            this.lblSellDate.AutoSize = true;
            this.lblSellDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSellDate.Location = new System.Drawing.Point(41, 126);
            this.lblSellDate.Name = "lblSellDate";
            this.lblSellDate.Size = new System.Drawing.Size(76, 18);
            this.lblSellDate.TabIndex = 2;
            this.lblSellDate.Text = "Sell Date";
            // 
            // lblPricePerShare
            // 
            this.lblPricePerShare.AutoSize = true;
            this.lblPricePerShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricePerShare.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPricePerShare.Location = new System.Drawing.Point(41, 76);
            this.lblPricePerShare.Name = "lblPricePerShare";
            this.lblPricePerShare.Size = new System.Drawing.Size(125, 18);
            this.lblPricePerShare.TabIndex = 1;
            this.lblPricePerShare.Text = "Price per Share";
            // 
            // lblSharesSold
            // 
            this.lblSharesSold.AutoSize = true;
            this.lblSharesSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSharesSold.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSharesSold.Location = new System.Drawing.Point(41, 24);
            this.lblSharesSold.Name = "lblSharesSold";
            this.lblSharesSold.Size = new System.Drawing.Size(100, 18);
            this.lblSharesSold.TabIndex = 0;
            this.lblSharesSold.Text = "Shares Sold";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Silver;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(291, 11);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(200, 30);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // pnlOutputDetails
            // 
            this.pnlOutputDetails.BackColor = System.Drawing.Color.DimGray;
            this.pnlOutputDetails.Controls.Add(this.lblCostPriceOfRemainingSharesDetail);
            this.pnlOutputDetails.Controls.Add(this.lblCostPriceOfRemainingShares);
            this.pnlOutputDetails.Controls.Add(this.lblNumberOfRemainingSharesDetail);
            this.pnlOutputDetails.Controls.Add(this.lblNumberOfRemainingShares);
            this.pnlOutputDetails.Controls.Add(this.lblGainLossOnSaleDetails);
            this.pnlOutputDetails.Controls.Add(this.lblGainLossOnSale);
            this.pnlOutputDetails.Controls.Add(this.lblCostPriceofSoldSharesDetail);
            this.pnlOutputDetails.Controls.Add(this.lblCostPriceOfSoldShares);
            this.pnlOutputDetails.Location = new System.Drawing.Point(12, 257);
            this.pnlOutputDetails.Name = "pnlOutputDetails";
            this.pnlOutputDetails.Size = new System.Drawing.Size(537, 194);
            this.pnlOutputDetails.TabIndex = 1;
            // 
            // lblCostPriceOfRemainingSharesDetail
            // 
            this.lblCostPriceOfRemainingSharesDetail.AutoSize = true;
            this.lblCostPriceOfRemainingSharesDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostPriceOfRemainingSharesDetail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCostPriceOfRemainingSharesDetail.Location = new System.Drawing.Point(288, 147);
            this.lblCostPriceOfRemainingSharesDetail.Name = "lblCostPriceOfRemainingSharesDetail";
            this.lblCostPriceOfRemainingSharesDetail.Size = new System.Drawing.Size(0, 20);
            this.lblCostPriceOfRemainingSharesDetail.TabIndex = 7;
            this.lblCostPriceOfRemainingSharesDetail.Visible = false;
            // 
            // lblCostPriceOfRemainingShares
            // 
            this.lblCostPriceOfRemainingShares.AutoSize = true;
            this.lblCostPriceOfRemainingShares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostPriceOfRemainingShares.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCostPriceOfRemainingShares.Location = new System.Drawing.Point(41, 147);
            this.lblCostPriceOfRemainingShares.Name = "lblCostPriceOfRemainingShares";
            this.lblCostPriceOfRemainingShares.Size = new System.Drawing.Size(234, 20);
            this.lblCostPriceOfRemainingShares.TabIndex = 6;
            this.lblCostPriceOfRemainingShares.Text = "Cost Price of Remianing Shares";
            this.lblCostPriceOfRemainingShares.Visible = false;
            // 
            // lblNumberOfRemainingSharesDetail
            // 
            this.lblNumberOfRemainingSharesDetail.AutoSize = true;
            this.lblNumberOfRemainingSharesDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRemainingSharesDetail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNumberOfRemainingSharesDetail.Location = new System.Drawing.Point(288, 107);
            this.lblNumberOfRemainingSharesDetail.Name = "lblNumberOfRemainingSharesDetail";
            this.lblNumberOfRemainingSharesDetail.Size = new System.Drawing.Size(0, 20);
            this.lblNumberOfRemainingSharesDetail.TabIndex = 5;
            this.lblNumberOfRemainingSharesDetail.Visible = false;
            // 
            // lblNumberOfRemainingShares
            // 
            this.lblNumberOfRemainingShares.AutoSize = true;
            this.lblNumberOfRemainingShares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRemainingShares.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNumberOfRemainingShares.Location = new System.Drawing.Point(41, 107);
            this.lblNumberOfRemainingShares.Name = "lblNumberOfRemainingShares";
            this.lblNumberOfRemainingShares.Size = new System.Drawing.Size(218, 20);
            this.lblNumberOfRemainingShares.TabIndex = 4;
            this.lblNumberOfRemainingShares.Text = "Number of Remaining Shares";
            this.lblNumberOfRemainingShares.Visible = false;
            // 
            // lblGainLossOnSaleDetails
            // 
            this.lblGainLossOnSaleDetails.AutoSize = true;
            this.lblGainLossOnSaleDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGainLossOnSaleDetails.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGainLossOnSaleDetails.Location = new System.Drawing.Point(288, 68);
            this.lblGainLossOnSaleDetails.Name = "lblGainLossOnSaleDetails";
            this.lblGainLossOnSaleDetails.Size = new System.Drawing.Size(0, 20);
            this.lblGainLossOnSaleDetails.TabIndex = 3;
            this.lblGainLossOnSaleDetails.Visible = false;
            // 
            // lblGainLossOnSale
            // 
            this.lblGainLossOnSale.AutoSize = true;
            this.lblGainLossOnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGainLossOnSale.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGainLossOnSale.Location = new System.Drawing.Point(41, 68);
            this.lblGainLossOnSale.Name = "lblGainLossOnSale";
            this.lblGainLossOnSale.Size = new System.Drawing.Size(139, 20);
            this.lblGainLossOnSale.TabIndex = 2;
            this.lblGainLossOnSale.Text = "Gain/Loss on Sale";
            this.lblGainLossOnSale.Visible = false;
            // 
            // lblCostPriceofSoldSharesDetail
            // 
            this.lblCostPriceofSoldSharesDetail.AutoSize = true;
            this.lblCostPriceofSoldSharesDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostPriceofSoldSharesDetail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCostPriceofSoldSharesDetail.Location = new System.Drawing.Point(288, 28);
            this.lblCostPriceofSoldSharesDetail.Name = "lblCostPriceofSoldSharesDetail";
            this.lblCostPriceofSoldSharesDetail.Size = new System.Drawing.Size(0, 20);
            this.lblCostPriceofSoldSharesDetail.TabIndex = 1;
            this.lblCostPriceofSoldSharesDetail.Visible = false;
            // 
            // lblCostPriceOfSoldShares
            // 
            this.lblCostPriceOfSoldShares.AutoSize = true;
            this.lblCostPriceOfSoldShares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostPriceOfSoldShares.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCostPriceOfSoldShares.Location = new System.Drawing.Point(41, 28);
            this.lblCostPriceOfSoldShares.Name = "lblCostPriceOfSoldShares";
            this.lblCostPriceOfSoldShares.Size = new System.Drawing.Size(190, 20);
            this.lblCostPriceOfSoldShares.TabIndex = 0;
            this.lblCostPriceOfSoldShares.Text = "Cost Price of Sold Shares";
            this.lblCostPriceOfSoldShares.Visible = false;
            // 
            // grvDetails
            // 
            this.grvDetails.AllowUserToDeleteRows = false;
            this.grvDetails.BackgroundColor = System.Drawing.Color.DimGray;
            this.grvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BuyOrSell,
            this.Date,
            this.NoOfShares,
            this.Price});
            this.grvDetails.GridColor = System.Drawing.Color.DimGray;
            this.grvDetails.Location = new System.Drawing.Point(556, 13);
            this.grvDetails.Name = "grvDetails";
            this.grvDetails.ReadOnly = true;
            this.grvDetails.Size = new System.Drawing.Size(510, 438);
            this.grvDetails.TabIndex = 2;
            // 
            // BuyOrSell
            // 
            this.BuyOrSell.DataPropertyName = "BuyOrSell";
            this.BuyOrSell.Frozen = true;
            this.BuyOrSell.HeaderText = "Buy Or Sell";
            this.BuyOrSell.Name = "BuyOrSell";
            this.BuyOrSell.ReadOnly = true;
            this.BuyOrSell.Width = 120;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "PurchaseDate";
            this.Date.Frozen = true;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 120;
            // 
            // NoOfShares
            // 
            this.NoOfShares.DataPropertyName = "NoOfShares";
            this.NoOfShares.Frozen = true;
            this.NoOfShares.HeaderText = "No. Of Shares";
            this.NoOfShares.Name = "NoOfShares";
            this.NoOfShares.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "PricePerShare";
            this.Price.Frozen = true;
            this.Price.HeaderText = "Price Per Share";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.cmbCostCalculationMethods);
            this.panel1.Controls.Add(this.btnCalculate);
            this.panel1.Location = new System.Drawing.Point(13, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 50);
            this.panel1.TabIndex = 3;
            // 
            // cmbCostCalculationMethods
            // 
            this.cmbCostCalculationMethods.FormattingEnabled = true;
            this.cmbCostCalculationMethods.ItemHeight = 13;
            this.cmbCostCalculationMethods.Items.AddRange(new object[] {
            "Select Method",
            "FIFO",
            "LIFO",
            "Average Cost"});
            this.cmbCostCalculationMethods.Location = new System.Drawing.Point(44, 15);
            this.cmbCostCalculationMethods.Name = "cmbCostCalculationMethods";
            this.cmbCostCalculationMethods.Size = new System.Drawing.Size(167, 21);
            this.cmbCostCalculationMethods.TabIndex = 9;
            this.cmbCostCalculationMethods.Text = "Select Method";
            // 
            // FormCostPriceCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 463);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grvDetails);
            this.Controls.Add(this.pnlOutputDetails);
            this.Controls.Add(this.pnlInputDetails);
            this.MaximizeBox = false;
            this.Name = "FormCostPriceCalculation";
            this.Text = "Cost Price Calculation";
            this.pnlInputDetails.ResumeLayout(false);
            this.pnlInputDetails.PerformLayout();
            this.pnlOutputDetails.ResumeLayout(false);
            this.pnlOutputDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInputDetails;
        private System.Windows.Forms.Panel pnlOutputDetails;
        private System.Windows.Forms.TextBox txtPricePerShare;
        private System.Windows.Forms.TextBox txtSharesSold;
        private System.Windows.Forms.Label lblSellDate;
        private System.Windows.Forms.Label lblSharesSold;
        private System.Windows.Forms.TextBox txtSellDate;
        private System.Windows.Forms.Label lblPricePerShare;
        private System.Windows.Forms.Label lblDateFormate;
        private System.Windows.Forms.Label lblCostPriceOfRemainingSharesDetail;
        private System.Windows.Forms.Label lblCostPriceOfRemainingShares;
        private System.Windows.Forms.Label lblNumberOfRemainingSharesDetail;
        private System.Windows.Forms.Label lblNumberOfRemainingShares;
        private System.Windows.Forms.Label lblGainLossOnSaleDetails;
        private System.Windows.Forms.Label lblGainLossOnSale;
        private System.Windows.Forms.Label lblCostPriceofSoldSharesDetail;
        private System.Windows.Forms.Label lblCostPriceOfSoldShares;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridView grvDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyOrSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoOfShares;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.ComboBox cmbCostCalculationMethods;
    }
}

