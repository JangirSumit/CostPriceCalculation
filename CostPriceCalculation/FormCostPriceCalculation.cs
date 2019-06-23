using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CostPriceCalculation
{
    public partial class FormCostPriceCalculation : Form
    {
        List<ShareDetail> shareDetails = new List<ShareDetail>();
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
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ShowHideDetailsLabels(true);
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
