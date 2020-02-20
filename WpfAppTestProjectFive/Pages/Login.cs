using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTestProjectFive.Pages
{
    public class Login : Action
    {

        IWebDriver driver;


        public Login(IWebDriver driver)
        {
            this.driver = driver;
        }



        public String userName
        {
            set
            {
                Action add = new Action(driver);
                add.ClickElement(By.XPath(locators.login.ResourceManager.GetString("userName")), 90);
                add.SetText(By.XPath(locators.login.ResourceManager.GetString("userName")), 90, value);

            }
        }


        public String password
        {
            set
            {
                Action add = new Action(driver);
                add.ClickElement(By.XPath(locators.login.ResourceManager.GetString("password")), 90);
                add.SetText(By.XPath(locators.login.ResourceManager.GetString("password")), 90, value);
            }
        }


        public void loggin()
        {

            Action add = new Action(driver);
            add.ClickElement(By.XPath(locators.login.ResourceManager.GetString("loginButton")), 90);

        }



        public void skip()
        {
            Action add = new Action(driver);
            add.ClickElement(By.XPath(locators.map.ResourceManager.GetString("skip")), 90);
        }


    }
}
