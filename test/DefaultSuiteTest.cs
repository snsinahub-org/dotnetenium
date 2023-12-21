// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
// using NUnit.Framework;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace ws.SeleniumTests
{
  [TestClass]
  public class DefaultSuiteTest {

    // public TestContext? TestContext { get; set; }
    private static IWebDriver driver;
    public static IDictionary<string, object> vars {get; private set;}
    public TestContext? TestContext { get; set; }
    private static  IJavaScriptExecutor js;

    public static ExtentReports? extent;
    public static ExtentTest test;

    
    [ClassInitialize]
    public static void Setup(TestContext context) {
      driver =  cDriver();
      js = (IJavaScriptExecutor)driver;
      vars = new Dictionary<string, object>();
    }

    

   [TestMethod]
    public void untitled() {
      test = extent.CreateTest(TestContext.TestName);
      test.Log(Status.Info, "Navigate to DotNet website");
      var driver = GetDriver();
      // Test name: Untitled
      // Step # | name | target | value | comment
      // 1 | open | / |  | 
      driver.Navigate().GoToUrl("https://localhost:7262/");
      // 2 | setWindowSize | 1872x986 |  | 
      driver.Manage().Window.Size = new System.Drawing.Size(1872, 986);
      // 3 | click | css=html |  | 
      driver.FindElement(By.CssSelector("html")).Click();
      // 4 | click | css=.pb-3 |  | 
      driver.FindElement(By.CssSelector(".pb-3")).Click();
      // 5 | click | linkText=Privacy |  | 
      driver.FindElement(By.LinkText("Privacy")).Click();
      // 6 | click | linkText=Home |  | 
      driver.FindElement(By.LinkText("Home")).Click();
      // 7 | click | css=.display-4 |  | 
      driver.FindElement(By.CssSelector(".display-4")).Click();
      // 8 | doubleClick | css=.display-4 |  | 
      {
        var element = driver.FindElement(By.CssSelector(".display-4"));
        Actions builder = new Actions(driver);
        builder.DoubleClick(element).Perform();
      }
      // 9 | click | css=html |  | 
      driver.FindElement(By.CssSelector("html")).Click();
      // 10 | click | css=.display-4 |  | 
      driver.FindElement(By.CssSelector(".display-4")).Click();
      // 11 | assertText | css=.display-4 | Welcome | 
      Assert.AreEqual("Welcome", driver.FindElement(By.CssSelector(".display-4")).Text);
      // 12 | click | css=.display-4 |  | 
      driver.FindElement(By.CssSelector(".display-4")).Click();
      // 13 | assertText | css=.display-4 | Welcome | 
      Assert.AreEqual("Welcome", driver.FindElement(By.CssSelector(".display-4")).Text);
      // 14 | click | css=.pb-3 |  | 
      driver.FindElement(By.CssSelector(".pb-3")).Click();
      // 15 | click | css=.container:nth-child(1) |  | 
      driver.FindElement(By.CssSelector(".container:nth-child(1)")).Click();
    }

    private ChromeDriver GetDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--headless");
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-dev-shm-usage");
            options.AddArgument("--user-data-dir .");
            options.AddArgument("--ignore-certificate-errors");
             options.AddArgument("headless");

            options.AcceptInsecureCertificates = true;
            

           
            return new ChromeDriver("/tmp", options);
        }

    private static ChromeDriver cDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--headless");
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-dev-shm-usage");
            options.AddArgument("--user-data-dir .");
            options.AddArgument("--ignore-certificate-errors");
             options.AddArgument("headless");

            options.AcceptInsecureCertificates = true;
            

           
            return new ChromeDriver("/tmp", options);
        }

    [TestCleanup]
    public void endReporting()
    {
        Console.WriteLine("TestCleanup");
        // driver.Quit();

    }
  }
}