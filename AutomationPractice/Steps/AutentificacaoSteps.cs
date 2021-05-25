using AutomationPractice.Base;
using AutomationPractice.PageObject;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Abstractions;

namespace AutomationPractice.Steps
{
   public class AutentificacaoSteps : BaseTests
    {
        public AutentificacaoSteps(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }
        public static void LogarConta()
        {
            Report.Log("Colocar email e senha de um usuario e logar conta");
            WebDriver.FindElement(Autentificacao.Email).SendKeys("2CML6AJG8K@gmail.com");
            WebDriver.FindElement(Autentificacao.Senha).SendKeys("Guilherminho098");
            WebDriver.FindElement(Autentificacao.Logar).Click();
        }
    }
}
