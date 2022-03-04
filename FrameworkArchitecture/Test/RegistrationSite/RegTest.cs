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
        public void BasicReg(string user, string pass, string confirmPass, string fName, string lName, string mail, string dateOfb, string nat, string userErr, string passErr, string confirmPassErr, string fNameErr, string lNameErr, string mailErr)
        {
            driver.Navigate().GoToUrl(url + "registration");

            RegistrationPage rp = new RegistrationPage(driver);
            Assert.AreEqual("Registration", rp.CheckPage());
            rp.Register(user, pass, confirmPass, fName, lName, mail, dateOfb, nat, userErr, passErr, confirmPassErr, fNameErr, lNameErr, mailErr);
            /*
            Assert.AreEqual(userErr, rp.CheckUsernameErrorText());
            Assert.AreEqual(passErr, rp.CheckPasswordErrorText());
            Assert.AreEqual(confirmPassErr, rp.CheckConfirmPasswordErrorText());
            Assert.AreEqual(fNameErr, rp.CheckFirstNameErrorText());
            Assert.AreEqual(lNameErr, rp.CheckLastNameErrorText());
            Assert.AreEqual(mailErr, rp.CheckEmailErrorText()); */
        }


        private static IEnumerable<TestCaseData> GetCredentialsDataCsv()
        {
            foreach (var values in Utils.Utilities.GetDataFromCsv("TestData\\registerCredentials.csv"))
            {
                yield return new TestCaseData(values);
            }
        }

        
        [Test, TestCaseSource("GetCredentialsDataCsv")]
        public void BasicRegistration(string user, string pass, string confirmPass, string fName, string lName, string mail, string dateOfb, string nat, string userErr, string passErr, string confirmPassErr, string fNameErr, string lNameErr, string mailErr)
        {
            driver.Navigate().GoToUrl(url + "registration");
            RegistrationPage rp = new RegistrationPage(driver);
            Assert.AreEqual("Registration", rp.CheckPage());

            rp.Register(user, pass, confirmPass, fName, lName, mail, dateOfb, nat, userErr, passErr, confirmPassErr, fNameErr, lNameErr, mailErr);
            /*
            Assert.AreEqual(usernameErr, errors["usernameError"]);
            Assert.AreEqual(passwordErr, errors["passwordError"]);
            Assert.AreEqual(confirmPasswordErr, errors["confirmPasswordError"]);
            Assert.False(bool.Parse(errors["hasDobErr"]));
            Assert.AreEqual(firstNameErr, errors["firstNameError"]);
            Assert.AreEqual(lastNameErr, errors["lastNameError"]);
            Assert.AreEqual(emailErr, errors["emailError"]);
            Assert.False(bool.Parse(errors["hasNationalityErr"]));
            Assert.AreEqual(acceptTermErr, errors["acceptTermsError"]); */
        }
    }
}
