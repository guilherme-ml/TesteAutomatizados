using AutomationPractice.Base;
using AutomationPractice.PageObject;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace AutomationPractice.Steps
{
   public class PaymentSteps : BaseTests
    {
        public PaymentSteps(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }
        public static void FormaDePagamentoCartao()
        {
            Report.Log("escolher a forma de pagamento bank wire ");
            WebDriver.FindElement(Payment.PayByBankWire).Click();
        }
        public static void MudarFormaDePagamento()
        {
            Report.Log("mudar forma de pagamento");
            WebDriver.FindElement(Payment.OtherPaymentMethods).Click();
        }
        public static void FormaDePagamentoCheck()
        {
            Report.Log("escolher forma de pagamento check");
            WebDriver.FindElement(Payment.PayByCheck).Click();
        }
        public static void FinalizarCompra()
        {
            Report.Log("apertar para finalizar compra");
            WebDriver.FindElement(OrderSummaryBankWire.ConfirmOrder).Click();
            //Assert.True(WebDriver.FindElement(HomePage.UsuarioLogado).Displayed);
        }
        public static void BackToOrders()
        {
            Report.Log("visualizar os produtos que estão comprados");
            WebDriver.FindElement(OrderOnfirmationCheck.BackToOrders).Click();
        }
        public static void ClicarNaLogo()
        {
            Report.Log("clicar na logo depois de finalizar a compra");
            WebDriver.FindElement(Payment.Logo).Click();
        }
    }
}
