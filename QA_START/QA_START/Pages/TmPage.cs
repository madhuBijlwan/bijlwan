﻿using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_START.Pages
{
    public class TMPage
    {
        public void createTM(IWebDriver driver)
        {
            // Click on Create New button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();
            Thread.Sleep(1000);

            // Select Time option from TypeCode dropdown list
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();
            Thread.Sleep(1000);

            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeOption.Click();

            // Input code into Code textbox
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("Bijlwan");

            // Input description into Description textbox
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("Test Analyst");

            // Input Price per Unit into price per unit textbox
            IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTextbox.SendKeys("12");

            // Click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);

            // Check if new Time record has been created
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(5000);
                      
        }

        public string GetCode(IWebDriver driver)
        {
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return actualCode.Text;
        }

        public string GetDescription(IWebDriver driver)
        {
            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return actualDescription.Text;
        }

        public string GetPrice(IWebDriver driver)
        {
            IWebElement actualPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));
            return actualPrice.Text;
        }
        
        public void EditTM(IWebDriver driver, string description)
        {

            // Click on Edit Button to make changes to type Code
            Thread.Sleep(1000);
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement recordToBeEdited = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            recordToBeEdited.Click();
          
            //Identify Code Text Box and clear last record
            Thread.Sleep(1000);
            IWebElement editCodeTextBox = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            editCodeTextBox.Clear();

            Thread.Sleep(1000);
            editCodeTextBox.SendKeys("123456");

            // edit discription textbox
            IWebElement editDescriptionTextBox = driver.FindElement(By.Id("Description"));
            editDescriptionTextBox.Clear();
            Thread.Sleep(1000);

            editDescriptionTextBox.SendKeys(description);
            //Identify and Click on Save Button
            IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
            SaveButton.Click();
            //Identify and Click on Last Page Button Page
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]")).Click();
            Thread.Sleep(1000);
            IWebElement lastEditedRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            
            Assert.That(lastEditedRecord.Text == "123456", "Record hasn't been edited.");

        
            
            Thread.Sleep(1000);
        }
        public string GetEditedDiscription(IWebDriver driver)
        {
            IWebElement createdDiscription = driver.FindElement(By.XPath("\"//*[@id=\\\"tmsGrid\\\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return createdDiscription.Text;
        }
        public void DeleteTM(IWebDriver driver)
        {
            //Identify and Click on Last Page Button Page
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();

            IWebElement recordToBeDeleted = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
           /* 
            if (recordToBeDeleted.Text == "123456")
            {
                //Find and click on delete button for last record
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/div[2]/table/tbody/tr[last()]/td[5]/a[2]"));
                deleteButton.Click();
            }
            else
            {
                Assert.Fail("Record to be deleted not found.");
            }
            */
            IWebElement lastRecordDelete = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            recordToBeDeleted.Click();
            Thread.Sleep(2000);

            //Acceptance on Pop up to delete record
            driver.SwitchTo().Alert().Accept();

            Assert.That(lastRecordDelete.Text != "123456", "Record hasn't been deleted");
        }
    }   } 


