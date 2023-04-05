﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;


namespace NUnit_Selenium
{
    public class SeleniumTest
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            // Methods -get_url, click
            // Call WebDriverManager
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig()); 
            driver = new ChromeDriver(); 
        }

        [Test]
        public void Test1()
        {
            driver.Url = "https://github.com/stefanborcia";
        }
    }
}