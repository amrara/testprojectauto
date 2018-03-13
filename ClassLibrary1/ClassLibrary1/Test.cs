using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Test
    {
        [Test]
        public void TestappOne()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.klix.ba";
            driver.FindElement(By.XPath("//*[@id='kat_naslovnica']/header/div[1]/nav/ul[2]/li[2]/div/a"));
            driver.Quit();
        }

        [Test]
        public void TestappTwo()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.klix.ba";
            driver.FindElement(By.XPath("//*[@id='kat_naslovnica']/header/div[1]/nav/ul[1]/li[5]/div/a"));
            driver.Quit();
        }

    }
}
