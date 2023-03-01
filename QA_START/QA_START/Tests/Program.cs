using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using QA_START.page;
using QA_START.Pages;
using System.Net.Http.Headers;
//login for turn up portal
IWebDriver driver = new EdgeDriver();
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

//Create object for Login Page
LoginPage loginPageObj = new LoginPage();
loginPageObj.login(driver);

// Create object for Home Page
HomePage homePageObj = new HomePage();
homePageObj.gotoHomePage(driver);

// Create object for Time and material page
TmPage tmPageObj = new TmPage();
tmPageObj.createTm(driver);
tmPageObj.editTm(driver);
tmPageObj.deleteTm(driver);
//lastPage.Click();
//IWebElement lastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
//driver.Quit();

