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
//For the love of god make a function to read in an existing MasterList.txt and stop raping their poor server...

namespace WeasylScraper
{
    public partial class Form1 : Form
    {
        public List<User> MasterList;
        public HashSet<string> MasterHash;
        public HashSet<string> CrawledHash;
        public int CrawlIndex = -1;
        int function = 0; //1 - Followers | 2 - Following | 3 - Build Master List
        User currentUser;


        public Form1()
        {
            InitializeComponent();

            MasterList = new List<User>();
            MasterHash = new HashSet<string>();
            CrawledHash = new HashSet<string>();

            wbMain.Navigate("http://weasyl.com");

        }

        private void btnFollowers_Click(object sender, EventArgs e)
        {
            function = 1;
            wbMain.DocumentCompleted += ParsePage_Followers;
            currentUser = MasterList[0];
            CrawledHash.Clear();
            wbMain.Navigate("http://weasyl.com/~" + MasterList[0].username);
            

        }

        private void ParsePage_Followers(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url != wbMain.Url || function != 1)
                return;

            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(wbMain.DocumentText);

            HtmlNode node = document.DocumentNode.SelectSingleNode("//div[@id='user-stats']/dl/dt[2]");

            string followerCount = node.InnerHtml.ToString();
            currentUser.followers = Convert.ToInt32(followerCount);

            //Don't forget to crawl the rest of their stats and add the results to the user model.

            CrawledHash.Add(currentUser.username);

            //New NextUser function for this particular purpose that updates the global currentUser variable...
            

        }


        private void btnBuildMaster_Click(object sender, EventArgs e)
        {
            //Performs BFS on following lists to assemble a master user list.
            //Dump this list to text file for later.

            function = 3;
            wbMain.DocumentCompleted += ParsePage_BuildMaster;
            
            if (MasterList.Count < 1)
                MasterList.Add(new User("Peritian"));

            foreach (object o in CrawledHash)
                CrawlIndex++;                

            NextUser();


        }

        private void NextUser()
        {
            CrawlIndex = CrawlIndex + 1;
            if (MasterList.Count < CrawlIndex + 1)
            {
                WriteMasterList();
                return;
            }
            string nextUser = MasterList[CrawlIndex].username;

            if (CrawlIndex % 10 == 0) //This is to make sure I'm not DoS'ing the server on my test runs.
            {
                WriteMasterList();
                tbLog.AppendText("Wrote to master flat file.\n");
                //return;
            }

            //Randomized thread sleep timer between 0.1 - 1.0 seconds to at least attempt to appear to be legitimate traffic.
            tbLog.AppendText("Crawling " + nextUser + ".\n");
            wbMain.Navigate("http://weasyl.com/following/" + nextUser);
            
        }

        private void ParsePage_BuildMaster(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url != wbMain.Url || function != 3)
                return;

            string currentUser = e.Url.ToString().Substring(e.Url.ToString().LastIndexOf('/') + 1);
            if (CrawledHash.Contains(currentUser))
            {
                tbLog.AppendText("Skipping " + currentUser + ", already crawled.\n");
                NextUser();
                return;
            }

            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(wbMain.DocumentText);

            string page = document.ToString();
            if (page.Contains("There are no users to display."))
            {
                NextUser();
                return;
            }

            HtmlNodeCollection nodes = document.DocumentNode.SelectNodes("//a[@class='avatar']/@href");

            foreach (HtmlNode node in nodes)
            {
                string userName = node.Attributes[1].Value.ToString().Replace("/~", "").ToLower();
                if (!MasterHash.Contains(userName) && !userName.Contains("aylias"))
                {
                    MasterList.Add(new User(userName));
                    MasterHash.Add(userName);
                    tbLog.AppendText("Found user: " + userName + "\n");
                    tbLog.ScrollToCaret();
                }
                
            }

            if (!currentUser.Contains("userid"))
                if (!CrawledHash.Contains(currentUser))
                    CrawledHash.Add(currentUser);

            //Click Next Button (or go to that url rather)
            HtmlNode nodeNext = document.DocumentNode.SelectSingleNode("//a[text()[contains(.,'Next')]]");

            if (nodeNext != null)
            {
                string nextURL = nodeNext.OuterHtml.ToString();
                nextURL = nextURL.Substring(nextURL.IndexOf('/')).Split('\"')[0];
                wbMain.Navigate("http://weasyl.com" + nextURL);
            }

            else
                NextUser();
            
                
        }

        public void WriteMasterList()
        {
            if (File.Exists("MasterList.txt"))
                File.Delete("MasterList.txt");

            using (StreamWriter writer = File.AppendText("MasterList.txt"))
            {
                foreach (User user in MasterList) //Consider comma separating values of things like followers/following, etc to load in later, possibly for use in web app.
                    writer.WriteLine( (!CrawledHash.Contains(user.username) ? "*" : "") + user.username);
            }
            
        }

        private void LoadMasterFile()
        {
            int crawledCount = 0;
            int masterCount = 0;
            foreach (string line in File.ReadLines("MasterList.txt"))
            {
                if (!line.Contains("*"))
                {
                    CrawledHash.Add(line);
                    crawledCount++;
                }
                MasterList.Add(new User(line.Replace("*", "")));
                MasterHash.Add(line.Replace("*", ""));
                masterCount++;
            }

            tbLog.AppendText("Master file loaded.\nTotal Users: " + masterCount + "\nAlready Crawled: " + crawledCount + "\n");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMasterFile();
        }

    }
}
