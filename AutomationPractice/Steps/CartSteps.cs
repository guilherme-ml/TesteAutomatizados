using AutomationPractice.Base;
using AutomationPractice.PageObject;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace AutomationPractice.Steps
{
   public class CartSteps : BaseTests 
    { 
        public CartSteps(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }
        public static void ProsseguirParaCarrinho()
        {
            Report.Log("prosseguir compra no carrinho");
            WebDriver.FindElement(Cart.ProceedToCheckout).Click();
        }
        public static void Prosseguir()
        {
            Report.Log("prosseguir compra no carrinho");
            WebDriver.FindElement(Cart.ProseguirCarrinho).Click();
            Assert.True(WebDriver.FindElement(SignIn.CreateInformarEmail).Enabled);
        }

    }
}
