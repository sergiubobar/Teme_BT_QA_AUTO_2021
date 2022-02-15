using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FrameworkArchitecture.PageModels
{
    public class RegistrationPage : BasePage
    {
        const string registerTextSelector = "#register > formfield > legend"; // css
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
    }
}
