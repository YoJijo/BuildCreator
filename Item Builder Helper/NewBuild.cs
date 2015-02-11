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
using SharpDX.Direct3D9;

namespace Item_Builder_Helper
{
    public partial class NewBuild : Form
    {
        private Control control;

        public NewBuild(Control control)
        {
            this.control = control;
        }

        public Control Control
        {
            get { return control; }
        }

        private void MyMouseDown(object sender, MouseEventArgs e)
        {
            Control source = (Control) sender;
            if (e.Button == MouseButtons.Right)
            {
                source.Dispose();
                return;
            }
            source.DoDragDrop(new NewBuild(source), DragDropEffects.Move);
        }

        //private void removeItem(object sender, MouseEventArgs e)
        //{
        //    MessageBox.Show(e.Button.ToString());
        //}

        private void newControl(object sender, System.EventArgs e)
        {
            FlowLayoutPanel flp = (FlowLayoutPanel) sender;
            foreach (Control control in flp.Controls)
            {
                control.MouseDown += MyMouseDown;
                //control.MouseClick += removeItem;
            }
        }

        private void flpBuildCreated_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof (NewBuild)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void flpBuildCreated_DragDrop(object sender, DragEventArgs e)
        {
            NewBuild wrapper = (NewBuild) e.Data.GetData(typeof (NewBuild));
            Control source = wrapper.Control;

            Point mousePosition = flpCreatedBuild.PointToClient(new Point(e.X, e.Y));
            Control destination = flpCreatedBuild.GetChildAtPoint(mousePosition);

            int indexDestination = flpCreatedBuild.Controls.IndexOf(destination);
            if (flpCreatedBuild.Controls.IndexOf(source) < indexDestination)
                indexDestination--;

            flpCreatedBuild.Controls.SetChildIndex(source, indexDestination);
        }

        public NewBuild()
        {

            InitializeComponent();

        }

        private void NewBuild_Load(object sender, EventArgs e)
        {

            DirectoryInfo di = new DirectoryInfo(Builder.portraitPath);
            FileInfo[] champ = di.GetFiles("*Square_0.png", SearchOption.AllDirectories);
            foreach (FileInfo f in champ)
            {
                ChampForCBox.Items.Add(f.Name.Replace("_Square_0.png", "").Replace("_square_0.png", ""));
            }
            DirectoryInfo mapdi = new DirectoryInfo(Builder.mapNamePath);
            DirectoryInfo[] map = mapdi.GetDirectories();
            foreach (DirectoryInfo m in map)
            {
                MapForCBox.Items.Add(m.Name);
            }
            flpCreatedBuild.ControlAdded += newControl;
            flpCreatedBuild.DragEnter += flpBuildCreated_DragEnter;
            flpCreatedBuild.DragDrop += flpBuildCreated_DragDrop;
            itemPanel.Controls.Clear();
            string itemloc = Builder.itemImagePath;
            DirectoryInfo itemdi = new DirectoryInfo(itemloc);
            FileInfo[] item = itemdi.GetFiles();

            Array.Sort(Builder.AllIds);
            foreach (int validitem in Builder.AllIds)
            {

                foreach (FileInfo f in item)
                {
                    if (f.Name.Contains(validitem.ToString()))
                    {
                        PictureBox p = new PictureBox();
                        ToolTip tt = new ToolTip();
                        foreach (string[] w in Builder.itemidName)
                        {
                            if (validitem == Convert.ToInt32(w[0])) tt.SetToolTip(p, w[1]);
                        }
                        p.ImageLocation = f.FullName;
                        p.SizeMode = PictureBoxSizeMode.StretchImage;
                        p.Name = validitem.ToString();
                        p.WaitOnLoad = true;
                        p.Width = 40;
                        p.Height = 40;
                        p.Click += new EventHandler(item_Click);
                        itemPanel.Controls.Add(p);
                    }
                }
            }
        }

        private void item_Click(object sender, System.EventArgs e)
        {
            PictureBox pp = (PictureBox) sender;
            PictureBox pp1 = new PictureBox();
            ToolTip tt1 = new ToolTip();
            foreach (string[] r in Builder.itemidName)
            {
                if (r[0] == pp.Name) tt1.SetToolTip(pp1, r[1]);
            }
            pp1.ImageLocation = pp.ImageLocation;
            pp1.SizeMode = pp.SizeMode;
            pp1.Name = pp.Name;
            pp1.WaitOnLoad = pp.WaitOnLoad;
            pp1.Width = pp.Width;
            pp1.Height = pp.Height;
            flpCreatedBuild.Controls.Add(pp1);

            Console.WriteLine(pp.Name);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            itemPanel.Controls.Clear();
            List<int> usableitemid = new List<int>();
            string itemloc2 = Builder.itemImagePath;
            DirectoryInfo itemdi2 = new DirectoryInfo(itemloc2);
            FileInfo[] item2 = itemdi2.GetFiles();

            foreach (string[] q in Builder.itemidName)
            {
                if (q[1].ToLower().Contains(searchTbox.Text.ToLower()))
                {
                    usableitemid.Add(Convert.ToInt32(q[0]));
                }
            }
            foreach (int useid in usableitemid)
            {
                if (Builder.AllIds.Contains(useid))
                {
                    foreach (FileInfo f in item2)
                    {
                        if (f.Name.Contains(useid.ToString()))
                        {
                            PictureBox p = new PictureBox();
                            ToolTip tt = new ToolTip();
                            foreach (string[] w in Builder.itemidName)
                            {
                                if (useid == Convert.ToInt32(w[0])) tt.SetToolTip(p, w[1]);
                            }
                            p.ImageLocation = f.FullName;
                            p.SizeMode = PictureBoxSizeMode.StretchImage;
                            p.Name = useid.ToString();
                            p.WaitOnLoad = true;
                            p.Width = 40;
                            p.Height = 40;
                            p.Click += new EventHandler(item_Click);
                            itemPanel.Controls.Add(p);
                        }
                    }
                }
            }
        }

        private void creatBuildButton_Click(object sender, EventArgs e)
        {
            //DirectoryInfo champsdi = new DirectoryInfo(Builder.buildPathRaw + @"\" + MapForCBox.Text );
            //FileInfo[] champsfiles = champsdi.GetFiles();
            //foreach (FileInfo f in champsfiles)

            if (File.Exists(Builder.buildPathRaw + @"\" + MapForCBox.Text + @"\" + ChampForCBox.Text + @".txt"))
            {
                DialogResult cont;
                cont = MessageBox.Show("A build for that champion already exists. Would you like to replace it?",
                    "Pre-Existing Build", MessageBoxButtons.YesNo);
                if (cont == DialogResult.No)
                {
                    return;
                }
                else
                {
                    string newbuildloc = Builder.buildPathRaw + @"\" + MapForCBox.Text + @"\" + ChampForCBox.Text +
                                         @".txt";
                    StreamWriter newbuild = new StreamWriter(newbuildloc, true);
                    foreach (Control c in flpCreatedBuild.Controls)
                    {
                        newbuild.WriteLine(c.Name);
                    }
                    newbuild.Close();
                    MessageBox.Show("New build for " + ChampForCBox.Text + " on the map " + MapForCBox.Text + " completed.", "New Build");
                    }
            }
        }
    }
}


