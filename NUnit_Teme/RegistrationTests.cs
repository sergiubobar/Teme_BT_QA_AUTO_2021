using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnit_Teme
{
    class RegistrationTests
    {
        IWebDriver driver;

        const string protocol = "http";
        const string hostname = "86.121.249.150";
        const string port = "4999";
        const string path = "/#/registration";

        string url = protocol + "://" + hostname + ":" + port + path;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }
        
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
       
        [Test]
        public void Test01(string user, string pass, string confirmPass, string fName, string lName, string mail, string dateOfb, string nat, string userErr, string passErr, string confirmPassErr, string fNameErr, string lNameErr, string mailErr)
        {
            driver.Navigate().GoToUrl(url);

            var pageAutentification = driver.FindElement(By.CssSelector("#root > div > div.content > div > div:nth-child(1) > div > div > h1 > small"));
            Assert.AreEqual("Registration", pageAutentification.Text);

            var username = driver.FindElement(By.Id("input-username"));
            var password = driver.FindElement(By.Id("input-password"));
            var confirmPassword = driver.FindElement(By.Id("input-password-confirm"));
            var titleMr = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(6) > div > div:nth-child(1) > input"));
            var titleMs = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(6) > div > div:nth-child(2) > input"));
            var firstName = driver.FindElement(By.Id("input-first-name"));
            var lastName = driver.FindElement(By.Id("input-last-name"));
            var email = driver.FindElement(By.Id("input-email"));
            var dateOfBirth = driver.FindElement(By.Id("input-dob"));
            var nationality = driver.FindElement(By.Id("input-nationality"));
            var terms = driver.FindElement(By.Id("terms"));
            var submit = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(13) > div.text-left.col-lg > button"));

            var usernameError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(2) > div > div > div.text-left.invalid-feedback"));
            var passwordError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(3) > div > div > div.text-left.invalid-feedback"));
            var confirmPasswordError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(4) > div > div > div.text-left.invalid-feedback"));
            var firstNameError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(7) > div > div > div.text-left.invalid-feedback"));
            var lastNameError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(8) > div > div > div.text-left.invalid-feedback"));
            var emailError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(9) > div > div > div.text-left.invalid-feedback"));

            username.Clear();
            username.SendKeys(user);
            password.Clear();
            password.SendKeys(pass);
            confirmPassword.Clear();
            confirmPassword.SendKeys(confirmPass);
            titleMr.Click();
            titleMs.Click();
            firstName.SendKeys(fName);
            lastName.SendKeys(lName);
            email.SendKeys(mail);
            dateOfBirth.SendKeys(dateOfb);
            nationality.SendKeys(nat);
            terms.Click();
            submit.Submit();

            Assert.AreEqual(userErr, usernameError.Text);
            Assert.AreEqual(passErr, passwordError.Text);
            Assert.AreEqual(confirmPassErr, confirmPasswordError.Text);
            Assert.AreEqual(fNameErr, firstNameError.Text);
            Assert.AreEqual(lNameErr, lastNameError.Text);
            Assert.AreEqual(mailErr, emailError.Text);
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}