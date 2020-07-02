using System;
using System.Collections.Generic;
using System.Text;
using TP_Twitter.models;

namespace TP_Twitter.services
{
    public interface ITwitterService
    {
        bool authenticate(string key, string secret);

        List<Tweet> getTweets();
        
    }
}
