using FrameworkArchitecture.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FrameworkArchitecture.Test
{
    class BaseTest
    {
        public IWebDriver driver;

        // Before each test
        [SetUp]
        public void Setup()
        {
            // Instatiate the browser using the Browser Factory class created in Utilities
            driver = Browser.GetDriver();
        }

        // After each test
        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }

    }
}
