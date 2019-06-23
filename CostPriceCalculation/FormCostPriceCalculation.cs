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
            shareDetails.Add(
                new ShareDetail
                {
                    NoOfShares = 100,
                    PricePerShare = 10,
                    PurchaseDate = new DateTime(2005, 1, 1)
                });
            shareDetails.Add(
                new ShareDetail
                {
                    NoOfShares = 40,
                    PricePerShare = 12,
                    PurchaseDate = new DateTime(2005, 2, 2)
                });
            shareDetails.Add(
                new ShareDetail
                {
                    NoOfShares = 50,
                    PricePerShare = 11,
                    PurchaseDate = new DateTime(2005, 3, 3)
                });

            sharesSold = 0;
            pricePerShare = 0;
            sellDate = new DateTime();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ValidateInputFields())
            {
                CalculateCostPriceDetails();
                ShowHideDetailsLabels(true);
            }
        }

        private void CalculateCostPriceDetails()
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
                if (sellDate > shareDetail.PurchaseDate)
                {
                    if (totalSoldShares > shareDetail.NoOfShares)
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
        }

        private bool ValidateInputFields()
        {
            if (!int.TryParse(txtSharesSold.Text, out sharesSold))
            {
                MessageBox.Show("Please enter correct Shares sold.");
                return false;
            }
            if (!double.TryParse(txtPricePerShare.Text, out pricePerShare))
            {
                MessageBox.Show("Please enter correct Price per Share.");
                return false;
            }
            if (!DateTime.TryParse(txtSellDate.Text, out sellDate))
            {
                MessageBox.Show("Please enter correct Sell Date.");
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
    }

    public class ShareDetail
    {
        public DateTime PurchaseDate { get; set; }
        public int NoOfShares { get; set; }
        public double PricePerShare { get; set; }
    }
}
