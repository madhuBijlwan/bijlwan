using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
//open th eweb browser
IWebDriver driver = new EdgeDriver();
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

IWebElement username = driver.FindElement(By.Id("UserName"));
username.SendKeys("hari");
IWebElement pswd = driver.FindElement(By.Id("Password"));
pswd.SendKeys("123123");

IWebElement login = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
login.Click();

IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if(helloHari.Text == "Hello hari!")
{
    Console.WriteLine("Successfull");
}
driver.Quit();

