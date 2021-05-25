using AutomationPractice.Base;
using AutomationPractice.PageObject;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace AutomationPractice.Steps
{
    public class HomePageSteps : BaseTests
    {
        public HomePageSteps(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }

        public static void ClicarEmSearch()
        {
            Report.Log("clicar no botao search na home page");
            WebDriver.FindElement(HomePage.Search).SendKeys("Dresses");
            WebDriver.FindElement(HomePage.Buscar).Click();
        }
        public static void ClicarEmCart()
        {
            Report.Log("clicar no botao cart na home page");
            WebDriver.FindElement(HomePage.Cart).Click();
        }
        public static void ClicarEmAddCart()
        {
            Report.Log("clicar no botao Add to cart no produto desejado na home page");
            WebDriver.FindElement(HomePage.AddToCart).Click();
            Assert.True(WebDriver.FindElement(Cart.ProceedToCheckout).Enabled);

        }
        public static void ClicarEmContactUs()
        {
            Report.Log("clicar no botao report us na home page");
            WebDriver.FindElement(HomePage.ContactUs).Click();

        }
        public static void ClicarEmDresses()
        {
            Report.Log("clicar no botao dresses na home page");
            WebDriver.FindElement(HomePage.Dresses).Click();
        }
        public static void ClicarEmMore()
        {
            Report.Log("clicar no botao more no produto que desejar na home page");
            WebDriver.FindElement(HomePage.More).Click();
        }
        public static void ClicarEmSignIn()
        {
            Report.Log("clicar no botao sign in na home page");
            WebDriver.FindElement(HomePage.SigIn).Click();
        }
        public static void ClicarEmTShirts()
        {
            Report.Log("clicar no botao T-shirts na home page");
            WebDriver.FindElement(HomePage.TShirts).Click();
        }
        public static void CicarEmWomen()
        {
            Report.Log("clicar no botao women na home page");
            WebDriver.FindElement(HomePage.Women).Click();
        }
        public static void ClicarNaLogo()
        {
            Report.Log("clicar na logo para retornar para home page");
            WebDriver.FindElement(HomePage.Logo).Click();
        }
        public static void ClicarNoProduto1()
        {
            Report.Log("clicar no primeiro produto da loja");
            WebDriver.FindElement(HomePage.Produto1).Click();
        }
        public static void ContaLogada()
        {
            Report.Log("clicar no nome do usuario que esta logado");
            WebDriver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=my-account");
        }
    }
}



