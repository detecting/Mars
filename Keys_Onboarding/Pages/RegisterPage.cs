﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using Keys_Onboarding.Pages;
using static Keys_Onboarding.Global.CommonMethods;

namespace Keys_Onboarding.Global
{
    public class Register : BasePage
    {
        internal Register()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        #region define elements

        

        //Click on SignUp Link
        [FindsBy(How = How.XPath, Using = "//*[@id='sign_in']/div[3]/a")]
        private IWebElement RegisterLink { get; set; }

        //Enter FirstName
        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        private IWebElement FirstName { get; set; }

        //Enter LastName
        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        private IWebElement LastName { get; set; }

        //click on Email
        [FindsBy(How = How.XPath, Using = "//*[@id='UserName']")]
        private IWebElement Email { get; set; }

        //Click on Password
        [FindsBy(How = How.XPath, Using = "//*[@id='Password']")]
        private IWebElement Password { get; set; }

        //Choose Account Type- Here I have chosen property owner
        [FindsBy(How = How.XPath, Using = "//*[@id='roleDropdown']/option[3]")]
        private IWebElement Acctype { get; set; }

        //Accept terms and conditions
        [FindsBy(How = How.XPath, Using = "//*[@id='checkAgreement']")]
        private IWebElement terms { get; set; }

        //Click on SignUp Button
        [FindsBy(How = How.XPath, Using = "//*[@id='SignupButton']")]
        private IWebElement Registerbutton { get; set; }
        #endregion

        /// <summary>
        /// go to register page
        /// </summary>
        internal void Navigateregister()
        {
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Register");
            // Navigating to LoginPage page using value from Excel
            Driver.driver.Navigate().GoToUrl(ExcelLib.ReadData(2, "Url"));

            //Click on the Register link
            RegisterLink.Click();

            //Read FirstName
            FirstName.SendKeys(ExcelLib.ReadData(2, "FirstName"));

            //Read LastName
            LastName.SendKeys(ExcelLib.ReadData(2, "LastName"));

            //Read Email
            Email.SendKeys(ExcelLib.ReadData(2, "Email"));

            //Read Password
            Password.SendKeys(ExcelLib.ReadData(2, "Password"));

            //Click on Terms and Conditions
            terms.Click();
            //Click on Signup
            Registerbutton.Click();
        }
    }
}