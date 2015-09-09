using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
using System.IO;


namespace WeasylScraper
{
    public partial class Form1 : Form
    {
        public List<User> MasterList; 
        public Form1()
        {
            InitializeComponent();

            MasterList = new List<User>();

            wbMain.Navigate("http://weasyl.com");

        }

        private void btnFollowers_Click(object sender, EventArgs e)
        {
            wbMain.DocumentCompleted += ParsePage_Followers;
            wbMain.Navigate("http://weasyl.com/~sethiova");

        }

        private void ParsePage_Followers(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url != wbMain.Url)
                return;

            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(wbMain.DocumentText);

            String page = document.ToString();
            HtmlNode node = document.DocumentNode.SelectSingleNode("//div[@id='user-stats']/dl/dt[2]");

            string followerCount = node.InnerHtml.ToString();

        }

        private void btnFollowing_Click(object sender, EventArgs e)
        {
            //Gathers a list of usernames from the current user's following list.
            wbMain.DocumentCompleted += ParsePage_Following;
            wbMain.Navigate("http://weasyl.com/following/TayliasTwist");
        }

        private void ParsePage_Following(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url != wbMain.Url)
                return;
            List<String> lstFollowing = new List<string>();
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(wbMain.DocumentText);

            String page = document.ToString();
            HtmlNodeCollection nodes = document.DocumentNode.SelectNodes("//a[@class='avatar']/@href");

            foreach (HtmlNode node in nodes)
                lstFollowing.Add(node.Attributes[1].Value.ToString().Replace("/~", ""));

        }

        private void btnBuildMaster_Click(object sender, EventArgs e)
        {
            //Performs BFS on following lists to assemble a master user list.
            //Dump this list to text file for later.
        }

        private void ParsePage_BuildMaster(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url != wbMain.Url)
                return;


        }

    }
}
