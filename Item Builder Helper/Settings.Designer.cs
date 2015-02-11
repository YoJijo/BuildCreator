namespace Item_Builder_Helper
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.portraitPathLabel = new System.Windows.Forms.Label();
            this.AutoSharpportLoc = new System.Windows.Forms.Label();
            this.ChangeSharpLoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // portraitPathLabel
            // 
            this.portraitPathLabel.AutoSize = true;
            this.portraitPathLabel.Location = new System.Drawing.Point(12, 20);
            this.portraitPathLabel.MaximumSize = new System.Drawing.Size(280, 0);
            this.portraitPathLabel.Name = "portraitPathLabel";
            this.portraitPathLabel.Size = new System.Drawing.Size(278, 65);
            this.portraitPathLabel.TabIndex = 1;
            this.portraitPathLabel.Text = resources.GetString("portraitPathLabel.Text");
            // 
            // AutoSharpportLoc
            // 
            this.AutoSharpportLoc.AutoSize = true;
            this.AutoSharpportLoc.Location = new System.Drawing.Point(12, 121);
            this.AutoSharpportLoc.MaximumSize = new System.Drawing.Size(250, 0);
            this.AutoSharpportLoc.Name = "AutoSharpportLoc";
            this.AutoSharpportLoc.Size = new System.Drawing.Size(91, 13);
            this.AutoSharpportLoc.TabIndex = 2;
            this.AutoSharpportLoc.Text = "AutosharpportLoc";
            // 
            // ChangeSharpLoc
            // 
            this.ChangeSharpLoc.Location = new System.Drawing.Point(263, 121);
            this.ChangeSharpLoc.Name = "ChangeSharpLoc";
            this.ChangeSharpLoc.Size = new System.Drawing.Size(74, 26);
            this.ChangeSharpLoc.TabIndex = 4;
            this.ChangeSharpLoc.Text = "Change";
            this.ChangeSharpLoc.UseVisualStyleBackColor = true;
            this.ChangeSharpLoc.Click += new System.EventHandler(this.ChangeSharpLoc_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 188);
            this.Controls.Add(this.ChangeSharpLoc);
            this.Controls.Add(this.AutoSharpportLoc);
            this.Controls.Add(this.portraitPathLabel);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label portraitPathLabel;
        private System.Windows.Forms.Label AutoSharpportLoc;
        private System.Windows.Forms.Button ChangeSharpLoc;
    }
}