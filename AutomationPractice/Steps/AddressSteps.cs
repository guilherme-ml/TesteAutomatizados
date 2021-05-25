using AutomationPractice.Base;
using AutomationPractice.PageObject;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Abstractions;

namespace AutomationPractice.Steps
{
   public class AddressSteps : BaseTests
    {
        public AddressSteps(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }
        public static void EscolherEndereco()
        {
            Report.Log("preencher o campo de comentario e prosseguir compra");
            WebDriver.FindElement(Address.Below).SendKeys("Não gostei da loja, estou esperando minha roupa chegar já faz mais de 8 meses");
            WebDriver.FindElement(Address.ProceedToCheckout).Click();
        }
    }
}
