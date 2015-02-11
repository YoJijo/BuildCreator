using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Item_Builder_Helper
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            this.FormClosing += updateMain;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            
            //ImageLocLabel.Text = Directory.GetCurrentDirectory() + @"\image\";
            //portraitPathLabel.Text = Directory.GetCurrentDirectory() + @"\champ\"; 
            AutoSharpportLoc.Text = Properties.Settings.Default.AutoSharpport + @"\";
        }

        private void ChangeImageLoc_Click(object sender, EventArgs e)
        {
           
        }

        //private void ChangeRiotPath_Click(object sender, EventArgs e)
        //{
        //    FolderBrowserDialog f = new FolderBrowserDialog();
        //    if (f.ShowDialog() == DialogResult.OK)
        //    {
        //        Properties.Settings.Default.RiotPathn = f.SelectedPath;
        //        Properties.Settings.Default.Save();
        //    }
        //    portraitPathLabel.Text = Directory.GetCurrentDirectory() + Properties.Settings.Default.RiotPathn;

        //}

        private void ChangeSharpLoc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.AutoSharpport = f.SelectedPath;
                Properties.Settings.Default.Save();
            }
            AutoSharpportLoc.Text = Properties.Settings.Default.AutoSharpport + @"\";
        }


        private void updateMain(object sender, System.EventArgs e)
        {
            Form b = new Builder();
            b.Invalidate();
        }
    }
}
