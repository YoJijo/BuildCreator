using System;
using LeagueSharp;
using LeagueSharp.Common;
using LeagueSharp.Common.Data;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClipperLib;

namespace Item_Builder_Helper
{
    public partial class Builder : Form
    {
    
        public static List<string> cportraitLoc = new List<string>();
        public static string portraitPath;
        public static string itemImagePath;
        public static string mapNamePath;
        public static List<string[]> itemidName = new List<string[]>();
        public static string buildPathRaw;
        #region ids

        public static int[] Tier5Ids =
        {
             ItemData.Blade_of_the_Ruined_King.Id,  ItemData.Hextech_Gunblade.Id
        };


        public static int[] Tier4Ids =
        {
             ItemData.Abyssal_Scepter.Id,  ItemData.Athenes_Unholy_Grail.Id,
             ItemData.Banner_of_Command.Id,  ItemData.Banshees_Veil.Id,  ItemData.The_Black_Cleaver.Id,
             ItemData.The_Bloodthirster.Id,  ItemData.Dervish_Blade.Id,  ItemData.Entropy.Id,
             ItemData.Essence_Reaver.Id,  ItemData.Face_of_the_Mountain.Id,  ItemData.Frost_Queens_Claim.Id,
             ItemData.Frozen_Heart.Id,  ItemData.Frozen_Mallet.Id,  ItemData.Grezs_Spectral_Lantern.Id,
             ItemData.Guardian_Angel.Id,  ItemData.Hextech_Sweeper.Id,  ItemData.Iceborn_Gauntlet.Id,
             ItemData.Liandrys_Torment.Id,  ItemData.Lich_Bane.Id,  ItemData.Locket_of_the_Iron_Solari.Id,
             ItemData.Lord_Van_Damms_Pillager.Id,  ItemData.Manamune.Id,  ItemData.Maw_of_Malmortius.Id,
             ItemData.Mercurial_Scimitar.Id,  ItemData.Mikaels_Crucible.Id,  ItemData.Morellonomicon.Id,
             ItemData.Nashors_Tooth.Id,  ItemData.Odyns_Veil.Id,  ItemData.Ohmwrecker.Id,
             ItemData.Overlords_Bloodmail.Id,  ItemData.Phantom_Dancer.Id,  ItemData.Randuins_Omen.Id,
             ItemData.Rod_of_Ages.Id,  ItemData.Ruby_Sightstone.Id,  ItemData.Rylais_Crystal_Scepter.Id,
             ItemData.Sanguine_Blade.Id,  ItemData.Spirit_Visage.Id,  ItemData.Statikk_Shiv.Id,
             ItemData.Sunfire_Cape.Id,  ItemData.Talisman_of_Ascension.Id,  ItemData.Thornmail.Id,
             ItemData.Trinity_Force.Id,  ItemData.Twin_Shadows.Id,  ItemData.Warmogs_Armor.Id,
             ItemData.Will_of_the_Ancients.Id,  ItemData.Wooglets_Witchcap.Id,  ItemData.Youmuus_Ghostblade.Id,
             ItemData.Zekes_Herald.Id,  ItemData.Zephyr.Id, ItemData.Zhonyas_Hourglass.Id 
        };

