namespace Cookie_Clicker
{
    partial class Play
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
            this.Cookies = new System.Windows.Forms.Label();
            this.Cookie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cookies
            // 
            this.Cookies.AutoSize = true;
            this.Cookies.Location = new System.Drawing.Point(0, 0);
            this.Cookies.Name = "Cookies";
            this.Cookies.Size = new System.Drawing.Size(151, 32);
            this.Cookies.TabIndex = 1;
            this.Cookies.Text = "Cookies: 0";
            // 
            // Cookie
            // 
            this.Cookie.BackgroundImage = global::Cookie_Clicker.Properties.Resources.BiarkG6rT_removebg_preview;
            this.Cookie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cookie.FlatAppearance.BorderSize = 0;
            this.Cookie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cookie.Location = new System.Drawing.Point(272, 150);
            this.Cookie.Name = "Cookie";
            this.Cookie.Size = new System.Drawing.Size(200, 200);
            this.Cookie.TabIndex = 2;
            this.Cookie.TabStop = false;
            this.Cookie.UseVisualStyleBackColor = true;
            this.Cookie.Click += new System.EventHandler(this.Cookie_Click);
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.Cookie);
            this.Controls.Add(this.Cookies);
            this.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Play";
            this.Size = new System.Drawing.Size(745, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Cookies;
        private System.Windows.Forms.Button Cookie;
    }
}
