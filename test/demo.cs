using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;
using System;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace ws.SeleniumTests
{
    [TestClass]
    public class DotNetSiteTests
    {
        public TestContext? TestContext { get; set; }
        public static ExtentReports? extent;
        public static ExtentTest test;
        // public ChromeDriver driver;
        
        
        [ClassInitialize]
        public static void Setup(TestContext context)
        {
        
            extent = new ExtentReports();
            Console.WriteLine("Setup");
            
            // Initialize ExtentReports
            Directory.CreateDirectory("/tmp/results");
            
            var htmlReporter = new ExtentHtmlReporter("/tmp/results/cc.html");
            extent.AttachReporter(htmlReporter);
            test = extent.CreateTest("Demo");
            test.Log(Status.Info, "This is a selenium test on an MVC dotnet web application");
            test.Log(Status.Info, "Repo URL: https://github.com/snsinahub-org/dotnetenium");
            // driver = GetDriver();
            
        }

        
        
        

        [TestMethod]
        public void TestCSSClassPrivacy()
        {
            // Chrome Driver was manually downloaded from https://sites.google.com/a/chromium.org/chromedriver/downloads
            // parameter "." will instruct to look for the chromedriver.exe in the current folder (bin/debug/...)
            test = extent.CreateTest(TestContext.TestName);
            test.Log(Status.Info, "Navigate to DotNet website");
            var driver = GetDriver();
            
                
            driver.Navigate().GoToUrl((string)TestContext.Properties["webAppUrl"]);

            // add log from test
            
            //Click the Get Started button
            driver.FindElement(By.LinkText("Privacy Policy")).Click();
            var css = driver.FindElement(By.LinkText("Privacy Policy")).GetAttribute("class");
            var cssMenu = driver.FindElement(By.LinkText("Privacy")).GetAttribute("class");

            Console.WriteLine("CSS ---> " + css);
            
            Assert.AreEqual(css, "privacy");

            if (css != "privacy")
            {
                test.Log(Status.Warning, "CSS class is NOT matched with privacy");
            } else {
                test.Log(Status.Info, "CSS class is matched with privacy");
            }  
                
           driver.Quit();
        }
        
        [TestMethod]
        public void TestCSSClassNotPrivacy()
        {
            // Chrome Driver was manually downloaded from https://sites.google.com/a/chromium.org/chromedriver/downloads
            // parameter "." will instruct to look for the chromedriver.exe in the current folder (bin/debug/...)
            
            var driver = GetDriver();
            test = extent.CreateTest(TestContext.TestName);
            // extent.LogInfo("TestLink2");
            //Navigate to DotNet website
            driver.Navigate().GoToUrl((string)TestContext.Properties["webAppUrl"]);
            //Click the Get Started button
            driver.FindElement(By.LinkText("Privacy")).Click();                
            var cssMenu = driver.FindElement(By.LinkText("Privacy")).GetAttribute("class");

            Console.WriteLine("CSS MENU ---> " + cssMenu);
            
            Assert.AreNotEqual(cssMenu, "not-privacy");

            if (cssMenu != "not-privacy")
            {
                test.Log(Status.Warning, "CSS class is NOT matched with not-privacy");
            } else {
                test.Log(Status.Info, "CSS class is matched with not-privacy");
            }  
                
    
                
       
        }

        

        [TestMethod]
        public void TestLink1()
        {
            // Chrome Driver was manually downloaded from https://sites.google.com/a/chromium.org/chromedriver/downloads
            // parameter "." will instruct to look for the chromedriver.exe in the current folder (bin/debug/...)
            
            var driver = GetDriver();
            test = extent.CreateTest(TestContext.TestName);
            // extent.LogInfo("TestLink2");
            //Navigate to DotNet website
            driver.Navigate().GoToUrl((string)TestContext.Properties["webAppUrl"]);
            //Click the Get Started button
            // test url link if correct after click find element by id


            driver.FindElement(By.Id("redirect")).Click();        
            
            // check if driver.url is matching the expected url
            // if not matching, add a soft assertion to the test
            if (driver.Url != "https://dotnet.microsoft.com/")
            {
                test.Log(Status.Warning, "URL is not matching the expected URL");
            } else {
                test.Log(Status.Info, "URL is matching the expected URL");
            }  
                
         
        }

        // [TestMethod]
        // public void TestLink2()
        // {
        //     // Chrome Driver was manually downloaded from https://sites.google.com/a/chromium.org/chromedriver/downloads
        //     // parameter "." will instruct to look for the chromedriver.exe in the current folder (bin/debug/...)
        //     // using (var driver = GetDriver())
            
        //     var driver = GetDriver();
        //     test = extent.CreateTest(TestContext.TestName);
        //     driver.Navigate().GoToUrl((string)TestContext.Properties["webAppUrl"]);
            

        //     test.Log(Status.Info, "Navigate to https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-7.0");
        //     driver.FindElement(By.Id("redirect")).Click();                
            
        //     Assert.AreEqual(driver.Url, "https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-7.0");

        //     if (driver.Url != "https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-7.0")
        //     {
        //         test.Log(Status.Warning, "URL is not matching the expected URL 'https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-7.0'");
        //     } else {
        //         test.Log(Status.Info, "URL is matching the expected URL 'https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-7.0'");
        //     }  
    
                
           
        // }


        private ChromeDriver GetDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--headless");
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-dev-shm-usage");
            options.AddArgument("--user-data-dir .");
            options.AddArgument("--ignore-certificate-errors");

            options.AcceptInsecureCertificates = true;
            

            if(bool.Parse((string)TestContext.Properties["headless"]))
            {
                options.AddArgument("headless");
            }

            return new ChromeDriver("/tmp", options);
        }

        [TestCleanup]
        public void endReporting()
        {
            Console.WriteLine("TestCleanup");
            extent.Flush();
            

        }
    }
}
