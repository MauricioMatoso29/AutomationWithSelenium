using OpenQA.Selenium;

namespace AutomatizandoOrangeHRM.CORE
{
    public class VariaveisGlobais
    {
        public IWebDriver driver;
        public bool driverQuit = false;
        public bool headLessTest = false;
        public string exceptionMsg = "\nSelenium Message Error:";
    }
}