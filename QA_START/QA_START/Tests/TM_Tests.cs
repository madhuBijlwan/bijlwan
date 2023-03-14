using NUnit.Framework;
using QA_START.Pages;
using QA_START.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace QA_START.Tests
{

        [TestFixture]
       [Parallelizable]
        public class TM_Tests : CommonDriver
        {
           // Page objects initialization
            HomePage homePageObj = new HomePage();
            TMPage tmPageObj = new TMPage();


            [Test, Order(1)]
            public void CreateTMTest()
            {
            // TM page object initialization and definition
        
            homePageObj.goToTMPage(driver);
                tmPageObj.createTM(driver);
            }

            [Test, Order(2)]
            public void EditTMTest()
            {
                homePageObj.goToTMPage(driver);
              //  tmPageObj.EditTM(driver);
            }

            [Test, Order(3)]
            public void DeleteTMTest()
            {

               homePageObj.goToTMPage(driver);
               tmPageObj.DeleteTM(driver);
            }
        }
    
}


