using OpenQA.Selenium;
using QA_START.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace QA_START.Pages
{
    public class Employees:CommonDriver
    {
        public void create_employee(IWebDriver driver)
        {
            //click on create button
            driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a")).Click();
            Thread.Sleep(1000);
            //fill the name of employee
            IWebElement nameTextBox = driver.FindElement(By.XPath("//*[@id=\"Name\"]"));
            nameTextBox.SendKeys("madhu");
            Thread.Sleep(500);
            //fill the user name
            IWebElement usernameTextBox = driver.FindElement(By.XPath("//*[@id=\"Username\"]"));
            usernameTextBox.SendKeys("bijlwan");

            //fill the contact number
            IWebElement contactTextBox = driver.FindElement(By.XPath("//*[@id=\"ContactDisplay\"]"));
            contactTextBox.SendKeys("123456789");
            Thread.Sleep(500);
            //create password
            IWebElement passwordTextBox = driver.FindElement(By.XPath("//*[@id=\"Password\"]"));
            passwordTextBox.SendKeys("Mb123456*");

            IWebElement retypePasswordTextBox = driver.FindElement(By.XPath("//*[@id=\"RetypePassword\"]"));
            retypePasswordTextBox.SendKeys("Mb123456*");

            Thread.Sleep(500);
            //select the type vehicle
            IWebElement vehicleDropDown = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            vehicleDropDown.SendKeys("abc");
            Thread.Sleep(100);

            //click and select the group
            IWebElement groupDropDown = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
            groupDropDown.SendKeys("TestNZ");

            //save the info
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(1000);
            //click on return page
            IWebElement backToListButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backToListButton.Click();
            Thread.Sleep(1000);





        }
    }
}
