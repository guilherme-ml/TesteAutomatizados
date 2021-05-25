using AutomationPractice.Base;
using AutomationPractice.PageObject;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Abstractions;

namespace AutomationPractice.Steps
{
   public class ShoppingSteps : BaseTests
    {
        public ShoppingSteps(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }
        public static void ProsseguirCompra()
        {
            Report.Log("confirmar que leu os termos de serviço e prosseguir compra");
            WebDriver.FindElement(Shopping.TermsOfService).Click();
            WebDriver.FindElement(Shopping.ProceedToCheckout).Click();
        }
    }
}
