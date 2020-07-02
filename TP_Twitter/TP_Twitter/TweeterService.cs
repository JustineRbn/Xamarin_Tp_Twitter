using System;
using System.Collections.Generic;
using System.Text;
using TP_Twitter.models;
using TP_Twitter.services;

namespace TP_Twitter
{
    class TwitterService : ITwitterService
    {
        public bool authenticate(string username, string pwd)
        {
            if(string.IsNullOrEmpty(username) && string.IsNullOrEmpty(pwd)){
                return true;
            }
            return false;
        }

        public List<Tweet> getTweets()
        {
            List<Tweet> tweets = new List<Tweet>();

            tweets.Add(new Tweet() {creationDate = "Wed Apr 05 15:28:42 +0000 2019", id= "423436475654467993", userId="5983158", username="TwitterAPI", userAlias="twitterapi"});
            tweets.Add(new Tweet() {creationDate = "Thu Apr 06 15:28:43 +0000 2017", id = "423436475654468953", userId="5983158", username="TwitterAPI", userAlias="twitterapi"});
            tweets.Add(new Tweet() {creationDate = "Thu Apr 06 15:28:43 +0000 2017", id = "423436475654468452", userId="5983158", username="TwitterAPI", userAlias="twitterapi"});
            tweets.Add(new Tweet() {creationDate = "Thu Apr 06 15:28:43 +0000 2017", id = "423436475654469936", userId="5983158", username="TwitterAPI", userAlias="twitterapi"});
            tweets.Add(new Tweet() {creationDate = "Thu Apr 06 15:28:43 +0000 2017", id = "423436475654464574", userId="5983158", username="TwitterAPI", userAlias="twitterapi"});
            return tweets;
            }

    }

}
