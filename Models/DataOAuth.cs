using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TweetSentimentWeb.Models
{
    public class DataOAuth
    {
        /// <summary>
        /// ///////HDINSIGHT OAUTH
        /// </summary>
        private string _CLUSTERNAME;
        public string CLUSTERNAME
        {
            get { return _CLUSTERNAME; }
            set { _CLUSTERNAME = value; }
        }


        private string _HADOOPUSERNAME;
        public string HADOOPUSERNAME
        {
            get { return _HADOOPUSERNAME; }
            set { _HADOOPUSERNAME = value; }
        }


        private string _HADOOPUSERPASSWORD;
        public string HADOOPUSERPASSWORD
        {
            get { return _HADOOPUSERPASSWORD; }
            set { _HADOOPUSERPASSWORD = value; }
        }


        private string _HBASETABLENAME;
        public string HBASETABLENAME
        {
            get { return _HBASETABLENAME; }
            set { _HBASETABLENAME = value; }
        }


        /// <summary>
        /// ///////TWIITER OAUTH
        /// </summary>
        private string _TWITTERAPPACCESSTOKEN;
        public string TWITTERAPPACCESSTOKEN
        {
            get { return _TWITTERAPPACCESSTOKEN; }
            set { _TWITTERAPPACCESSTOKEN = value; }
        }


        private string _TWITTERAPPACCESSTOKENSECRET;
        public string TWITTERAPPACCESSTOKENSECRET
        {
            get { return _TWITTERAPPACCESSTOKENSECRET; }
            set { _TWITTERAPPACCESSTOKENSECRET = value; }
        }


        private string _TWITTERAPPAPIKEY;
        public string TWITTERAPPAPIKEY
        {
            get { return _TWITTERAPPAPIKEY; }
            set { _TWITTERAPPAPIKEY = value; }
        }



        private string _TWITTERAPPAPISECRET;
        public string TWITTERAPPAPISECRET
        {
            get { return _TWITTERAPPAPISECRET; }
            set { _TWITTERAPPAPISECRET = value; }
        }


        public DataOAuth()
        {
            _CLUSTERNAME = "https://hbase-skripsi.azurehdinsight.net";
            _HADOOPUSERNAME = "admin";

            var base64EncodedBytes = System.Convert.FromBase64String("T2FPYUdhQDQ0bXVoYW1tYWQ=");
            _HADOOPUSERPASSWORD = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);

            _HBASETABLENAME = "tweets_by_words";

            _TWITTERAPPACCESSTOKEN = "193666827-B6pFBA8nXXP9iEk4r9IpRYs3LeuiVApCaWqHxXsA";
            _TWITTERAPPACCESSTOKENSECRET = "6Lpg1UjnlvxdRIc7A0AP6lMGxVWAAmuc08xiUVWUhBpKe";
            _TWITTERAPPAPIKEY = "8xjN3bATZ368kVAPeODFjtOAq";
            _TWITTERAPPAPISECRET = "LrafGhcHb6lxh28XXQHFTOHL8a5XwkQ5oXEo5JJchSJh3AbpC5";
        }

    }
}