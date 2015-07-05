using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TweetSentimentWeb.Models;

using System.Threading.Tasks; 

namespace TweetSentimentWeb.Controllers
{
    public class TweetsController : ApiController
    {

        HBaseReader hbase = new HBaseReader();

        public async Task<IEnumerable<Tweet>> GetTweetsByQuery(string query)
        {
            return await hbase.QueryTweetsByKeywordAsync(query);
        }
    }
}
