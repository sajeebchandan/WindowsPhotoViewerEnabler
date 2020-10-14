namespace WindowsPhotoViewerEnabler
{
    partial class WindowsPhotoViewerEnabler
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowsPhotoViewerEnabler));
            this.buttonEnable = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonDisable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEnable
            // 
            this.buttonEnable.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonEnable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnable.FlatAppearance.BorderSize = 0;
            this.buttonEnable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.buttonEnable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.buttonEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnable.ForeColor = System.Drawing.Color.White;
            this.buttonEnable.Location = new System.Drawing.Point(13, 13);
            this.buttonEnable.Name = "buttonEnable";
            this.buttonEnable.Size = new System.Drawing.Size(209, 45);
            this.buttonEnable.TabIndex = 0;
            this.buttonEnable.Text = "Enable Windows Photo Viewer";
            this.buttonEnable.UseVisualStyleBackColor = false;
            this.buttonEnable.Click += new System.EventHandler(this.buttonEnable_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.buttonAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.ForeColor = System.Drawing.Color.White;
            this.buttonAbout.Location = new System.Drawing.Point(13, 123);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(209, 24);
            this.buttonAbout.TabIndex = 1;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonDisable
            // 
            this.buttonDisable.BackColor = System.Drawing.Color.DarkRed;
            this.buttonDisable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDisable.FlatAppearance.BorderSize = 0;
            this.buttonDisable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.buttonDisable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.buttonDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisable.ForeColor = System.Drawing.Color.White;
            this.buttonDisable.Location = new System.Drawing.Point(13, 64);
            this.buttonDisable.Name = "buttonDisable";
            this.buttonDisable.Size = new System.Drawing.Size(209, 45);
            this.buttonDisable.TabIndex = 2;
            this.buttonDisable.Text = "Disable Windows Photo Viewer";
            this.buttonDisable.UseVisualStyleBackColor = false;
            this.buttonDisable.Click += new System.EventHandler(this.buttonDisable_Click);
            // 
            // WindowsPhotoViewerEnabler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(234, 159);
            this.Controls.Add(this.buttonDisable);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonEnable);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowsPhotoViewerEnabler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WindowsPhotoViewerEnabler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEnable;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonDisable;
    }
}

