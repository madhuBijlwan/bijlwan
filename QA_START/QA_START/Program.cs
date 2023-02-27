using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System.Net.Http.Headers;
//login for turn up portal
IWebDriver driver = new EdgeDriver();
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
driver.Manage().Window.Maximize();
Thread.Sleep(2000);
IWebElement username = driver.FindElement(By.Id("UserName"));
username.SendKeys("hari");
IWebElement pswd = driver.FindElement(By.Id("Password"));
pswd.SendKeys("123123");

IWebElement login = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
login.Click();

IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
//Check if user has successfully logged in
if(helloHari.Text == "Hello hari!")
{
    Console.WriteLine("Successfull");
}
Thread.Sleep(1000);

//Create a new time record

IWebElement admin = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a"));
admin.Click();

IWebElement timeMaterial=driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
timeMaterial.Click();
Thread.Sleep(1000);
/*
//Create a new record

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
save.Click();
Thread.Sleep(2000);

//Check if new record has been created

IWebElement lastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
lastPage.Click();

Thread.Sleep(3000);
IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last[2]/td[1]]"));

if(newCode.Text == "Bijlwan")
{
 Console.WriteLine("New Record is created successfull");
}
else
{
    Console.WriteLine("Failed to create a new record");
} */
/*
//Edit time record
IWebElement lastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
lastPage.Click();
Thread.Sleep(500);

IWebElement edit = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[5]/td[5]/a[1]"));
edit.Click();
Thread.Sleep(500);

IWebElement editCode = driver.FindElement(By.Id("Code"));
editCode.Clear();
Thread.Sleep(500);
editCode.SendKeys("Madhu");

IWebElement editSave = driver.FindElement(By.Id("SaveButton"));
editSave.Click();

//Check if record is modified
IWebElement testEdit = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[3]/table/tbody/tr[5]/td[1]"));

if (testEdit.Text == "Madhu")
{
    Console.WriteLine("Successfully eddited");
}
else {
    Console.WriteLine("Failed to edit record !");
}
*/

//Delete a record
IWebElement lastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
lastPage.Click();
Thread.Sleep(1000);

IWebElement delete = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[6]/td[5]/a[2]"));
delete.Click();
Thread.Sleep(500);

driver.SwitchTo().Alert().Accept();
Thread.Sleep(500);

//Check if record is deleted

IWebElement lastRecord = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[3]/table/tbody/tr[6]/td[1]"));
if (lastRecord.Text != "hj")
{
    Console.WriteLine("Record is deleted ");
}
else 
{
    Console.WriteLine("Record is not Deleted!");
}
//driver.Quit();

