// <copyright file="TwitterAPITest.cs" company="localhost">
// Copyright (c) 2014 All Rights Reserved
// </copyright>
// <author>Sergey Dzyuban</author>
// <date>6/18/2014 4:06:58 PM</date>
// <summary></summary>
namespace Web.API.Samples.Social.Twitter.Test
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Diagnostics;
    using System.Linq;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TwitterAPITest
    {
        [TestMethod]
        public async Task ConnectTwitterAPI()
        {
            Spring.Social.Twitter.Connect.TwitterServiceProvider provider = 
                new Spring.Social.Twitter.Connect.TwitterServiceProvider(
                    ConfigurationManager.AppSettings["ConsumerKey"], ConfigurationManager.AppSettings["ConsumerSecret"]);
            Spring.Social.Twitter.Api.ITwitter api = provider.GetApi(ConfigurationManager.AppSettings["AccessToken"], ConfigurationManager.AppSettings["AccessTokenSecret"]);
            bool auth = api.IsAuthorized;
            Assert.IsTrue(auth);

            try
            {
                var res = await api.UserOperations.GetUserProfileAsync("SergeyDz");
                Assert.IsNotNull(res);
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("TwitterAPITest", e.Message);
                throw;
            }
        }
    }
}
