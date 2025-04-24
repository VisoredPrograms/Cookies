using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cookie_Clicker
{
    public partial class Shop : UserControl
    {
        public Shop()
        {
            InitializeComponent();

            this.ClickersBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.UpgradesBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private async void ClickersBtn_Click(object sender, EventArgs e)
        {
            if (Form1.Items.CookieAmount >= 1000)
            {
                /*
                Display the success of the AutoClicker,
                Change the text of the current upgrades to, '2x'.
                Change the variable Clicker in Items to itself/true.
                */

                // MessageBox.Show("Sucessfully bought an AutoClicker.");

                this.CurrentClickers.Text = "1 CPS";
                Form1.Items.CookieAmount -= 1000;

                this.Undefined.Text = "Sucess! Clicker: 1 CPS";
                this.Undefined.Visible = true;

                this.ClickersText.Visible = false;
                this.UpgradesText.Visible = false;

                this.UpgradesBtn.Visible = false;
                this.ClickersBtn.Visible = false;

                this.CurrentClickers.Visible = false;
                this.CurrentUpgrades.Visible = false;

                await Task.Delay(2500);

                this.Undefined.Visible = false;
                this.Undefined.Text = "Undefined";

                this.ClickersText.Visible = true;
                this.UpgradesText.Visible = true;

                this.UpgradesBtn.Visible = true;
                this.ClickersBtn.Visible = true;

                this.CurrentClickers.Visible = true;
                this.CurrentUpgrades.Visible = true;

                Form1.Items.PurchasedClicker = true;
            }
            else
            {
                /*
                 Display the failure of the AutoClicker,
                 Change the variable Clicker in Items to,
                 Not itself or not true or simply false.
                 */

                // MessageBox.Show("Try gaining 1000 cookies first!");

                this.Undefined.Text = "Failure! Required: 1000 Cookies.";
                this.Undefined.Visible = true;

                this.ClickersText.Visible = false;
                this.UpgradesText.Visible = false;

                this.UpgradesBtn.Visible = false;
                this.ClickersBtn.Visible = false;

                this.CurrentClickers.Visible = false;
                this.CurrentUpgrades.Visible = false;

                await Task.Delay(2500);

                this.Undefined.Visible = false;
                this.Undefined.Text = "Undefined";

                this.ClickersText.Visible = true;
                this.UpgradesText.Visible = true;

                this.UpgradesBtn.Visible = true;
                this.ClickersBtn.Visible = true;

                this.CurrentClickers.Visible = true;
                this.CurrentUpgrades.Visible = true;

                Form1.Items.PurchasedUpgrade = false;
            }
        }

        private async void UpgradesBtn_Click(object sender, EventArgs e)
        {
            if (Form1.Items.CookieAmount >= 1000)
            {
                /*
                Display the success of the Clickers,
                Change the text of the current clickers to, 'One'.
                Change the variable Upgrade in Items to itself/true.
                */

                // MessageBox.Show("Sucessfully bought an Upgrade.");

                this.CurrentClickers.Text = "2x";
                Form1.Items.CookieAmount -= 1000;

                this.Undefined.Text = "Success! Upgrade: 2x";
                this.Undefined.Visible = true;

                this.ClickersText.Visible = false;
                this.UpgradesText.Visible = false;

                this.UpgradesBtn.Visible = false;
                this.ClickersBtn.Visible = false;

                this.CurrentClickers.Visible = false;
                this.CurrentUpgrades.Visible = false;

                await Task.Delay(2500);

                this.Undefined.Visible = false;
                this.Undefined.Text = "Undefined";

                this.ClickersText.Visible = true;
                this.UpgradesText.Visible = true;

                this.UpgradesBtn.Visible = true;
                this.ClickersBtn.Visible = true;

                this.CurrentClickers.Visible = true;
                this.CurrentUpgrades.Visible = true;

                Form1.Items.PurchasedUpgrade = true;
                Form1.Items.Upgrade = 2;
            }
            else
            {
                /*
                Display the failure of the Upgrade,
                Change the variable Upgrade in Items to,
                Not itself or not true or simply false.
                */

                // MessageBox.Show("Try gaining 1000 cookies first!");

                this.Undefined.Text = "Failure! Required: 1000 Cookies.";
                this.Undefined.Visible = true;

                this.ClickersText.Visible = false;
                this.UpgradesText.Visible = false;

                this.UpgradesBtn.Visible = false;
                this.ClickersBtn.Visible = false;

                this.CurrentClickers.Visible = false;
                this.CurrentUpgrades.Visible = false;

                await Task.Delay(2500);

                this.Undefined.Visible = false;
                this.Undefined.Text = "Undefined";

                this.ClickersText.Visible = true;
                this.UpgradesText.Visible = true;

                this.UpgradesBtn.Visible = true;
                this.ClickersBtn.Visible = true;

                this.CurrentClickers.Visible = true;
                this.CurrentUpgrades.Visible = true;

                Form1.Items.PurchasedUpgrade = false;
            }
        }
    }
}
