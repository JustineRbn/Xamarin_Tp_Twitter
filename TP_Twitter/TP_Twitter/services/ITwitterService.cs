using System;
using System.Collections.Generic;
using System.Text;
using TP_Twitter.models;

namespace TP_Twitter.services
{
    public interface ITwitterService
    {
        bool Authenticate(string key, string secret);

        List<Tweet> GetTweets(String tagword);
        
    }
}
