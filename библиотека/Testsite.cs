using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
namespace библиотека
{
    [TestFixture]
    internal class Testsite
    {
        IWebDriver driver = new ChromeDriver();
        [TestCase]
        public void Test_1()
        {
            driver.Url = "\thttps://svetly5school.narod.ru/";
            IWebElement touchbutton = driver.FindElement(By.XPath("/ html / body / div / div[1] / div[1] / button[3] / i"));
            touchbutton.Click();
        }
        [TestCase]
        public void Test_2()
        {
            driver.Url = "\thttps://svetly5school.narod.ru/";
            IWebElement joinLink = driver.FindElement(By.XPath("/html/body/center/table/tbody/tr[2]/td/font/font/ul/li[1]/a"));
            joinLink.Click();
        }
        [TestCase]
        public void Test_3()
        {
            driver.Url = "\thttps://svetly5school.narod.ru/";
            IWebElement Newsbutton = driver.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td[1]/font/a[1]"));
            Newsbutton.Click();
        }
        [TestCase]
        public void Test_4()
        {
            driver.Url = "\thttps://svetly5school.narod.ru/";
            IWebElement soundButton = driver.FindElement(By.XPath("/html/body/div/div[1]/div[4]/button"));
            soundButton.Click();
        }
        [TestCase]
        public void Test_5()
        {
            driver.Url = "\thttps://svetly5school.narod.ru/";
            IWebElement mapbutton = driver.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td[1]/font/a[3]"));
            mapbutton.Click();
        }
    }
}
