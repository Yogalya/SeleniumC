
using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppTestProjectFive.Pages;


namespace WpfAppTestProjectFive.Test
{



    [TestFixture]
    [AllureNUnit]
    [AllureSuite("login")]
    [AllureDisplayIgnored]

    class Test
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void Initialize()
        {
            driver = new ChromeDriver(@"E:\visualStudio\New folder\chromedriver_win32");
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("http://qa.mabi.eyepax.info:7075/");
        }




        [Test, Description("Verify the functionality of Login")]
        [AllureTag("Smoke Test")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("Yo")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]


        //[Test, Order(1)]
        public void TestQA()
        {

            Login Runapp = new Login(driver);

            Microsoft.Office.Interop.Excel.Application excelApp;
            Microsoft.Office.Interop.Excel.Workbook excelWorkbook;
            Microsoft.Office.Interop.Excel.Sheets excelSheets;
            Microsoft.Office.Interop.Excel.Worksheet excelWorksheet;


            string workbookPath = "E:\\Auto_libraries\\Testdata.xlsx";
            string currentSheet = "Sheet1";

            excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelWorkbook = excelApp.Workbooks.Add(workbookPath);
            excelSheets = excelWorkbook.Sheets;
            excelWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)excelSheets.get_Item(currentSheet);

            Microsoft.Office.Interop.Excel.Range myID = (Microsoft.Office.Interop.Excel.Range)excelWorksheet.get_Range("A2","A2");
            Runapp.userName = myID.Value.ToString();

            Microsoft.Office.Interop.Excel.Range myPassword = (Microsoft.Office.Interop.Excel.Range)excelWorksheet.get_Range("B2","B2");
            Runapp.password = myPassword.Value.ToString();

            Runapp.loggin();
            Runapp.skip();

            


            Microsoft.Office.Interop.Excel.Range myAssert = (Microsoft.Office.Interop.Excel.Range)excelWorksheet.get_Range("A5", "A5");
            
            if (myAssert.Equals(locators.map.ResourceManager.GetString("agreement"))){
               // Assert.IsTrue(locators.map.ResourceManager.GetString("agreements")).Equals(myAssert));
               Console.Write("Assertion pass");
                }

                else
                {
                    Console.Write("Assertion fail");
                }







        }
    }
}