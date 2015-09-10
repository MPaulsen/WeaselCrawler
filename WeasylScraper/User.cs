using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeasylScraper
{
    public class User
    {
        public string username { get; set; }
        public int followers { get; set; }
        public int following { get; set; }
        public int pageviews { get; set; }
        public int favoritesGiven { get; set; }
        public int favoritesReceived { get; set; }
        public int submissions { get; set; }
        public int journals { get; set; }
        public DateTime joined { get; set; }

        public User(string name)
        {
            this.username = name;
        }

    }
}