        public static int[] Tier3Ids =
        {
             ItemData.Aegis_of_the_Legion.Id,  ItemData.Aether_Wisp.Id,  ItemData.Avarice_Blade.Id,
             ItemData.Berserkers_Greaves.Id,  ItemData.Boots_of_Mobility.Id,  ItemData.Boots_of_Swiftness.Id,
             ItemData.The_Brutalizer.Id,  ItemData.Catalyst_the_Protector.Id,  ItemData.Chain_Vest.Id,
             ItemData.Chalice_of_Harmony.Id,  ItemData.Crystalline_Bracer.Id,  ItemData.Fiendish_Codex.Id,
             ItemData.Forbidden_Idol.Id,  ItemData.Frostfang.Id,  ItemData.Giants_Belt.Id,  ItemData.Glacial_Shroud.Id,
             ItemData.Guardians_Horn.Id,  ItemData.Guinsoos_Rageblade.Id,  ItemData.Haunting_Guise.Id,
             ItemData.Hexdrinker.Id,  ItemData.Hextech_Revolver.Id,  ItemData.Infinity_Edge.Id,
             ItemData.Ionian_Boots_of_Lucidity.Id,  ItemData.Kindlegem.Id,  ItemData.Last_Whisper.Id,
             ItemData.Madreds_Razors.Id,  ItemData.Mejais_Soulstealer.Id,  ItemData.Mercurys_Treads.Id,
             ItemData.Ninja_Tabi.Id,  ItemData.Nomads_Medallion.Id,  ItemData.Orb_of_Winter.Id,  ItemData.Phage.Id,
             ItemData.Poachers_Knife.Id,  ItemData.Quicksilver_Sash.Id,  ItemData.Rabadons_Deathcap.Id,
             ItemData.Rangers_Trailblazer.Id,  ItemData.Raptor_Cloak.Id,  ItemData.Runaans_Hurricane_Ranged_Only.Id,
             ItemData.Seekers_Armguard.Id,  ItemData.Sheen.Id,  ItemData.Sightstone.Id,  ItemData.Skirmishers_Sabre.Id,
             ItemData.Sorcerers_Shoes.Id,  ItemData.Spectres_Cowl.Id,  ItemData.Stalkers_Blade.Id,  ItemData.Stinger.Id,
             ItemData.Sword_of_the_Occult.Id,  ItemData.Targons_Brace.Id,  ItemData.Tear_of_the_Goddess.Id,
             ItemData.Tiamat_Melee_Only.Id,  ItemData.Vampiric_Scepter.Id,  ItemData.Void_Staff.Id,
             ItemData.Wardens_Mail.Id,  ItemData.Wicked_Hatchet.Id,  ItemData.Wits_End.Id,  ItemData.Zeal.Id 
        };

        public static int[] Tier2Ids =
        {
             ItemData.Amplifying_Tome.Id,  ItemData.Ancient_Coin.Id,  ItemData.B_F_Sword.Id,
             ItemData.Blasting_Wand.Id,  ItemData.Boots_of_Speed.Id,  ItemData.Brawlers_Gloves.Id,
             ItemData.Cloak_of_Agility.Id,  ItemData.Cloth_Armor.Id,  ItemData.Dagger.Id,  ItemData.Dorans_Blade.Id,
             ItemData.Dorans_Ring.Id,  ItemData.Dorans_Shield.Id,  ItemData.Faerie_Charm.Id,
             ItemData.Hunters_Machete.Id,  ItemData.Long_Sword.Id,  ItemData.Needlessly_Large_Rod.Id,
             ItemData.Null_Magic_Mantle.Id,  ItemData.Pickaxe.Id,  ItemData.Prospectors_Blade.Id,
             ItemData.Prospectors_Ring.Id,  ItemData.Recurve_Bow.Id,  ItemData.Rejuvenation_Bead.Id,
             ItemData.Relic_Shield.Id,  ItemData.Ruby_Crystal.Id,  ItemData.Sapphire_Crystal.Id,
             ItemData.Spellthiefs_Edge.Id
        };

        public static int[] Tier1Ids =
        {
             ItemData.Crystalline_Flask.Id,  ItemData.Elixir_of_Iron.Id,
             ItemData.Elixir_of_Ruin.Id,  ItemData.Elixir_of_Sorcery.Id,  ItemData.Elixir_of_Wrath.Id,
             ItemData.Health_Potion.Id,  ItemData.Mana_Potion.Id,  ItemData.Oracles_Extract.Id,
             ItemData.Stealth_Ward.Id,  ItemData.Vision_Ward.Id
        };

        public static int[] Tier0Ids =
        {
             ItemData.Warding_Totem_Trinket.Id,  ItemData.Sweeping_Lens_Trinket.Id,
             ItemData.Scrying_Orb_Trinket.Id,  ItemData.Soul_Anchor_Trinket.Id,
             ItemData.Greater_Stealth_Totem_Trinket.Id,  ItemData.Greater_Vision_Totem_Trinket.Id,
             ItemData.Oracles_Lens_Trinket.Id,  ItemData.Farsight_Orb_Trinket.Id 
        };
        public static int[] AllIds = new int[Tier5Ids.Length + Tier4Ids.Length + Tier3Ids.Length + Tier2Ids.Length + Tier1Ids.Length + Tier0Ids.Length];

