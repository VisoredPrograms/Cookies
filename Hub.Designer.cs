namespace Cookie_Clicker
{
    partial class Hub
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
            this.Sentence1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TwitterBtn = new System.Windows.Forms.Button();
            this.GithubBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sentence1
            // 
            this.Sentence1.Location = new System.Drawing.Point(0, 96);
            this.Sentence1.Name = "Sentence1";
            this.Sentence1.Size = new System.Drawing.Size(747, 54);
            this.Sentence1.TabIndex = 0;
            this.Sentence1.Text = "This is a little project I made while bored.";
            this.Sentence1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(747, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "It was made to learn C# and Windows Forms";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(747, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "My socials will be linked below this.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TwitterBtn
            // 
            this.TwitterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TwitterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TwitterBtn.FlatAppearance.BorderSize = 0;
            this.TwitterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwitterBtn.Location = new System.Drawing.Point(249, 300);
            this.TwitterBtn.Name = "TwitterBtn";
            this.TwitterBtn.Size = new System.Drawing.Size(105, 35);
            this.TwitterBtn.TabIndex = 4;
            this.TwitterBtn.Text = "Twitter";
            this.TwitterBtn.UseVisualStyleBackColor = true;
            this.TwitterBtn.Click += new System.EventHandler(this.TwitterBtn_Click);
            // 
            // GithubBtn
            // 
            this.GithubBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GithubBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GithubBtn.FlatAppearance.BorderSize = 0;
            this.GithubBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GithubBtn.Location = new System.Drawing.Point(360, 300);
            this.GithubBtn.Name = "GithubBtn";
            this.GithubBtn.Size = new System.Drawing.Size(115, 35);
            this.GithubBtn.TabIndex = 5;
            this.GithubBtn.Text = "GitHub";
            this.GithubBtn.UseVisualStyleBackColor = true;
            this.GithubBtn.Click += new System.EventHandler(this.GithubBtn_Click);
            // 
            // Hub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.GithubBtn);
            this.Controls.Add(this.TwitterBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sentence1);
            this.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Hub";
            this.Size = new System.Drawing.Size(747, 501);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Sentence1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TwitterBtn;
        private System.Windows.Forms.Button GithubBtn;
    }
}
