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
    public partial class Hub : UserControl
    {
        public Hub()
        {
            // Initialises Components and disables hover color.

            InitializeComponent();

            this.TwitterBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.GithubBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void TwitterBtn_Click(object sender, EventArgs e)
        {
            // Opens a link to Twitter user named, "rekwitz".

            // Creates a new system process.
            // Uses the shell to execute this cmd.
            // FileName = Destination of Link.

            var Twit = new System.Diagnostics.ProcessStartInfo();

            Twit.UseShellExecute = true;
            Twit.FileName = "https://twitter.com/rekwitz";

            System.Diagnostics.Process.Start(Twit);
        }

        private void GithubBtn_Click(object sender, EventArgs e)
        {
            // Opens a link to GitHub user named, "git-tayze".

            // Creates a new system process.
            // Uses the shell to execute this cmd.
            // FileName = Destination of Link.

            var Git = new System.Diagnostics.ProcessStartInfo();

            Git.UseShellExecute = true;
            Git.FileName = "https://github.com/git-tayze";

            System.Diagnostics.Process.Start(Git);
        }
    }
}
