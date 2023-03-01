using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_START.Pages
{
    public class TmPage
    {
        //create a new record
        public void createTm(IWebDriver driver)
        {
            IWebElement createNew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNew.Click();
            Thread.Sleep(1000);

            IWebElement typeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCode.Click();
            Thread.Sleep(500);

            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeOption.Click();
            Thread.Sleep(1000);

            IWebElement Code = driver.FindElement(By.Id("Code"));
            Code.SendKeys("Bijlwan");

            IWebElement description = driver.FindElement(By.Id("Description"));
            description.SendKeys("Test Analyst");
            Thread.Sleep(1000);

            IWebElement price = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            price.SendKeys("99");

            IWebElement save = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            //save.Click();
            Thread.Sleep(2000);


        }
        //edit last record
        public void editTm(IWebDriver driver)
        {
            IWebElement lastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPage.Click();
            Thread.Sleep(500);

            IWebElement edit = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            edit.Click();
            Thread.Sleep(500);

            IWebElement editCode = driver.FindElement(By.Id("Code"));
            editCode.Clear();
            Thread.Sleep(500);
            editCode.SendKeys("Madhu");

            IWebElement editSave = driver.FindElement(By.Id("SaveButton"));
            editSave.Click();

        }
        //Delete last record
        public void deleteTm(IWebDriver driver)
        {
            //lastPage.Click();
            Thread.Sleep(1000);

            IWebElement delete = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            delete.Click();
            Thread.Sleep(500);

            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(500);


        }
    }
}
