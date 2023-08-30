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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AdvertisementForm_Load(object sender, EventArgs e)
        {
            List<Advertiser> ads = Advertiser.LoadAdvertiser();

            try
            {
                Console.WriteLine(ads.Count);
                for (int i = 0; i < ads.Count; i++)
                {
                    LinkLabel linkWebsite = (LinkLabel)this.Controls.Find("siteAd" + i, true)[0];
                    LinkLabel linkDisc = (LinkLabel)this.Controls.Find("discAd" + i, true)[0];
                    PictureBox pictureBox = (PictureBox)this.Controls.Find("pbAd" + i, true)[0];
                    PictureBox flagPicture = (PictureBox)this.Controls.Find("flagAds" + i, true)[0];

                    linkDisc.Tag = ads[i].discordUrl;
                    linkWebsite.Tag = ads[i].websiteUrl;
                    pictureBox.ImageLocation = ads[i].bannerUrl;
                    flagPicture.Image = Resources._4RTools.Icons.flag_br;

                    linkDisc.LinkClicked += new LinkLabelLinkClickedEventHandler(this.onLinkClicked);
                    linkWebsite.LinkClicked += new LinkLabelLinkClickedEventHandler(this.onLinkClicked);

                    Console.WriteLine(ads[i].bannerUrl);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("=============>", ex.Message);
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
