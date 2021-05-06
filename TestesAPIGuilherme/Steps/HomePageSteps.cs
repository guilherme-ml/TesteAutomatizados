﻿using TestesAPIGuilherme.Base;
using TestesAPIGuilherme.PageObject;
using TestesUIGuilherme.PageObject;
using Xunit;
using Xunit.Abstractions;

namespace TestesAPIGuilherme.Steps
{
    public class HomePageSteps : BaseTests
    {
        public HomePageSteps(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }

        public static void ClicarAssistirAoTrailer()
        {
            Report.Log("Clicar no botão assista ao trailer na home page");
            WebDriver.FindElement(HomePage.AssistirTrailer).Click();
            Assert.True(WebDriver.FindElement(AssistirTrailer.Enviar).Displayed);
            
        }
        public static void ClicarJogarGratisAgora()
        {
            Report.Log("Clicar no botão jogar grátis agora");
            WebDriver.FindElement(HomePage.JogarGratisAgora).Click();
            Assert.True(WebDriver.FindElement(JogaGratisAgora.Ps4).Displayed);

        }
       
    }
}
