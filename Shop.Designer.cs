namespace Cookie_Clicker
{
    partial class Shop
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClickersText = new System.Windows.Forms.Label();
            this.UpgradesText = new System.Windows.Forms.Label();
            this.ClickersBtn = new System.Windows.Forms.Button();
            this.UpgradesBtn = new System.Windows.Forms.Button();
            this.CurrentClickers = new System.Windows.Forms.Label();
            this.CurrentUpgrades = new System.Windows.Forms.Label();
            this.Undefined = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClickersText
            // 
            this.ClickersText.AutoSize = true;
            this.ClickersText.Location = new System.Drawing.Point(100, 100);
            this.ClickersText.Name = "ClickersText";
            this.ClickersText.Size = new System.Drawing.Size(118, 32);
            this.ClickersText.TabIndex = 0;
            this.ClickersText.Text = "Clickers";
            // 
            // UpgradesText
            // 
            this.UpgradesText.AutoSize = true;
            this.UpgradesText.Location = new System.Drawing.Point(483, 100);
            this.UpgradesText.Name = "UpgradesText";
            this.UpgradesText.Size = new System.Drawing.Size(142, 32);
            this.UpgradesText.TabIndex = 1;
            this.UpgradesText.Text = "Upgrades";
            // 
            // ClickersBtn
            // 
            this.ClickersBtn.BackgroundImage = global::Cookie_Clicker.Properties.Resources.click_png_45042;
            this.ClickersBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClickersBtn.FlatAppearance.BorderSize = 0;
            this.ClickersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClickersBtn.Location = new System.Drawing.Point(60, 140);
            this.ClickersBtn.Name = "ClickersBtn";
            this.ClickersBtn.Size = new System.Drawing.Size(200, 175);
            this.ClickersBtn.TabIndex = 2;
            this.ClickersBtn.UseVisualStyleBackColor = true;
            this.ClickersBtn.Click += new System.EventHandler(this.ClickersBtn_Click);
            // 
            // UpgradesBtn
            // 
            this.UpgradesBtn.BackgroundImage = global::Cookie_Clicker.Properties.Resources.paper_money_1_1s_47px__2_;
            this.UpgradesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpgradesBtn.FlatAppearance.BorderSize = 0;
            this.UpgradesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpgradesBtn.Location = new System.Drawing.Point(460, 140);
            this.UpgradesBtn.Name = "UpgradesBtn";
            this.UpgradesBtn.Size = new System.Drawing.Size(200, 175);
            this.UpgradesBtn.TabIndex = 3;
            this.UpgradesBtn.UseVisualStyleBackColor = true;
            this.UpgradesBtn.Click += new System.EventHandler(this.UpgradesBtn_Click);
            // 
            // CurrentClickers
            // 
            this.CurrentClickers.AutoSize = true;
            this.CurrentClickers.Location = new System.Drawing.Point(120, 318);
            this.CurrentClickers.Name = "CurrentClickers";
            this.CurrentClickers.Size = new System.Drawing.Size(87, 32);
            this.CurrentClickers.TabIndex = 4;
            this.CurrentClickers.Text = "0 CPS";
            // 
            // CurrentUpgrades
            // 
            this.CurrentUpgrades.AutoSize = true;
            this.CurrentUpgrades.Location = new System.Drawing.Point(548, 318);
            this.CurrentUpgrades.Name = "CurrentUpgrades";
            this.CurrentUpgrades.Size = new System.Drawing.Size(44, 32);
            this.CurrentUpgrades.TabIndex = 5;
            this.CurrentUpgrades.Text = "1x";
            // 
            // Undefined
            // 
            this.Undefined.Location = new System.Drawing.Point(0, 250);
            this.Undefined.Name = "Undefined";
            this.Undefined.Size = new System.Drawing.Size(747, 30);
            this.Undefined.TabIndex = 6;
            this.Undefined.Text = "Undefined";
            this.Undefined.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Undefined.Visible = false;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.Undefined);
            this.Controls.Add(this.CurrentUpgrades);
            this.Controls.Add(this.CurrentClickers);
            this.Controls.Add(this.UpgradesBtn);
            this.Controls.Add(this.ClickersBtn);
            this.Controls.Add(this.UpgradesText);
            this.Controls.Add(this.ClickersText);
            this.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Shop";
            this.Size = new System.Drawing.Size(747, 501);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClickersText;
        private System.Windows.Forms.Label UpgradesText;
        private System.Windows.Forms.Button ClickersBtn;
        private System.Windows.Forms.Button UpgradesBtn;
        private System.Windows.Forms.Label CurrentClickers;
        private System.Windows.Forms.Label CurrentUpgrades;
        private System.Windows.Forms.Label Undefined;
    }
}
