using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FrameworkArchitecture.PageModels
{
    public class RegistrationPage : BasePage
    {
        const string registerTextSelector = "#root > div > div.content > div > div:nth-child(1) > div > div > h1 > small";
        const string username = "input-username";
        const string password = "input-password";
        const string confirmPassword = "input-password-confirm";
        const string titleMr = "#registration-form > div:nth-child(6) > div > div:nth-child(1) > input";
        const string titleMs = "#registration-form > div:nth-child(6) > div > div:nth-child(2) > input";
        const string firstName = "input-first-name";
        const string lastName = "input-last-name";
        const string email = "input-email";
        const string dateOfBirth = "input-dob";
        const string nationality = "input-nationality";
        const string terms = "terms";
        const string submit = "#registration-form > div:nth-child(13) > div.text-left.col-lg > button";

        const string usernameError = "#registration-form > div:nth-child(2) > div > div > div.text-left.invalid-feedback";
        const string passwordError = "#registration-form > div:nth-child(3) > div > div > div.text-left.invalid-feedback";
        const string confirmPasswordError = "#registration-form > div:nth-child(4) > div > div > div.text-left.invalid-feedback";
        const string firstNameError = "#registration-form > div:nth-child(7) > div > div > div.text-left.invalid-feedback";
        const string lastNameError = "#registration-form > div:nth-child(8) > div > div > div.text-left.invalid-feedback";
        const string emailError = "#registration-form > div:nth-child(9) > div > div > div.text-left.invalid-feedback";

        public RegistrationPage(IWebDriver driver) : base(driver)
        {
        }
        public string CheckPage()
        {
            return driver.FindElement(By.CssSelector(registerTextSelector)).Text;
        }

        public void Register(string user, string pass, string confirmPass, string fName, string lName, string mail, string dateOfb, string nat, string userErr, string passErr, string confirmPassErr, string fNameErr, string lNameErr, string mailErr)
        {
            var usernameInputElement = driver.FindElement(By.Id(username));
            usernameInputElement.Clear();
            usernameInputElement.SendKeys(user);
            var passwordInputElement = driver.FindElement(By.Id(password));
            passwordInputElement.Clear();
            passwordInputElement.SendKeys(pass);
            var confirmPasswordInputElement = driver.FindElement(By.Id(confirmPassword));
            confirmPasswordInputElement.Clear();
            confirmPasswordInputElement.SendKeys(confirmPass);
            var titleMrElement = driver.FindElement(By.CssSelector(titleMr));
            titleMrElement.Click();
            var titleMsElement = driver.FindElement(By.CssSelector(titleMs));
            titleMsElement.Click();
            var firstNameInputElement = driver.FindElement(By.Id(firstName));
            firstNameInputElement.SendKeys(fName);
            var lastNameInputElement = driver.FindElement(By.Id(lastName));
            lastNameInputElement.SendKeys(lName);
            var emailInputElement = driver.FindElement(By.Id(email));
            emailInputElement.SendKeys(mail);
            var dateOfBirthInputElement = driver.FindElement(By.Id(dateOfBirth));
            dateOfBirthInputElement.SendKeys(dateOfb);
            var nationalityInputElement = driver.FindElement(By.Id(nationality));
            nationalityInputElement.SendKeys(nat);
            var termsElemnt = driver.FindElement(By.Id(terms));
            termsElemnt.Click();
            var submitButton = driver.FindElement(By.CssSelector(submit));
            submitButton.Submit();

        }

        public string CheckUsernameErrorText()
        {
            return driver.FindElement(By.CssSelector(usernameError)).Text;
        }
        public string CheckPasswordErrorText()
        {
            return driver.FindElement(By.CssSelector(passwordError)).Text;
        }
        public string CheckConfirmPasswordErrorText()
        {
            return driver.FindElement(By.CssSelector(confirmPasswordError)).Text;
        }
        public string CheckFirstNameErrorText()
        {
            return driver.FindElement(By.CssSelector(firstNameError)).Text;
        }
        public string CheckLastNameErrorText()
        {
            return driver.FindElement(By.CssSelector(lastNameError)).Text;
        }
        public string CheckEmailErrorText()
        {
            return driver.FindElement(By.CssSelector(emailError)).Text;
        }


    }
}

