using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using QA_START.page;
using QA_START.Pages;
using QA_START.Utilities;
using System;
using TechTalk.SpecFlow;

namespace QA_START.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions: CommonDriver
    {
        HomePage homePageobj = new HomePage();
        LoginPage loginPageobj = new LoginPage();
        TMPage tmPageObj = new TMPage();
        [Given(@"I logged into turnUp portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            throw new PendingStepException();
            //open Edge browser
            driver = new EdgeDriver();
            //initialise and define loginPage object
           
            loginPageobj.LoginActions(driver);
        }

        [When(@"I navigate to time and material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            throw new PendingStepException();
           
            homePageobj.goToTMPage(driver);
        }

        [When(@"I create a new time and material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            throw new PendingStepException();
            tmPageObj.createTM(driver);
        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            throw new PendingStepException();
            string newCode = tmPageObj.GetCode(driver);
            string newDescription = tmPageObj.GetDescription(driver);
            string newPrice = tmPageObj.GetPrice(driver);

            Assert.That(newCode == "Bijlwan", " the acutal code and expected code do Not match");
            Assert.That(newDescription == "Test Analyst", "the actual discription and expected discription do not match ");
            Assert.That(newPrice=="12","the actual price and expected price do not match");

        }
        
        [When(@"I update '([^']*)' on an existing time and material record")]
        public void WhenIUpdateOnAnExistingTimeAndMaterialRecord(string description)
        {
            throw new PendingStepException();
            tmPageObj.EditTM(driver, description);
        }
       
        [Then(@"the record should have been updated '([^']*)'")]
        public void ThenTheRecordShouldHaveBeenUpdated(string time)
        {
            throw new PendingStepException();
        }


    }
}
