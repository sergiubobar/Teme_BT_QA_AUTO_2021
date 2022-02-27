using FrameworkArchitecture.PageModels;
using FrameworkArchitecture.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;


namespace FrameworkArchitecture.Test.AuthenticationSite
{
    class AuthTest : BaseTest
    {
        string url = FrameworkConstants.GetUrl();

        // Login Test without csv
        [Test]
        [TestCase("user1", "pass1")]
        public void BasicAuth(string user, string password)
        {
            driver.Navigate().GoToUrl(url + "login");
            LoginPage lp = new LoginPage(driver);
            Assert.AreEqual("Authentication", lp.CheckPage());
            lp.Login(user, password);
        }
    }

}
