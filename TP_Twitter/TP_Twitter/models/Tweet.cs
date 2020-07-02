using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace TP_Twitter.models
{
    public class Tweet
    {
        public string id { get; set; }
        public string creationDate { get; set; }
        public string text { get; set; }
        public string username { get; set; }
        public string userId { get; set; }
        public string userAlias { get; set; }

    }
}
