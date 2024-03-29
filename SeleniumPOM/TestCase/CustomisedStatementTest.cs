﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumPOM.Config;
using SeleniumPOM.Interfaces;
using SeleniumPOM.Pages.Actions;
using SeleniumPOM.BasePage;
using SeleniumPOM.TestContextClass;

namespace SeleniumPOM.TestCase
{
    [TestClass]
    public class CustomisedStatementTest : TestClassContext
    {
        #region Fields

        ILoginPage loginPage;
        IConfig config;
        IHomePage homePage;
        ICustomisedStatementPage customisedStatementPage;
        public const string PAGE = "CustomisedStatement$";

        #endregion

        [TestInitialize]
        public void Setup()
        {
            Page.Initialization();
            loginPage = new LoginPage();
            config = new AppConfigReader();
            homePage = loginPage.Login(config.GetUserName(), config.GetPassword());
            customisedStatementPage = homePage.ClickOnCustomisedStatementPage();
        }

        [TestMethod]
        [DataSource(EXCEL_PROPERTIES, EXCEL_SHEET_LOCATION, PAGE, DataAccessMethod.Sequential)]
        public void VerifyAccountNumberMessage()
        {
            extent.CreateTest(TestContext.TestName);
            string ActualMessage = customisedStatementPage.EnterInvalidCharactersAndGetMessage(TestContext.DataRow["Data"].ToString());
            Assert.AreEqual(ActualMessage, TestContext.DataRow["ExpectedMessage"]);
        }

        [TestCleanup]
        public void TearDown()
        {
            SetUpResults(TestContext.CurrentTestOutcome.ToString());
            Page.QuitSession();
        }
    }
}
