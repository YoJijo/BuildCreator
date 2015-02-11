namespace Item_Builder_Helper
{
    partial class Builder
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
            this.champLBox = new System.Windows.Forms.ListBox();
            this.mapCBox = new System.Windows.Forms.ComboBox();
            this.flpBuilds = new System.Windows.Forms.FlowLayoutPanel();
            this.newBuildButton = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // champLBox
            // 
            this.champLBox.FormattingEnabled = true;
            this.champLBox.Location = new System.Drawing.Point(12, 37);
            this.champLBox.Name = "champLBox";
            this.champLBox.Size = new System.Drawing.Size(176, 186);
            this.champLBox.TabIndex = 0;
            this.champLBox.SelectedIndexChanged += new System.EventHandler(this.champLBox_SelectedIndexChanged);
            // 
            // mapCBox
            // 
            this.mapCBox.FormattingEnabled = true;
            this.mapCBox.Location = new System.Drawing.Point(12, 10);
            this.mapCBox.Name = "mapCBox";
            this.mapCBox.Size = new System.Drawing.Size(176, 21);
            this.mapCBox.TabIndex = 1;
            this.mapCBox.Text = "Map";
            this.mapCBox.SelectedIndexChanged += new System.EventHandler(this.mapCBox_SelectedIndexChanged);
            // 
            // flpBuilds
            // 
            this.flpBuilds.AutoScroll = true;
            this.flpBuilds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpBuilds.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpBuilds.Location = new System.Drawing.Point(200, 10);
            this.flpBuilds.Margin = new System.Windows.Forms.Padding(0);
            this.flpBuilds.Name = "flpBuilds";
            this.flpBuilds.Size = new System.Drawing.Size(420, 200);
            this.flpBuilds.TabIndex = 2;
            this.flpBuilds.WrapContents = false;
            // 
            // newBuildButton
            // 
            this.newBuildButton.Location = new System.Drawing.Point(200, 213);
            this.newBuildButton.Name = "newBuildButton";
            this.newBuildButton.Size = new System.Drawing.Size(102, 23);
            this.newBuildButton.TabIndex = 3;
            this.newBuildButton.Text = "Create New Build";
            this.newBuildButton.UseVisualStyleBackColor = true;
            this.newBuildButton.Click += new System.EventHandler(this.newBuildButton_Click);
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(473, 213);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(146, 22);
            this.Settings.TabIndex = 4;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Builder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 239);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.newBuildButton);
            this.Controls.Add(this.flpBuilds);
            this.Controls.Add(this.mapCBox);
            this.Controls.Add(this.champLBox);
            this.Name = "Builder";
            this.Text = "Builder";
            this.Load += new System.EventHandler(this.Builder_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox champLBox;
        private System.Windows.Forms.ComboBox mapCBox;
        private System.Windows.Forms.FlowLayoutPanel flpBuilds;
        private System.Windows.Forms.Button newBuildButton;
        private System.Windows.Forms.Button Settings;







    }
}

