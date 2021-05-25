using AutomationPractice.Base;
using AutomationPractice.PageObject;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace AutomationPractice.Steps
{
   public class MyAccountSteps : BaseTests
    {
        public MyAccountSteps(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }
        public static void AcessarHistoricoDecompras()
        {
            Report.Log("clicar nos historico do compras");
            WebDriver.FindElement(HomePage.HistoricoDeCompras).Click();
            Assert.True(WebDriver.FindElement(HomePage.Home).Displayed);
        }
        public static void VoltarParaHomePage()
        {
            Report.Log("clicar em home para voltar para homepage");
            WebDriver.FindElement(HomePage.Home).Click();
        }
        public static void ClicarEmMeuEndereco()
        {
            Report.Log("Clicar em meu endereco");
            WebDriver.FindElement(MyAccount.MeuEndereco).Click();
        }
        public static void MudarEndereco()
        {
            Report.Log("clicar para atualizar endereco");
            WebDriver.FindElement(MyAccount.Atualizar).Click();
        }
        public static void MudarInformacoes(string nome, string sobrenome, string company, string address, string addressLineTwo, string city, string postalCode, string addInformations, string homePhone, string mobilePhone, string assignAddress, string state, string country)
        {
            Report.Log("mudar a informacoes dos campos de texto e clicar em salvar");
            WebDriver.FindElement(MyAccount.Nome).Clear();
            WebDriver.FindElement(MyAccount.Nome).SendKeys(nome);
            WebDriver.FindElement(MyAccount.Sobrenome).Clear();
            WebDriver.FindElement(MyAccount.Sobrenome).SendKeys(sobrenome);
            WebDriver.FindElement(MyAccount.Companhia).Clear();
            WebDriver.FindElement(MyAccount.Companhia).SendKeys(company);
            WebDriver.FindElement(MyAccount.Endereco).Clear();
            WebDriver.FindElement(MyAccount.Endereco).SendKeys(address);
            WebDriver.FindElement(MyAccount.EnderecoLinha2).Clear();
            WebDriver.FindElement(MyAccount.EnderecoLinha2).SendKeys(addressLineTwo);
            WebDriver.FindElement(MyAccount.Cidade).Clear();
            WebDriver.FindElement(MyAccount.Cidade).SendKeys(city);
            var selectElementEstado = new SelectElement(WebDriver.FindElement(MyAccount.Estado));
            selectElementEstado.SelectByValue(state);
            WebDriver.FindElement(MyAccount.CodigoPostal).Clear();
            WebDriver.FindElement(MyAccount.CodigoPostal).SendKeys(postalCode);
            var SelectElementPais = new SelectElement(WebDriver.FindElement(MyAccount.Pais));
            SelectElementPais.SelectByValue(country);
            WebDriver.FindElement(MyAccount.TelefoneCasa).Clear();
            WebDriver.FindElement(MyAccount.TelefoneCasa).SendKeys(homePhone);
            WebDriver.FindElement(MyAccount.TelefoneCelular).Clear();
            WebDriver.FindElement(MyAccount.TelefoneCelular).SendKeys(mobilePhone);
            WebDriver.FindElement(MyAccount.AddInformacao).Clear();
            WebDriver.FindElement(MyAccount.AddInformacao).SendKeys(addInformations);
            WebDriver.FindElement(MyAccount.NomeDoEndereco).Clear();
            WebDriver.FindElement(MyAccount.NomeDoEndereco).SendKeys(assignAddress);
            WebDriver.FindElement(MyAccount.Salvar).Click();
        }

        
    }
}
