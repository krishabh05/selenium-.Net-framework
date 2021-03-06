﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumPOM.Pages.Locators
{
    class DeleteAccountLocator
    {
        #region PageFactory

        [FindsBy(How = How.Name, Using = "accountno")]
        private IWebElement AccounNo { get; set; }

        [FindsBy(How = How.Name, Using = "AccSubmit")]
        private IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.Name, Using = "res")]
        private IWebElement ResetButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(@id,'message')]")]
        private IWebElement AccountNoMessage { get; set; }

        #endregion

        #region GetterMethods

        /// <summary>
        /// Return the locator of AccountNumber on DeleteAccount Page.
        /// </summary>
        /// <returns>Locator of Account Number</returns>
        public IWebElement GetAccountNumberLocator()
        {
            return AccounNo;
        }

        /// <summary>
        /// Return the Locator of Submit Button on Delete Account Page.
        /// </summary>
        /// <returns>Locator of Submit Button</returns>
        public IWebElement GetSubmitButtonLocator()
        {
            return SubmitButton;
        }

        /// <summary>
        /// Return the locator of Reset Button on Delete Account Page.
        /// </summary>
        /// <returns>Locator of Reset Button</returns>
        public IWebElement GetResetButtonLocator()
        {
            return ResetButton;
        }

        /// <summary>
        /// Return the locator of account number message on Delete Account Page.
        /// </summary>
        /// <returns>Locator of Account Number Message</returns>
        public IWebElement GetAccountNumberMessageLocator()
        {
            return AccountNoMessage;
        }

        #endregion

    }
}
