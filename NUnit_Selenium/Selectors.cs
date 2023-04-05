using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnit_Selenium
{

    public class Selectors
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
        }

        [Test]
        public void SelectorsIdentification()
        {
            driver.FindElement(By.Id("email")).SendKeys("this@isworking.com");
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("this@isagainworking.com");
            driver.FindElement(By.Id("pass")).SendKeys("something");

        }
    }
}
