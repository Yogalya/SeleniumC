using NLog;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTestProjectFive.Pages
{



    public class Action
    {
        IWebDriver driver;


        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();


        public Action()
        {

        }



        public Action(IWebDriver driver)
        {
            this.driver = driver;
        }



        public void ClickElement(By locator, int timeoutInSeconds)
        {
            try
            {
                var element = this.GetElement(locator, timeoutInSeconds);
                element.Click();
            }
            catch (Exception e)
            {
                Logger.Error(e, "Element is not clickable");
            }
        }





        public void SetText(By locator, int timeoutInSeconds, String value)
        {
            try
            {
                var element = this.GetElement(locator, timeoutInSeconds);

                    element.Clear();
                    element.SendKeys(value);
            }
            catch (Exception e)
            {
                Logger.Error(e, "Text is not able to set");
            }
        }



        public IWebElement GetElement(By locator, int timeoutInSeconds)
        {
            try
            {
                return ElementWait.FindElementwithWait(locator, driver, timeoutInSeconds);
            }
            catch (Exception e)
            { 
                Logger.Error(e, "Element is not found");
                return null;
            }




        }

    }

}

