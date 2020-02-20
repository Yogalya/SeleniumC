using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTestProjectFive.Pages
{
    public static class ElementWait
    {

        public static IWebElement FindElementwithWait(By locator, IWebDriver driver, int timeoutInSeconds = 0)
        {

            if (timeoutInSeconds > 0)
            {

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(90));
                return wait.Until(ExpectedConditions.ElementIsVisible(locator));

            }

            return driver.FindElement(locator);



        }
    }
}
