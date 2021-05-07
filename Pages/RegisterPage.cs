using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuggyCarsRating.Pages
{
    class RegisterPage 
    {
        private IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = "[id='username']")]
        private IWebElement userNameField;

        [FindsBy(How = How.CssSelector, Using = "[id='firstName']")]
        private IWebElement firstNameField;

        [FindsBy(How = How.CssSelector, Using = "[id='lastName']")]
        private IWebElement lastNameField;

        [FindsBy(How = How.CssSelector, Using = "[id='password']")]
        private IWebElement passwordField;

        [FindsBy(How = How.CssSelector, Using = "[id='confirmPassword']")]
        private IWebElement confirmPasswordField;

        [FindsBy(How = How.CssSelector, Using = "[class='btn btn-default']")]
        private IWebElement registerBtm;

        [FindsBy(How = How.CssSelector, Using = "[class='btn']")]
        private IWebElement cancelBtm;

        [FindsBy(How = How.CssSelector, Using = "[class='result alert alert-success']")]
        private IWebElement registerSuccessInfo;

        [FindsBy(How = How.CssSelector, Using = "[class='result alert alert-danger']")]
        private IWebElement registerErrorInfo;

        public RegisterPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void filluserName(String userNames)
        {
            userNameField.SendKeys(userNames);
        }

        public void fillfirstName(String firstNames)
        {
            firstNameField.SendKeys(firstNames);
        }

        public void filllastName(String lastNames)
        {
            lastNameField.SendKeys(lastNames);
        }

        public void fillPassword(String password)
        {
            passwordField.SendKeys(password);
        }

        public void fillConfirmPassword(String confirmPassword)
        {
            confirmPasswordField.SendKeys(confirmPassword);
        }

        public void clickRegisterButton()
        {
            registerBtm.Click();
        }


        public Boolean successInfoDisplayed()
        {
            return registerSuccessInfo.Displayed;
        }

        public Boolean errorInfoDisplayed()
        {
            return registerErrorInfo.Displayed;
        }


    }
}
