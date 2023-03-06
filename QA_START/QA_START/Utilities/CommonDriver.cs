using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using QA_START.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;

namespace QA_START.Utilities
{
        public class CommonDriver
        {
        public IWebDriver driver = new EdgeDriver();

            [SetUp]
            public void LoginSteps()
            {
               //  driver = new EdgeDriver(); ;

                // Login page object initialization and definition
                LoginPage loginPageObj = new LoginPage();
                loginPageObj.LoginActions(driver);
            }


            [TearDown]
            public void ClosingSteps()
            {
                driver.Quit();
            }
        }
    
}

