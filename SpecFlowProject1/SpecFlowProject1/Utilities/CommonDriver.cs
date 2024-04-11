using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AventStack.ExtentReports;
//using MARSNunitAutomation.Utilities;

namespace SpecFlowProject1.Utilities
{
    public class CommonDriver : ExtentReportHelper
    {

        public static IWebDriver driver;

        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Thread.Sleep(2000);

        }
       
        public void QuitDriver()
        {
            
            
                var status = TestContext.CurrentContext.Result.Outcome.Status;
                var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
                var errorMessage = TestContext.CurrentContext.Result.Message;

                if (status == NUnit.Framework.Interfaces.TestStatus.Failed)
                {
                    test.Log(Status.Fail, status + errorMessage);

                }
                else
                {
                    test.Log(Status.Pass, "Test Pass");
                }


                string img = ExtentReportHelper.SaveScreenShot(driver, "Screenshot");
                test.Log(Status.Info, "Snapshot below: " + test.AddScreenCaptureFromPath(img));

                driver.Close();
            
            driver.Quit();

        }

        public static void OneTimeSetup()
        {
            ExtentReportHelper.CreateExtentReport();

        }



    }
}