        #endregion
        #region names

        public static string[] Tier5Names =
        {
             ItemData.Blade_of_the_Ruined_King.Name,  ItemData.Hextech_Gunblade.Name
        };


        public static string[] Tier4Names =
        {
             ItemData.Abyssal_Scepter.Name,  ItemData.Athenes_Unholy_Grail.Name,
             ItemData.Banner_of_Command.Name,  ItemData.Banshees_Veil.Name,  ItemData.The_Black_Cleaver.Name,
             ItemData.The_Bloodthirster.Name,  ItemData.Dervish_Blade.Name,  ItemData.Entropy.Name,
             ItemData.Essence_Reaver.Name,  ItemData.Face_of_the_Mountain.Name,  ItemData.Frost_Queens_Claim.Name,
             ItemData.Frozen_Heart.Name,  ItemData.Frozen_Mallet.Name,  ItemData.Grezs_Spectral_Lantern.Name,
             ItemData.Guardian_Angel.Name,  ItemData.Hextech_Sweeper.Name,  ItemData.Iceborn_Gauntlet.Name,
             ItemData.Liandrys_Torment.Name,  ItemData.Lich_Bane.Name,  ItemData.Locket_of_the_Iron_Solari.Name,
             ItemData.Lord_Van_Damms_Pillager.Name,  ItemData.Manamune.Name,  ItemData.Maw_of_Malmortius.Name,
             ItemData.Mercurial_Scimitar.Name,  ItemData.Mikaels_Crucible.Name,  ItemData.Morellonomicon.Name,
             ItemData.Nashors_Tooth.Name,  ItemData.Odyns_Veil.Name,  ItemData.Ohmwrecker.Name,
             ItemData.Overlords_Bloodmail.Name,  ItemData.Phantom_Dancer.Name,  ItemData.Randuins_Omen.Name,
             ItemData.Rod_of_Ages.Name,  ItemData.Ruby_Sightstone.Name,  ItemData.Rylais_Crystal_Scepter.Name,
             ItemData.Sanguine_Blade.Name,  ItemData.Spirit_Visage.Name,  ItemData.Statikk_Shiv.Name,
             ItemData.Sunfire_Cape.Name,  ItemData.Talisman_of_Ascension.Name,  ItemData.Thornmail.Name,
             ItemData.Trinity_Force.Name,  ItemData.Twin_Shadows.Name,  ItemData.Warmogs_Armor.Name,
             ItemData.Will_of_the_Ancients.Name,  ItemData.Wooglets_Witchcap.Name,  ItemData.Youmuus_Ghostblade.Name,
             ItemData.Zekes_Herald.Name,  ItemData.Zephyr.Name, ItemData.Zhonyas_Hourglass.Name
        };

