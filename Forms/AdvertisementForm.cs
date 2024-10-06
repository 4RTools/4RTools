using _4RTools.Model;
using _4RTools.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4RTools.Forms
{
    public partial class AdvertisementForm : Form
    {
        public AdvertisementForm()
        {
            InitializeComponent();
        }

        private void AdvertisementForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.siteAd.Tag = "https://historyreborn.net/";
                this.pbAd0.ImageLocation = "https://4tools.historyreborn.net/site.png";
                this.siteAd.LinkClicked += new LinkLabelLinkClickedEventHandler(this.onLinkClicked);

                this.wikiAd.Tag = "https://wiki.historyreborn.org/index.php";
                this.pbAd1.ImageLocation = "https://4tools.historyreborn.net/wiki.png";
                this.wikiAd.LinkClicked += new LinkLabelLinkClickedEventHandler(this.onLinkClicked);

                this.discordAd.Tag = "https://discord.gg/historyreborn";
                this.pbAd2.ImageLocation = "https://4tools.historyreborn.net/discord.png";
                this.discordAd.LinkClicked += new LinkLabelLinkClickedEventHandler(this.onLinkClicked);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"[AdvertisementForm] Error Message: {ex.Message}");
            }

        }

        private void onLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel link = (LinkLabel)sender;
            Process.Start(link.Tag.ToString());
            TrackerSingleton.Instance().SendEvent("click", "click", link.Name);
        }
    }
}
