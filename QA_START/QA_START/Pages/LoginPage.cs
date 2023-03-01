using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_START.page
{
    public class LoginPage
    {
        public void login(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");
            IWebElement pswd = driver.FindElement(By.Id("Password"));
            pswd.SendKeys("123123");

            IWebElement login = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            login.Click();

            //IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
            


        }
    }
}
