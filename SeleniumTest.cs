using Google.Protobuf.WellKnownTypes;
using NUnit.Framework;

using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

using System.Collections.ObjectModel;

using System.IO;

using WebDriverManager;

using WebDriverManager.DriverConfigs.Impl;


namespace LeadConsultTask
{
    public class Tests
    {
        
        IWebDriver driver = new ChromeDriver();
        public void Setup() 
        {
            new DriverManager().SetUpDriver(new ChromeConfig());

            var driver = new ChromeDriver();

          

        }

        [Test]
        public void submitContactForm()
        {
            driver.Navigate().GoToUrl("https://www.leadconsult.eu/contact-us/");
            WebElement fullName;
            driver.FindElement(By.CssSelector("#wpcf7-f5661-p6126-o1 > form > p:nth-child(2) > label > span > input")).SendKeys("Vladi Hristov");
            WebElement emailAddress;
            driver.FindElement(By.CssSelector("#wpcf7-f5661-p6126-o1 > form > p:nth-child(3) > label > span > input")).SendKeys("vladislav.poshta@gmail.com");
            WebElement phoneNumber;
            driver.FindElement(By.CssSelector("#wpcf7-f5661-p6126-o1 > form > p:nth-child(4) > label > span > input")).SendKeys("0883305655");
            WebElement freeText;
            driver.FindElement(By.CssSelector("#wpcf7-f5661-p6126-o1 > form > p:nth-child(5) > label > span > textarea")).SendKeys("This is an automated test message. Please disregard. Thank you!");

            //IWebElement textArea = driver.FindElement(By.Id("#g-recaptcha-response"));
            //IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            //js.ExecuteScript("arguments[0].style = 'display: block;'", textArea);
            //textArea.SendKeys("6LcFY-AaAAAAAAQFQDMvppCo7MXzt45qKqnqR2GY");

            
            WebElement checkbox;
            driver.FindElement(By.CssSelector("#wpcf7-f5661-p6126-o1 > form > p:nth-child(8) > span > span > span > label > input[type=checkbox]")).Click();
            

            IWebElement submitButton;
            driver.FindElement(By.CssSelector("#wpcf7-f5661-p6126-o1 > form > p:nth-child(9) > input")).Click();

            

        }

    }
}

        
    