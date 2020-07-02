using System;
using System.Collections.Generic;
using System.Text;
using TP_Twitter.models;


namespace TP_Twitter.services
{
    public class TwitterService : ITwitterService
    {
        public bool Authenticate(string username, string pwd)
        {
            if (username != null && username.Equals("justine") && pwd != null && pwd.Equals("pouet"))
            {
                return true;
            }

            return false;    
        }

        public List<Tweet> GetTweets(string tagword)
        {
            List<Tweet> tweets = new List<Tweet>();

            tweets.Add(new Tweet() {
                creationDate = "Wed Apr 05 15:28:42 +0000 2019", 
                id= "423436475654467993", 
                userId="5983158", 
                username="TwitterAPI", 
                userAlias="twitterapi"
            });
            tweets.Add(new Tweet() {
                creationDate = "Thu Apr 06 15:28:43 +0000 2017", 
                id = "423436475654468953", 
                userId="5983158", 
                username="TwitterAPI", 
                userAlias="twitterapi"
            });
            tweets.Add(new Tweet() {
                creationDate = "Thu Apr 06 15:28:43 +0000 2017", 
                id = "423436475654468452", 
                userId="5983158", 
                username="TwitterAPI", 
                userAlias="twitterapi"
            });
            tweets.Add(new Tweet() {
                creationDate = "Thu Apr 06 15:28:43 +0000 2017", 
                id = "423436475654469936", 
                userId="5983158", 
                username="TwitterAPI", 
                userAlias="twitterapi"
            });
            tweets.Add(new Tweet() {
                creationDate = "Thu Apr 06 15:28:43 +0000 2017", 
                id = "423436475654464574", 
                userId="5983158", 
                username="TwitterAPI", 
                userAlias="twitterapi"
            });
            return tweets;
            }

    }

}
