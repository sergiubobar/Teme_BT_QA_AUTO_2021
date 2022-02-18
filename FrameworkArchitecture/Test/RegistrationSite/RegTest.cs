using FrameworkArchitecture.PageModels;
using FrameworkArchitecture.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FrameworkArchitecture.Test.RegistrationSite
{

    class RegTest : BaseTest
    {
        string url = FrameworkConstants.GetUrl();

        /*
        [TestCase("xsergiux", "sergiuflorin", "sergiuflorin", "Sergiu", "Florin", "sergiu@florin.ro", "10.10.2010", "Romania","", "", "", "", "", "")]
        [TestCase("xse", "sergiuflorin", "sergiuflorin", "Sergiu", "Florin", "sergiu@florin.ro", "10.10.2010", "Romania", "Minimum of 4 characters is required!", "", "", "", "", "")]
        [TestCase("xsergiux", "", "", "Sergiu", "Florin", "sergiu@florin.ro", "10.10.2010", "Romania","", "Password is required!", "", "", "", "")]
        [TestCase("", "sergiuflorin", "sergiuflorin", "Sergiu", "Florin", "sergiu@florin.ro", "10.10.2010", "Romania", "Username is required!", "", "", "", "", "")]
        [TestCase("xsergiux", "sergiuflorin", "sergiu", "Sergiu", "Florin", "sergiu@florin.ro", "10.10.2010", "Romania","", "", "Passwords do not match!", "", "", "")]
        [TestCase("xsergiuxxsergiuxxsergiuxxsergiuxxsergiux", "sergiuflorin", "sergiuflorin", "Sergiu", "Florin", "sergiu@florin.ro", "10.10.2010", "Romania","Maximum of 35 characters allowed!", "", "", "", "", "")]
        [TestCase("xsergiux", "sergiu", "sergiu", "Sergiu", "Florin", "sergiu@florin.ro", "10.10.2010", "Romania","", "Minimum of 8 characters is required!", "", "", "", "")]
        [TestCase("xsergiux", "sergiuflorin", "sergiuflorin", "Sergiu", "Florin", "", "10.10.2010", "Romania","", "", "", "", "", "Email is required!")]
        [TestCase("xsergiux", "sergiuflorin", "sergiuflorin", "Sergiu", "Florin", "sergiuflorin", "10.10.2010", "Romania","", "", "", "", "", "Invalid email address!")]
        [TestCase("xsergiux", "sergiuflorin", "sergiuflorin", "Sergiu", "F", "sergiu@florin.ro", "10.10.2010", "Romania","", "", "", "", "Minimum of 2 characters is required!", "")]
        [TestCase("xsergiux", "sergiuflorin", "sergiuflorin", "S", "Florin", "sergiu@florin.ro", "10.10.2010", "Romania","", "", "", "Minimum of 2 characters is required!", "", "")]
        [TestCase("xsergiux", "sergiuflorin", "sergiuflorin", "Sergiu", "FlorinFlorinFlorinFlorinFlorinFlorinFlorinFlorin", "sergiu@florin.ro", "10.10.2010", "Romania","", "", "", "", "Maximum of 35 characters allowed!", "")]
        [TestCase("xsergiux", "sergiuflorin", "sergiuflorin", "SergiuSergiuSergiuSergiuSergiuSergiuSergiuSergiuSergiu", "Florin", "sergiu@florin.ro", "10.10.2010", "Romania","", "", "", "Maximum of 35 characters allowed!", "", "")]
        */
        [Test]
        public void BasicReg()
        {
            driver.Navigate().GoToUrl(url + "registration");

            RegistrationPage rp = new RegistrationPage(driver);
            Assert.AreEqual("Registration", rp.CheckPage());
            rp.Register("xsergiux", "sergiuflorin", "sergiuflorin", "Sergiu", "Florin", "sergiu@florin.ro", "10.10.2010", "Romania", "", "", "", "", "", "");
        }
    }
}
