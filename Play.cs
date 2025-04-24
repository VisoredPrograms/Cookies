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
    public partial class Play : UserControl
    {

        public Play()
        {
            // Initialises Components, references an object and disables hover color.

            InitializeComponent();
            this.Cookie.FlatAppearance.MouseOverBackColor = Color.Transparent;

            FetchCookies(50);
            AutoClicker(1000);
        } 

        private async void FetchCookies(int Timeout)
        {
            while (true)
            {
                await Task.Delay(Timeout);
                this.Cookies.Text = "Cookies: " + Form1.Items.CookieAmount;
            }
        }

        private async void AutoClicker(int Timeout)
        {
            while (true)
            {
                await Task.Delay(Timeout);

                if (Form1.Items.PurchasedClicker)
                {
                    Form1.Items.CookieAmount += 1 * Form1.Items.Upgrade;
                }
            }
        }

        private void Cookie_Click(object sender, EventArgs e)
        {
            /*
            Updates cookies by one and display it.
            Multiplies 1 by Items.Upgrade.
            Items.Upgrade default is 1.
            
            1 * Upgrade: default = 1
            1 * Upgrade: real value = 2
            */

            Form1.Items.CookieAmount += 1 * Form1.Items.Upgrade;

        }
    }
}
