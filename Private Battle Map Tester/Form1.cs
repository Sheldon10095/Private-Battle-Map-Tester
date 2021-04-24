using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Private_Battle_Map_Tester
{
    public partial class Form1 : Form
    {

        public TCPGecko Gecko;
        public uint diff;

        public Form1()
        {
            InitializeComponent();

            this.Gecko = Gecko;
            this.diff = diff;

            NameWrapper[] stages = {
                new NameWrapper("Urchin Underpass", 0),
                new NameWrapper("Walleye Warehouse", 1),
                new NameWrapper("Saltspray Rig", 2),
                new NameWrapper("Arowana Mall", 3),
                new NameWrapper("Blackbelly Skatepark", 4),
                new NameWrapper("Camp Triggerfish", 5),
                new NameWrapper("Port Mackerel", 6),
                new NameWrapper("Kelp Dome", 7),
                new NameWrapper("Moray Towers", 8),
                new NameWrapper("Bluefin Depot", 9),
                new NameWrapper("Hammerhead Bridge", 10),
                new NameWrapper("Flounder Heights", 11),
                new NameWrapper("Museum d'Alfonsino", 12),
                new NameWrapper("Ancho-V Games", 13),
                new NameWrapper("Piranha Pit", 14),
                new NameWrapper("Mahi-Mahi Resort", 15),
                new NameWrapper("Urchin Underpass (Dojo)", 2000),
                new NameWrapper("Walleye Warehouse (Dojo)", 2001),
                new NameWrapper("Saltspray Rig (Dojo)", 2002),
                new NameWrapper("Arowana Mall (Dojo)", 2003),
                new NameWrapper("Blackbelly Skatepark (Dojo)", 2004),
                new NameWrapper("Shooting Range", 3300),
                new NameWrapper("Tutorial 1", 3200),
                new NameWrapper("Tutorial 2", 3210),
                new NameWrapper("Octotrooper Hideout", 1001),
                new NameWrapper("Lair of the Octoballs", 1002),
                new NameWrapper("Rise of the Octocopters", 1003),
                new NameWrapper("Gusher Gauntlet", 1004),
                new NameWrapper("Floating Sponge Garden", 1005),
                new NameWrapper("Propeller Lift Fortress", 1006),
                new NameWrapper("Spreader Splatfest", 1007),
                new NameWrapper("Octoling Invasion", 1008),
                new NameWrapper("Unidentified Flying Object", 1009),
                new NameWrapper("Inkrail Skyscape", 1010),
                new NameWrapper("Inkvisible Avenues", 1011),
                new NameWrapper("Flooder Junkyard", 1012),
                new NameWrapper("Shifting Splatforms", 1013),
                new NameWrapper("Octoling Assault", 1014),
                new NameWrapper("Undeniable Flying Object", 1015),
                new NameWrapper("Propeller Lift Playground", 1016),
                new NameWrapper("Octosniper Ramparts", 1017),
                new NameWrapper("Spinning Spreaders", 1018),
                new NameWrapper("Tumbling Splatforms", 1019),
                new NameWrapper("Octoling Uprising", 1020),
                new NameWrapper("Unwelcome Flying Object", 1021),
                new NameWrapper("Switch Box Shake-Up", 1022),
                new NameWrapper("Spongy Observatory", 1023),
                new NameWrapper("Pinwheel Power Plant", 1024),
                new NameWrapper("Far-Flung Flooders", 1025),
                new NameWrapper("Octoling Onslaught", 1026),
                new NameWrapper("Unavoidable Flying Object", 1027),
                new NameWrapper("Boss 1", 1101),
                new NameWrapper("Boss 2", 1102),
                new NameWrapper("Boss 3", 1103),
                new NameWrapper("Boss 4", 1104),
                new NameWrapper("Boss 5", 1105),
            };

            stage.DataSource = stages;
            stage.SelectedIndex = 0;

            NameWrapper[] modes = {
                new NameWrapper("Turf War", 0),
                new NameWrapper("Rainmaker", 1),
                new NameWrapper("Splat Zones", 2),
                new NameWrapper("Tower Control", 3),
            };

            mode.DataSource = modes;
            mode.SelectedIndex = 0;

        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            Gecko = new TCPGecko(IPBox.Text, 7331);
            try
            {
                Gecko.Connect();
            }
            catch (ETCPGeckoException exc)
            {
                MessageBox.Show("Connection to the TCPGecko failed: \n\n" + exc.Message + "\n\nCheck your network connection/firewall.", "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            editingBox.Enabled = true;
            DisconnButton.Enabled = true;
            ConnectButton.Enabled = false;
        }

        private void DisconnButton_Click(object sender, EventArgs e)
        {
            Gecko.Disconnect();
            editingBox.Enabled = false;
            DisconnButton.Enabled = false;
            ConnectButton.Enabled = true;
        }

        private void poke_Click(object sender, EventArgs e)
        {
            var setStage = ((NameWrapper)stage.SelectedItem).dataName;
            var setMode = ((NameWrapper)mode.SelectedItem).dataName;
            Gecko.poke16(0x1C949964 + diff, (ushort)setStage);
            Gecko.poke16(0x1C949A64 + diff, (ushort)setStage);
            Gecko.poke16(0x1C949960 + diff, (ushort)setMode);
            Gecko.poke16(0x1C949A60 + diff, (ushort)setMode);

            if (first4PlayersAlpha.Checked == true)
            {
                Gecko.poke16(0x1C949966 + diff, 0x0000);
                Gecko.poke16(0x1C949968 + diff, 0x0000);
                Gecko.poke16(0x1C949A66 + diff, 0x0000);
                Gecko.poke16(0x1C949A68 + diff, 0x0000);
            }
        }
    }
}
