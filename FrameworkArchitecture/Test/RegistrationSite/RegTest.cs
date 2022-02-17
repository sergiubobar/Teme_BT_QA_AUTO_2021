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
