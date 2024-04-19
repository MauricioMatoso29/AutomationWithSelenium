using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.Runtime.InteropServices;

namespace AutomatizandoOrangeHRM.CORE
{
    public class DSL : VariaveisGlobais
    {
        #region Funções de Manipulação
        public static void Espere(int time) => Thread.Sleep(time);

        public void LimparCampo(string element) => driver.FindElement(By.XPath(element)).Clear();

        public void ClicaFora() => driver.FindElement(By.XPath("//hrml")).Click();

        public void EsperaElemento(string element, int seconds = 90)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until((d) => { return d.FindElement(By.XPath(element)); });
        }

        public void EsperaElementoSumir(string element)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(90));
            wait.Until(d => d.FindElements(By.XPath(element)).Count == 0);
        }

        public bool ValidaElemtnoExistente(string xPath)
        {
            try
            {
                driver.FindElement(By.XPath(xPath));
                return true;
            }
            catch (NoSuchDriverException)
            {
                return false;
            }
        }
        #endregion

        #region Funções de Intereção
        public void EscreveTexto(string xpath, string value, [Optional] string description)
        {
            try
            {
                driver.FindElement(By.XPath(xpath)).SendKeys(value);
                if (description != null) Console.WriteLine("Preencheu" + description);
            }
            catch
            {
                if (description != null) Console.WriteLine("Erro ao preencher" + description);
                Assert.Fail();
            }

        }

        public void ClicaElemento(string element, [Optional] string description)
        {
            try
            {
                driver.FindElement(By.XPath(element)).Click();
                if (description != null) Console.WriteLine("Clicou" + description);
            }
            catch (Exception ex)
            {
                if (description != null) Console.WriteLine("Erro ao clicar em" + description
                    + exceptionMsg + ex.Message);
                Assert.Fail();
            }
        }

        public void ValidaURL(string expectedURL, [Optional] string description)
        {
            try
            {
                string currentURL = driver.Url;
                Assert.That(currentURL, Is.EqualTo(expectedURL));
                if (description != null)
                    Console.WriteLine("Validou a URL" + description);
            }
            catch (Exception ex)
            {
                string exceptionMsg = " - Erro: ";
                if (description != null)
                    Console.WriteLine("Erro ao validar a URL" + description + exceptionMsg + ex.Message);
                Assert.Fail();
            }
        }

        public void ValidaURLContains(string expectedPart, [Optional] string description)
        {//este metodo vai validar se a url tem so uma parte do caminho, que é a parte que estou passando como parametro
            try
            {
                string currentURL = driver.Url;
                Assert.That(currentURL, Does.Contain(expectedPart));
                if (description != null)
                    Console.WriteLine("Validou a URL" + description);
            }
            catch (Exception ex)
            {
                string exceptionMsg = " - Erro: ";
                if (description != null)
                    Console.WriteLine("Erro ao validar a URL" + description + exceptionMsg + ex.Message);
                Assert.Fail();
            }
        }
        public void MenuDropDown(string xPath, string value, [Optional] string description)
        {
            try
            {
                string xPathValue = "//*[text()='" + value + "']";
                driver.FindElement(By.XPath(xPath)).Click();
                EsperaElemento(xPathValue);
                driver.FindElement(By.XPath(xPathValue)).Click();
                if (description != null) Console.WriteLine("Selecionou o menu Dropdown" + description);
            }
            catch (Exception ex)
            {
                if (description != null) Console.WriteLine("Erro ao selecionar menu Dropdown" + description
                    + exceptionMsg + ex.Message);
                Assert.Fail();
            }
        }

        public void ValidaDados(string xpath, string value, [Optional] string description)
        {
            try
            {
                Assert.That(driver.FindElement(By.XPath(xpath)).Text, Does.Contain(value));
                if (description != null) Console.WriteLine("Validou" + description);
            }
            catch (Exception ex)
            {
                if (description != null) Console.WriteLine("Erro ao validar" + description
                    + exceptionMsg + ex.Message);
                Assert.Fail();
            }
        }

        #endregion

    }
}
