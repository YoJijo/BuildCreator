using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using LeagueSharp.Common;
using LeagueSharp.Common.Data;

namespace Item_Builder_Helper
{
    public partial class ChampBuilds : UserControl
    {
        public string champName ;
        public string mapName;
        public static string buildPath;
        

        
        

       

        public ChampBuilds(string champ, string map)
        {
           
            InitializeComponent();
            champName = champ;
            mapName = map;
            buildPath = Properties.Settings.Default.AutoSharpport + @"\" + mapName + @"\" + champName + ".txt";
        }

        private void ChampBuilds_Load(object sender, EventArgs e)
        {
            portraitPBox.ImageLocation =  Builder.portraitPath +champName + "_Square_0.png";
                mapNameLabel.Text = mapName;
            
            //item picture handling

            
             if (!File.Exists(buildPath))
             {
                 
                return;
            }
            List<string > itemsId = new List<string>();
            StreamReader itemsText = new StreamReader(buildPath );
            

            while (itemsText.Peek()> -1)
            {
                itemsId.Add(itemsText.ReadLine().Replace("[","").Replace("]",""));
            }
            itemsText.Close();

            //itemids
            
            DirectoryInfo itemdi = new DirectoryInfo(Builder.itemImagePath);
            FileInfo[] item = itemdi.GetFiles();
            List<string> itemtouse = new List<string>();
            

            foreach (string id in itemsId)
            {
                foreach (int id2 in Builder.AllIds)
                {
                    if (id2.ToString() == id && Array.IndexOf(Builder.Tier0Ids, Convert.ToInt32(id)) == -1)
                    {
                        foreach (var p in Controls.OfType<PictureBox>())
                        {
                            if (p.Name.Contains("item") && p.ImageLocation == null)
                            {
                                foreach (FileInfo t in item)
                                {
                                    if (t.ToString().Contains(id))
                                    {
                                        p.ImageLocation = t.FullName;
                                        goto nextItem;
                                    }
                                }
                            }
                        }
                    }
                }
            nextItem:
                ;
            }

            // trinket
            foreach (string id3 in itemsId)
            {
                foreach (int id4 in Builder.Tier0Ids)
                {
                    if (id4.ToString() == id3)
                    {
  
                        foreach (FileInfo t in item)
                        {
                            if (t.ToString().Contains(id3))
                            {
                                trinketPBox.ImageLocation = t.FullName;
                            }
                        }  
                    }
                }
            }
        }

    }
}
