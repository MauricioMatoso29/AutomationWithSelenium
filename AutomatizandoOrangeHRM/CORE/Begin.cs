using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizandoOrangeHRM.CORE
{
    public class Begin : DSL
    {
        private void AbreNavegador()
        {
            var headLessMode = new ChromeOptions();
            headLessMode.AddArgument("window-size=1920x1080");
            headLessMode.AddArgument("disk-cache-size=0");
            headLessMode.AddArgument("headless");

            var devMode = new ChromeOptions();
            devMode.AddArgument("disk-cache-size=0");
            devMode.AddArgument("start-maximized");

            if (headLessTest)
            {
                driver = new ChromeDriver(headLessMode);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(25);
            }
            else
            {
                driver = new ChromeDriver(devMode);
                driverQuit = false;
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(25);
            }
        }

        [SetUp]
        public void InicioTeste()
        {
            AbreNavegador();
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
        }


        [TearDown]
        public void FimDoTeste()
        {
            if (driverQuit == true)
                driver.Quit();
        }
    }
}
