using NUnit.Framework;
using OpenQA.Selenium;
using QA_START.Pages;
using QA_START.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_START.Tests
{
    [TestFixture]
   // [Parallelizable]
    public class Employees_Tests:CommonDriver
    {
        HomePage homePageObj = new HomePage();
        Employees employeeObj = new Employees();

        [Test]
        public void createEmployeeTest()
        {
            HomePage.goToEmployees(driver);
            employeeObj.create_employee(driver);
        }

    }
}
