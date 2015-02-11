namespace Item_Builder_Helper
{
    partial class NewBuild
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
            this.itemPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flpCreatedBuild = new System.Windows.Forms.FlowLayoutPanel();
            this.searchTbox = new System.Windows.Forms.TextBox();
            this.ChampForCBox = new System.Windows.Forms.ComboBox();
            this.MapForCBox = new System.Windows.Forms.ComboBox();
            this.creatBuildButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemPanel
            // 
            this.itemPanel.AllowDrop = true;
            this.itemPanel.AutoScroll = true;
            this.itemPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.itemPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanel.Location = new System.Drawing.Point(9, 30);
            this.itemPanel.Margin = new System.Windows.Forms.Padding(0);
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.Size = new System.Drawing.Size(365, 148);
            this.itemPanel.TabIndex = 0;
            // 
            // flpCreatedBuild
            // 
            this.flpCreatedBuild.AllowDrop = true;
            this.flpCreatedBuild.AutoScroll = true;
            this.flpCreatedBuild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpCreatedBuild.Location = new System.Drawing.Point(392, 9);
            this.flpCreatedBuild.Name = "flpCreatedBuild";
            this.flpCreatedBuild.Size = new System.Drawing.Size(179, 169);
            this.flpCreatedBuild.TabIndex = 1;
            // 
            // searchTbox
            // 
            this.searchTbox.Location = new System.Drawing.Point(9, 7);
            this.searchTbox.Name = "searchTbox";
            this.searchTbox.Size = new System.Drawing.Size(365, 20);
            this.searchTbox.TabIndex = 2;
            this.searchTbox.Text = "Search for...";
            this.searchTbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ChampForCBox
            // 
            this.ChampForCBox.FormattingEnabled = true;
            this.ChampForCBox.Location = new System.Drawing.Point(12, 181);
            this.ChampForCBox.Name = "ChampForCBox";
            this.ChampForCBox.Size = new System.Drawing.Size(147, 21);
            this.ChampForCBox.TabIndex = 3;
            this.ChampForCBox.Text = "Champion";
            // 
            // MapForCBox
            // 
            this.MapForCBox.FormattingEnabled = true;
            this.MapForCBox.Location = new System.Drawing.Point(165, 181);
            this.MapForCBox.Name = "MapForCBox";
            this.MapForCBox.Size = new System.Drawing.Size(147, 21);
            this.MapForCBox.TabIndex = 4;
            this.MapForCBox.Text = "Map";
            // 
            // creatBuildButton
            // 
            this.creatBuildButton.Location = new System.Drawing.Point(317, 181);
            this.creatBuildButton.Name = "creatBuildButton";
            this.creatBuildButton.Size = new System.Drawing.Size(125, 21);
            this.creatBuildButton.TabIndex = 5;
            this.creatBuildButton.Text = "CreateBuild";
            this.creatBuildButton.UseVisualStyleBackColor = true;
            this.creatBuildButton.Click += new System.EventHandler(this.creatBuildButton_Click);
            // 
            // NewBuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 216);
            this.Controls.Add(this.creatBuildButton);
            this.Controls.Add(this.MapForCBox);
            this.Controls.Add(this.ChampForCBox);
            this.Controls.Add(this.searchTbox);
            this.Controls.Add(this.flpCreatedBuild);
            this.Controls.Add(this.itemPanel);
            this.Name = "NewBuild";
            this.Text = "New Build";
            this.Load += new System.EventHandler(this.NewBuild_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel itemPanel;
        private System.Windows.Forms.FlowLayoutPanel flpCreatedBuild;
        private System.Windows.Forms.TextBox searchTbox;
        private System.Windows.Forms.ComboBox ChampForCBox;
        private System.Windows.Forms.ComboBox MapForCBox;
        private System.Windows.Forms.Button creatBuildButton;
    }
}