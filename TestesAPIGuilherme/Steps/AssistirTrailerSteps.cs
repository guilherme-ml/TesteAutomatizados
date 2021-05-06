using TestesAPIGuilherme.Base;
using TestesAPIGuilherme.PageObject;
using Xunit;
using Xunit.Abstractions;

namespace TestesAPIGuilherme.Steps
{
    public class AssistirTrailerSteps : BaseTests
    {
        public AssistirTrailerSteps(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }

        public static void AssistirAoTrailer(string dia, string mes, string ano)
        {
            Report.Log("Preencher os campos dia, mês e ano");
            WebDriver.FindElement(AssistirTrailer.Dia).SendKeys(dia);
            WebDriver.FindElement(AssistirTrailer.Mes).SendKeys(mes);
            WebDriver.FindElement(AssistirTrailer.Ano).SendKeys(ano);
            WebDriver.FindElement(AssistirTrailer.Enviar).Click();


        }
        public static void ValidaIdadePermitida()
        {            
            Assert.True(WebDriver.FindElement(AssistirTrailer.Trailer).Displayed);
        }
        public static void ValidaIdadeNegada()
        {           
            Assert.True(WebDriver.FindElement(AssistirTrailer.MensagemIdade).Displayed);
        }
    }
}
