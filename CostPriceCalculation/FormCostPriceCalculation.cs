using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CostPriceCalculation
{
    public partial class FormCostPriceCalculation : Form
    {
        List<ShareDetail> shareDetails = new List<ShareDetail>();
        int sharesSold;
        double pricePerShare;
        DateTime sellDate;

        public FormCostPriceCalculation()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            shareDetails = new List<ShareDetail>();
            shareDetails.Add(
                new ShareDetail
                {
                    NoOfShares = 100,
                    PricePerShare = 10,
                    PurchaseDate = new DateTime(2005, 1, 1),
                    BuyOrSell = "Buy"
                });
            shareDetails.Add(
                new ShareDetail
                {
                    NoOfShares = 40,
                    PricePerShare = 12,
                    PurchaseDate = new DateTime(2005, 2, 2),
                    BuyOrSell = "Buy"
                });
            shareDetails.Add(
                new ShareDetail
                {
                    NoOfShares = 50,
                    PricePerShare = 11,
                    PurchaseDate = new DateTime(2005, 3, 3),
                    BuyOrSell = "Buy"
                });

            sharesSold = 0;
            pricePerShare = 0;
            sellDate = new DateTime();

            grvDetails.DataSource = shareDetails;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ValidateInputFields())
            {
                CalculateCostPriceDetails();
                ShowHideDetailsLabels(true);
                FillGridData();
            }
        }

        private void FillGridData()
        {
            var newShareDetails = shareDetails;
            newShareDetails.Add(
                new ShareDetail
                {
                    NoOfShares = sharesSold,
                    PricePerShare = pricePerShare,
                    PurchaseDate = sellDate,
                    BuyOrSell = "Sell"
                });

            grvDetails.DataSource = shareDetails.OrderBy(a => a.PurchaseDate).ToList();
        }

        private void CalculateCostPriceDetails()
        {
            switch (cmbCostCalculationMethods.SelectedItem.ToString())
            {
                case "FIFO":
                    FIFO();
                    break;
                case "LIFO":
                    LIFO();
                    break;
                case "Average Cost":
                    AverageCost();
                    break;
                default:
                    break;
            }
        }

        private void AverageCost()
        {
            MessageBox.Show("No Implementation.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void LIFO()
        {
            MessageBox.Show("No Implementation.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void FIFO()
        {
            int remainingShares = 0;
            double costPriceOfSoldShares = 0;
            double gainLoss = 0;
            double costOfRemainingShares = 0;
            double totalPriceOfRemainingShares = 0;

            int totalSoldShares = sharesSold;
            double totalPriceOfSoldSharesAgainstPurchaseShares = 0;
            double totalPriceOfSoldShares = 0;

            foreach (var shareDetail in shareDetails.OrderBy(a => a.PurchaseDate))
            {
                if (sellDate >= shareDetail.PurchaseDate)
                {
                    if (totalSoldShares >= shareDetail.NoOfShares)
                    {
                        totalSoldShares -= shareDetail.NoOfShares;
                        totalPriceOfSoldSharesAgainstPurchaseShares += shareDetail.NoOfShares * shareDetail.PricePerShare;
                    }
                    else
                    {
                        remainingShares = shareDetail.NoOfShares - totalSoldShares;
                        totalPriceOfSoldSharesAgainstPurchaseShares += totalSoldShares * shareDetail.PricePerShare;
                        totalPriceOfRemainingShares += remainingShares * shareDetail.PricePerShare;
                    }
                }
                else
                {
                    remainingShares += shareDetail.NoOfShares;
                    totalPriceOfRemainingShares += shareDetail.NoOfShares * shareDetail.PricePerShare;
                }
            }

            totalPriceOfSoldShares = sharesSold * pricePerShare;
            gainLoss = totalPriceOfSoldShares - totalPriceOfSoldSharesAgainstPurchaseShares;

            costPriceOfSoldShares = totalPriceOfSoldSharesAgainstPurchaseShares / sharesSold;
            costOfRemainingShares = totalPriceOfRemainingShares / remainingShares;

            UpdateCostPriceDetails(costPriceOfSoldShares, gainLoss, remainingShares, costOfRemainingShares);
        }

        private void UpdateCostPriceDetails(double costPriceOfSoldShares, double gainLoss, int remainingShares, double costOfRemainingShares)
        {
            lblCostPriceOfRemainingSharesDetail.Text = Convert.ToString(Math.Round(costOfRemainingShares, 3));
            lblCostPriceofSoldSharesDetail.Text = Convert.ToString(Math.Round(costPriceOfSoldShares, 3));
            lblNumberOfRemainingSharesDetail.Text = Convert.ToString(remainingShares);
            lblGainLossOnSaleDetails.Text = Convert.ToString(Math.Round(gainLoss, 3));
            lblGainLossOnSaleDetails.ForeColor = gainLoss < 0 ? System.Drawing.Color.Red : System.Drawing.Color.LawnGreen;
        }

        private bool ValidateInputFields()
        {
            if (cmbCostCalculationMethods.SelectedItem.ToString() == "Select Method")
            {
                MessageBox.Show("Please select Valid Method Type", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtSharesSold.Text, out sharesSold))
            {
                MessageBox.Show("Please enter correct Shares sold.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            if (!double.TryParse(txtPricePerShare.Text, out pricePerShare))
            {
                MessageBox.Show("Please enter correct Price per Share.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            if (!DateTime.TryParse(txtSellDate.Text, out sellDate))
            {
                MessageBox.Show("Please enter correct Sell Date.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void ShowHideDetailsLabels(Boolean show)
        {
            lblCostPriceOfRemainingShares.Visible = show;
            lblCostPriceOfRemainingSharesDetail.Visible = show;
            lblCostPriceOfSoldShares.Visible = show;
            lblCostPriceofSoldSharesDetail.Visible = show;
            lblGainLossOnSale.Visible = show;
            lblNumberOfRemainingSharesDetail.Visible = show;
            lblGainLossOnSaleDetails.Visible = show;
            lblNumberOfRemainingShares.Visible = show;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ShowHideDetailsLabels(false);
            InitializeData();
            UpdateCostPriceDetails(0, 0, 0, 0);

            txtPricePerShare.Text = txtSellDate.Text = txtSharesSold.Text = "";
            cmbCostCalculationMethods.SelectedIndex = 0;
        }
    }

    public class ShareDetail
    {
        public DateTime PurchaseDate { get; set; }
        public int NoOfShares { get; set; }
        public double PricePerShare { get; set; }
        public string BuyOrSell { get; set; }
    }
}