        public static string[] Tier3Names =
        {
             ItemData.Aegis_of_the_Legion.Name,  ItemData.Aether_Wisp.Name,  ItemData.Avarice_Blade.Name,
             ItemData.Berserkers_Greaves.Name,  ItemData.Boots_of_Mobility.Name,  ItemData.Boots_of_Swiftness.Name,
             ItemData.The_Brutalizer.Name,  ItemData.Catalyst_the_Protector.Name,  ItemData.Chain_Vest.Name,
             ItemData.Chalice_of_Harmony.Name,  ItemData.Crystalline_Bracer.Name,  ItemData.Fiendish_Codex.Name,
             ItemData.Forbidden_Idol.Name,  ItemData.Frostfang.Name,  ItemData.Giants_Belt.Name,  ItemData.Glacial_Shroud.Name,
             ItemData.Guardians_Horn.Name,  ItemData.Guinsoos_Rageblade.Name,  ItemData.Haunting_Guise.Name,
             ItemData.Hexdrinker.Name,  ItemData.Hextech_Revolver.Name,  ItemData.Infinity_Edge.Name,
             ItemData.Ionian_Boots_of_Lucidity.Name,  ItemData.Kindlegem.Name,  ItemData.Last_Whisper.Name,
             ItemData.Madreds_Razors.Name,  ItemData.Mejais_Soulstealer.Name,  ItemData.Mercurys_Treads.Name,
             ItemData.Ninja_Tabi.Name,  ItemData.Nomads_Medallion.Name,  ItemData.Orb_of_Winter.Name,  ItemData.Phage.Name,
             ItemData.Poachers_Knife.Name,  ItemData.Quicksilver_Sash.Name,  ItemData.Rabadons_Deathcap.Name,
             ItemData.Rangers_Trailblazer.Name,  ItemData.Raptor_Cloak.Name,  ItemData.Runaans_Hurricane_Ranged_Only.Name,
             ItemData.Seekers_Armguard.Name,  ItemData.Sheen.Name,  ItemData.Sightstone.Name,  ItemData.Skirmishers_Sabre.Name,
             ItemData.Sorcerers_Shoes.Name,  ItemData.Spectres_Cowl.Name,  ItemData.Stalkers_Blade.Name,  ItemData.Stinger.Name,
             ItemData.Sword_of_the_Occult.Name,  ItemData.Targons_Brace.Name,  ItemData.Tear_of_the_Goddess.Name,
             ItemData.Tiamat_Melee_Only.Name,  ItemData.Vampiric_Scepter.Name,  ItemData.Void_Staff.Name,
             ItemData.Wardens_Mail.Name,  ItemData.Wicked_Hatchet.Name,  ItemData.Wits_End.Name,  ItemData.Zeal.Name 
        };

        public static string[] Tier2Names =
        {
             ItemData.Amplifying_Tome.Name,  ItemData.Ancient_Coin.Name,  ItemData.B_F_Sword.Name,
             ItemData.Blasting_Wand.Name,  ItemData.Boots_of_Speed.Name,  ItemData.Brawlers_Gloves.Name,
             ItemData.Cloak_of_Agility.Name,  ItemData.Cloth_Armor.Name,  ItemData.Dagger.Name,  ItemData.Dorans_Blade.Name,
             ItemData.Dorans_Ring.Name,  ItemData.Dorans_Shield.Name,  ItemData.Faerie_Charm.Name,
             ItemData.Hunters_Machete.Name,  ItemData.Long_Sword.Name,  ItemData.Needlessly_Large_Rod.Name,
             ItemData.Null_Magic_Mantle.Name,  ItemData.Pickaxe.Name,  ItemData.Prospectors_Blade.Name,
             ItemData.Prospectors_Ring.Name,  ItemData.Recurve_Bow.Name,  ItemData.Rejuvenation_Bead.Name,
             ItemData.Relic_Shield.Name,  ItemData.Ruby_Crystal.Name,  ItemData.Sapphire_Crystal.Name,
             ItemData.Spellthiefs_Edge.Name
        };

        public static string[] Tier1Names =
        {
             ItemData.Crystalline_Flask.Name,  ItemData.Elixir_of_Iron.Name,
             ItemData.Elixir_of_Ruin.Name,  ItemData.Elixir_of_Sorcery.Name,  ItemData.Elixir_of_Wrath.Name,
             ItemData.Health_Potion.Name,  ItemData.Mana_Potion.Name,  ItemData.Oracles_Extract.Name,
             ItemData.Stealth_Ward.Name,  ItemData.Vision_Ward.Name
        };

        public static string[] Tier0Names =
        {
             ItemData.Warding_Totem_Trinket.Name,  ItemData.Sweeping_Lens_Trinket.Name,
             ItemData.Scrying_Orb_Trinket.Name,  ItemData.Soul_Anchor_Trinket.Name,
             ItemData.Greater_Stealth_Totem_Trinket.Name,  ItemData.Greater_Vision_Totem_Trinket.Name,
             ItemData.Oracles_Lens_Trinket.Name,  ItemData.Farsight_Orb_Trinket.Name 
        };
        public static string[] AllNames = new string[Tier5Names.Length + Tier4Names.Length + Tier3Names.Length + Tier2Names.Length + Tier1Names.Length + Tier0Names.Length];

