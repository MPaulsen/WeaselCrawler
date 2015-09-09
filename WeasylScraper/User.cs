using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeasylScraper
{
    class User
    {
        String username { get; set; }
        int followers { get; set; }
        int following { get; set; }

        public User(string name)
        {
            this.username = name;
        }
    }
}
