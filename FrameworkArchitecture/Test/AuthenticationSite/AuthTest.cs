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
        [TestCase("user2", "pass2")]
        [TestCase("user3", "pass3")]
        [TestCase("user4", "pass4")]
        public void BasicAuth(string user, string password)
        {
            driver.Navigate().GoToUrl(url + "login");
            LoginPage lp = new LoginPage(driver);
            Assert.AreEqual("Authentication", lp.CheckPage());
            lp.Login(user, password);
        }


        [Test, TestCaseSource("GetCredentialsDataCsv")]
        public void BasicAuthCSV(string user, string password)
        {
            driver.Navigate().GoToUrl(url + "login");
            LoginPage lp = new LoginPage(driver);
            Assert.AreEqual("Authentication", lp.CheckPage());
            lp.Login(user, password);
        }


        private static IEnumerable<TestCaseData> GetCredentialsDataCsv()
        {
            foreach (var values in Utils.Utilities.GetDataFromCsv("TestData\\loginCredentials.csv"))
            {
                yield return new TestCaseData(values);
            }
        }


    }

}
