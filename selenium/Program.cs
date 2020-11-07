
using AngleSharp;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://cdn.tsetmc.com/Loader.aspx?ParTree=15131P&i=35366681030756042&d=20201104";
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-notifications"); // to disable notification
            options.AddArguments("headless");// to disable opening Chrome
            IWebDriver driverCh = new ChromeDriver(options);
            driverCh.Navigate().GoToUrl(url);
            driverCh.SwitchTo().Alert().Accept();
            //string htmlCode= driverCh.PageSource; //to get Page HTML Source
            WebDriverWait wait = new WebDriverWait(driverCh, TimeSpan.FromSeconds(20));// wait untill web page load completely
            IWebElement element = driverCh.FindElement(By.XPath("//body/div[4]/form[1]/div[2]/div[2]/div[3]/div[2]"));//get the specific data of element by Xpath
            string htmlCode = element.Text;


        }
    }
}
