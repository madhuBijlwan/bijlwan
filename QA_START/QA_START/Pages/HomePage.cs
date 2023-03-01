using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_START.Pages
{
    public class HomePage
    {
        public void gotoHomePage(IWebDriver driver)
        {
            IWebElement admin = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a"));
            admin.Click();

            IWebElement timeMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeMaterial.Click();
            Thread.Sleep(1000);

        }
    }
}
