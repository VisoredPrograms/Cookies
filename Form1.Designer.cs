namespace Cookie_Clicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.ShopBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.Profile = new System.Windows.Forms.PictureBox();
            this.ProfileName = new System.Windows.Forms.Label();
            this.Play = new Cookie_Clicker.Play();
            this.Hub = new Cookie_Clicker.Hub();
            this.Shop = new Cookie_Clicker.Shop();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.Menu.Controls.Add(this.Exit);
            this.Menu.Controls.Add(this.ShopBtn);
            this.Menu.Controls.Add(this.PlayBtn);
            this.Menu.Controls.Add(this.HomeBtn);
            this.Menu.Controls.Add(this.Profile);
            this.Menu.Controls.Add(this.ProfileName);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(202, 501);
            this.Menu.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exit.Location = new System.Drawing.Point(0, 451);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(199, 50);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ShopBtn
            // 
            this.ShopBtn.FlatAppearance.BorderSize = 0;
            this.ShopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShopBtn.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShopBtn.Location = new System.Drawing.Point(0, 295);
            this.ShopBtn.Name = "ShopBtn";
            this.ShopBtn.Size = new System.Drawing.Size(199, 50);
            this.ShopBtn.TabIndex = 4;
            this.ShopBtn.Text = "Shop";
            this.ShopBtn.UseVisualStyleBackColor = true;
            this.ShopBtn.Click += new System.EventHandler(this.ShopBtn_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.FlatAppearance.BorderSize = 0;
            this.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayBtn.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlayBtn.Location = new System.Drawing.Point(0, 239);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(199, 50);
            this.PlayBtn.TabIndex = 3;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HomeBtn.Location = new System.Drawing.Point(0, 183);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(199, 50);
            this.HomeBtn.TabIndex = 2;
            this.HomeBtn.Text = "Hub";
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // Profile
            // 
            this.Profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Profile.Image = global::Cookie_Clicker.Properties.Resources.profile_user;
            this.Profile.Location = new System.Drawing.Point(3, 12);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(196, 100);
            this.Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Profile.TabIndex = 0;
            this.Profile.TabStop = false;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // ProfileName
            // 
            this.ProfileName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProfileName.Location = new System.Drawing.Point(0, 115);
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.Size = new System.Drawing.Size(202, 27);
            this.ProfileName.TabIndex = 1;
            this.ProfileName.Text = "John Doe";
            this.ProfileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.Play.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Play.Location = new System.Drawing.Point(198, 0);
            this.Play.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(747, 501);
            this.Play.TabIndex = 1;
            this.Play.Visible = false;
            // 
            // Hub
            // 
            this.Hub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.Hub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Hub.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Hub.Location = new System.Drawing.Point(198, 0);
            this.Hub.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Hub.Name = "Hub";
            this.Hub.Size = new System.Drawing.Size(747, 501);
            this.Hub.TabIndex = 2;
            // 
            // Shop
            // 
            this.Shop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.Shop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Shop.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Shop.Location = new System.Drawing.Point(198, 0);
            this.Shop.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Shop.Name = "Shop";
            this.Shop.Size = new System.Drawing.Size(747, 501);
            this.Shop.TabIndex = 3;
            this.Shop.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.Shop);
            this.Controls.Add(this.Hub);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Menu);
            this.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.PictureBox Profile;
        private System.Windows.Forms.Label ProfileName;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button HomeBtn;
        private Cookie_Clicker.Play Play;
        private System.Windows.Forms.Button ShopBtn;
        private Hub Hub;
        private Shop Shop;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.OpenFileDialog FileDialog;
    }
}

