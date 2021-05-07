using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.XPath;

namespace BuggyCarsRating.Pages
{
    class PopularModelPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = "[id='comment']")]
        private IWebElement commentField;

        [FindsBy(How = How.XPath, Using = ".//button[text()='Vote!']")]
        private IWebElement voteButton;

        [FindsBy(How = How.XPath, Using = ".//p[text()='Thank you for your vote!']")]
        private IWebElement voteSuccessfulInfo;

        [FindsBy(How = How.XPath, Using = ".//table[@class='table']/tbody/tr[1]/td[3]")]
        private IWebElement commentInfo;


        public PopularModelPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void vote()
        {
            voteButton.Click();
        }


        public void comments(string comments)
        {
            commentField.SendKeys(comments);
        }

        public Boolean isVoteSuccessful()
        {
            return voteSuccessfulInfo.Displayed;
        }

        public string commentsInfo()
        {
            return commentInfo.Text;
        }




    }
}
