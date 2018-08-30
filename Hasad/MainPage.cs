using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hasad
{
    public partial class MainPage : Form
    {


        public MainPage()
        {
            InitializeComponent();
        }
        

        private void ribbonButtonItemsInfo_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ItemsInfo"] == null)
            {
                new ItemsInfo().Show();
            }
        }
        

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ribbonButtonStoreInfo_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["StoreInfo"] == null)
            {
                new StoreInfo().Show();
            }
        }

        private void ribbonButton6_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["EditBuyAndSellPrices"] == null)
            {
                new EditBuyAndSellPrices().Show();
            }
        }

        private void ribbonButton8_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["OpenningBalancedItems"] == null)
            {
                new OpenningBalancedItems().Show();
            }
        }

        private void ribbonButton10_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["InventoryAdjustment"] == null)
            {
                new InventoryAdjustment().Show();
            }
        }

        private void ribbonButton15_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AssetBalances"] == null)
            {
                new AssetBalances().Show();
            }
        }

        private void ribbonButton14_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["MovementItem"] == null)
            {
                new MovementItem().Show();
            }
        }

        private void ribbonButton13_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AssetsPriceHistory"] == null)
            {
                new AssetsPriceHistory().Show();
            }
        }

        private void ribbonButton12_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ItemsLimits"] == null)
            {
                new ItemsLimits().Show();
            }
        }

        private void ribbonButton4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CompanyInfo"] == null)
            {
                new CompanyInfo().Show();
            }
        }

        private void ribbonButton3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["DataGroups"] == null)
            {
                new DataGroups().Show();
            }
        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["UnitsItems"] == null)
            {
                new UnitsItems().Show();
            }
        }

        private void ribbonButton19_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SalesRepresenetative"] == null)
            {
                new SalesRepresenetative().Show();
            }
        }

        private void ribbonButton18_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SuppliersData"] == null)
            {
                new SuppliersData().Show();
            }
        }

        private void ribbonButton17_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ClientsData"] == null)
            {
                new ClientsData().Show();
            }
        }

        private void ribbonButton16_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ShippingCompaniesData"] == null)
            {
                new ShippingCompaniesData().Show();
            }
        }

        private void ribbonButton21_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["PurchasesBill"] == null)
            {
                new PurchasesBill().Show();
            }
        }

        private void ribbonButton20_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["PurchasesReturn"] == null)
            {
                new PurchasesReturn().Show();
            }
        }

        private void ribbonButton24_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SalesBill"] == null)
            {
                new SalesBill().Show();
            }
        }

        private void ribbonButton23_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SalesBack"] == null)
            {
                new SalesBack().Show();
            }
        }

        private void ribbonButton7_Click(object sender, EventArgs e)
        {

        }

        private void ribbonButton22_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ShowPrices"] == null)
            {
                new ShowPrices().Show();
            }
        }

        private void ribbonButton25_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SalesPoint"] == null)
            {
                new SalesPoint().Show();
            }
        }

        private void ribbonButton29_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RevenueTypes"] == null)
            {
                new RevenueTypes().Show();
            }
        }

        private void ribbonButton28_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ExpensesGroups"] == null)
            {
                new ExpensesGroups().Show();
            }
        }

        private void ribbonButton27_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ExpensesTypes"] == null)
            {
                new ExpensesTypes().Show();
            }
        }

        private void ribbonButton31_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AmountsReceivedForTreasury"] == null)
            {
                new AmountsReceivedForTreasury().Show();
            }
        }

        private void ribbonButton30_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AmountsReceivedForTreasury"] == null)
            {
                new AmountsReceivedForTreasury().Show();
            }
        }

        private void ribbonButton34_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["TreasuryInfo"] == null)
            {
                new TreasuryInfo().Show();
            }
        }

        private void ribbonButton33_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AssetData"] == null)
            {
                new AssetData().Show();
            }
        }

        private void ribbonButton32_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["DepreciationOfAssets"] == null)
            {
                new DepreciationOfAssets().Show();
            }
        }

        private void ribbonButton39_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["TotalCustomerPrices"] == null)
            {
                new TotalCustomerPrices().Show();
            }
        }

        private void ribbonButton37_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["DetailedCustomerPricesWithItems"] == null)
            {
                new DetailedCustomerPricesWithItems().Show();
            }
        }

        private void ribbonButton36_CanvasChanged(object sender, EventArgs e)
        {
            if (Application.OpenForms["TotalSuppliersPrices"] == null)
            {
                new TotalSuppliersPrices().Show();
            }
        }

        private void ribbonButton42_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["PaymentMovementDirector"] == null)
            {
                new PaymentMovementDirector().Show();
            }
        }

        private void ribbonButton41_Click(object sender, EventArgs e)
        {
                if (Application.OpenForms["CustomerPremiumManagement"] == null)
            {
                new CustomerPremiumManagement().Show();
            }
        }

        private void ribbonButton40_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["OutstandingAndLatePremium"] == null)
            {
                new OutstandingAndLatePremium().Show();
            }
        }

        private void ribbonButton45_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["TheTreasure"] == null)
            {
                new TheTreasure().Show();
            }
        }

        private void ribbonButton44_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["MovementsOfTheClosedTreasure"] == null)
            {
                new MovementsOfTheClosedTreasure().Show();
            }
        }

        private void ribbonButton43_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["TransferOfTreasuryAccounts"] == null)
            {
                new TransferOfTreasuryAccounts().Show();
            }
        }

        private void ribbonButton48_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["DetailedProfitReports"] == null)
            {
                new DetailedProfitReports().Show();
            }
        }

        private void ribbonButton47_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["DayMovementData"] == null)
            {
                new DayMovementData().Show();
            }
        }

        private void ribbonButton69_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["PricesMenu"] == null)
            {
                new PricesMenu().Show();
            }
        }

        private void ribbonButton68_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AssetBalances"] == null)
            {
                new AssetBalances().Show();
            }
        }

        private void ribbonButton67_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["MovementItem"] == null)
            {
                new MovementItem().Show();
            }
        }

        private void ribbonButton65_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AssetsPriceHistory"] == null)
            {
                new AssetsPriceHistory().Show();
            }
        }

        private void ribbonButton64_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ItemsLimits"] == null)
            {
                new ItemsLimits().Show();
            }
        }

        private void ribbonButton63_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ExpiredItems"] == null)
            {
                new ExpiredItems().Show();
            }
        }

        private void ribbonButton11_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ExpiredItems"] == null)
            {
                new ExpiredItems().Show();
            }
        }

        private void ribbonButton26_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ScanProductToShowPrice"] == null)
            {
                new ScanProductToShowPrice().Show();
            }
        }
    }//end class 
}//end namespace