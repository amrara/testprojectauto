using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [TestFixture]
    [Parallelizable]
    public class Test : TestsSetupClass
    {
        [Test]
        [Parallelizable]

        public void TestappOne()
        {
            driver.Url = "http://www.klix.ba";
            driver.FindElement(By.XPath("//*[@id='kat_naslovnica']/header/div[1]/nav/ul[2]/li[2]/div/a"));
        }

        [Test]
        [Parallelizable]

        public void TestappTwo()
        {
            driver.Url = "http://www.klix.ba";
            driver.FindElement(By.XPath("//*[@id='kat_naslovnica']/header/div[1]/nav/ul[1]/li[5]/div/a"));
        }

        [Test]
        [Parallelizable]
        public void TestappThree()
        {
            driver.Url = "http://www.klix.ba";
            driver.FindElement(By.XPath("//*[@id='kat_naslovnica']/header/div[1]/nav/ul[1]/li[5]/div/a"));
        }

        [Test]
        [Parallelizable]

        public void TestappFour()
        {
            driver.Url = "http://www.klix.ba";
            driver.FindElement(By.XPath("//*[@id='kat_naslovnica']/header/div[1]/nav/ul[1]/li[5]/div/a"));
        }
    }
}
