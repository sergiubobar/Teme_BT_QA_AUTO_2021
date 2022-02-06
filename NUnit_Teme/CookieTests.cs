using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Teme
{
    class CookiesTests
    {
        IWebDriver driver;

        const string protocol = "http";
        const string hostname = "86.121.249.150";
        const string port = "4999";
        const string path = "/#/cookie";

        string url = protocol + "://" + hostname + ":" + port + path;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test01()
        {
            driver.Navigate().GoToUrl(url);
            var cookies = driver.Manage().Cookies;

            var setCookie = driver.FindElement(By.Id("set-cookie"));
            var removeCookie = driver.FindElement(By.Id("delete-cookie"));

            setCookie.Click();

            var cookieValue = driver.FindElement(By.Id("cookie-value"));
            Console.WriteLine(cookieValue.Text);

            Console.WriteLine("The site contains {0} cookies", cookies.AllCookies.Count);

            foreach (Cookie ck in cookies.AllCookies)
            {
                Console.WriteLine("Cookie name {0} and value {1}", ck.Name, ck.Value);
                Assert.AreEqual(cookieValue.Text, ck.Value);

                removeCookie.Click();

                Console.WriteLine("The site contains {0} cookies", cookies.AllCookies.Count);
            }
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
