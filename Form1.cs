using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Cookie_Clicker
{
    public partial class Form1 : Form
    {
        public static Items Items = new Items();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // Height of ellipse
            int nHeightEllipse // Width of ellipse
        );

        public Form1()
        {
            // Initialises Components, disable maximizing and hide play.

            InitializeComponent();
            this.MaximizeBox = false;

            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            /*
            Hide everything that is not the play tab.
            Displays the play tab and bring it to the front.
            */

            this.Hub.Hide();
            this.Shop.Hide();

            this.Play.Show();
            this.Play.BringToFront();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            /*
            Hide everything that is not the home tab.
            Displays the home tab and bring it to the front.
            */

            this.Play.Hide();
            this.Shop.Hide();

            this.Hub.Show();
            this.Hub.BringToFront();
        }

        private void ShopBtn_Click(object sender, EventArgs e)
        {
            /*
            Hide everything that is not the home tab.
            Displays the home tab and bring it to the front.
            */

            this.Play.Hide();
            this.Hub.Hide();

            this.Shop.Show();
            this.Shop.BringToFront();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            // Quit the application.

            Application.Exit();
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            FileDialog.Filter = "Image (*.jpg; *.png; *.ico)|*.jpg;*.gif;*.ico;*.jpeg;*.jpg";

            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                Profile.ImageLocation = FileDialog.FileName;
            }

        }
    }
}
