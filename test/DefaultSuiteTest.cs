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
using NUnit.Framework;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace ws.SeleniumTests
{
  [TestClass]
  public class DefaultSuiteTest {
    private IWebDriver driver;
    public IDictionary<string, object> vars {get; private set;}
    private IJavaScriptExecutor js;
    [SetUp]
    public void SetUp() {
      driver = GetDriver();
      js = (IJavaScriptExecutor)driver;
      vars = new Dictionary<string, object>();
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
    [TearDown]
    protected void TearDown() {
      driver.Quit();
    }
    [Test]
    public void untitled() {
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
      // Assert.That(driver.FindElement(By.CssSelector(".display-4")).Text, Is.EqualTo("Welcome"));
      // 12 | click | css=.display-4 |  | 
      driver.FindElement(By.CssSelector(".display-4")).Click();
      // 13 | assertText | css=.display-4 | Welcome | 
      // Assert.That(driver.FindElement(By.CssSelector(".display-4")).Text, Is.EqualTo("Welcome"));
      // 14 | click | css=.pb-3 |  | 
      driver.FindElement(By.CssSelector(".pb-3")).Click();
      // 15 | click | css=.container:nth-child(1) |  | 
      driver.FindElement(By.CssSelector(".container:nth-child(1)")).Click();
    }
  }
}