        #endregion

        
        public Builder()
        {
            InitializeComponent();
            #region arrayManage
            //sort and combine arrays

            Tier5Ids.CopyTo(AllIds, 0);
            Tier4Ids.CopyTo(AllIds, Tier5Ids.Length);
            Tier3Ids.CopyTo(AllIds, Tier5Ids.Length + Tier4Ids.Length);
            Tier2Ids.CopyTo(AllIds, Tier5Ids.Length + Tier4Ids.Length + Tier3Ids.Length);
            Tier1Ids.CopyTo(AllIds, Tier5Ids.Length + Tier4Ids.Length + Tier3Ids.Length + Tier2Ids.Length);
            Tier0Ids.CopyTo(AllIds, Tier5Ids.Length + Tier4Ids.Length + Tier3Ids.Length + Tier2Ids.Length + Tier1Ids.Length);
            //Array.Sort(AllIds);

            Tier5Names.CopyTo(AllNames, 0);
            Tier4Names.CopyTo(AllNames, Tier5Names.Length);
            Tier3Names.CopyTo(AllNames, Tier5Names.Length + Tier4Names.Length);
            Tier2Names.CopyTo(AllNames, Tier5Names.Length + Tier4Names.Length + Tier3Names.Length);
            Tier1Names.CopyTo(AllNames, Tier5Names.Length + Tier4Names.Length + Tier3Names.Length + Tier2Names.Length);
            Tier0Names.CopyTo(AllNames, Tier5Names.Length + Tier4Names.Length + Tier3Names.Length + Tier2Names.Length + Tier1Names.Length);
            //Array.Sort(AllNames);
            #endregion

            int i;
            for(i =0; i < AllIds.Length; i++)
            {
                itemidName.Add(new string[] {AllIds[i].ToString(), AllNames[i]});
            }


            
            
        }
        

        public void Builder_Load(object sender, EventArgs e)
        {
            portraitPath = Directory.GetCurrentDirectory() + @"\champ\";
            itemImagePath = Directory.GetCurrentDirectory() + @"\image\";
            mapNamePath = Properties.Settings.Default.AutoSharpport;
            buildPathRaw = Properties.Settings.Default.AutoSharpport;
         
            //champion names
            if (!Directory.Exists(portraitPath)) return;
            DirectoryInfo di = new DirectoryInfo(portraitPath );
            FileInfo[] champ = di.GetFiles("*Square_0.png", SearchOption.AllDirectories);
            List<string> champNames = new List<string>();
            
            foreach (FileInfo f in champ)
            {
                champNames.Add(f.Name.Replace("_Square_0.png", "").Replace("_square_0.png", ""));
                champLBox.Items.Add(f.Name.Replace("_Square_0.png", "").Replace("_square_0.png", ""));
                cportraitLoc.Add(f.FullName);
            }
            
            //map names
            if (!Directory.Exists( mapNamePath)) return;
            DirectoryInfo mapdi = new DirectoryInfo(mapNamePath);
            DirectoryInfo[] map = mapdi.GetDirectories();
            List<string> mapnames = new List<string>();

            foreach (DirectoryInfo m in map)
            {
                mapnames.Add(m.Name);
                mapCBox.Items.Add(m.Name);
            }

            
            
        }

        private void champLBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBuild(champLBox.GetItemText(champLBox.SelectedItem), mapCBox.GetItemText(mapCBox.SelectedItem ));
        }

        private void mapCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBuild(champLBox.GetItemText(champLBox.SelectedItem), mapCBox.GetItemText(mapCBox.SelectedItem));
        }

        public void UpdateBuild(string champName, string mapName)
        {
           flpBuilds.Controls.Clear();
           
                UserControl build = new ChampBuilds(champName, mapName);

                if (champName != "" && mapName != "")
                {
                    if (File.Exists(ChampBuilds.buildPath))
                    {
                        //Console.WriteLine("1" +champName + "2" + mapName + "3");
                        flpBuilds.Controls.Add(build);
                    }
                }
            

        }

        private void newBuildButton_Click(object sender, EventArgs e)
        {
            var d = new NewBuild();
            d.Show();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            var f = new Settings();
            f.Show();
        }
    }
}
