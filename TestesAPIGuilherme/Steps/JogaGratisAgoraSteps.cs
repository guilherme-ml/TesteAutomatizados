using TestesAPIGuilherme.Base;
using TestesAPIGuilherme.PageObject;
using TestesUIGuilherme.PageObject;
using Xunit;
using Xunit.Abstractions;

namespace TestesUIGuilherme.Steps
{
    public class JogaGratisAgoraSteps : BaseTests
    {
        public JogaGratisAgoraSteps(ITestOutputHelper outputHelper) : base(outputHelper) 
        { 
        }
        public static void JogarNoPs4() 
        {
            Report.Log("Clicar na opção ps4");
            WebDriver.FindElement(JogaGratisAgora.Ps4).Click();
           

        }
        public static void JogarNoXboxOne()
        {
            Report.Log("Clicar na opção xbox one");
            WebDriver.FindElement(JogaGratisAgora.XboxOne).Click();
        }
        public static void JogarNoPc()
        {
            Report.Log("Clicar na opção pc");
            WebDriver.FindElement(JogaGratisAgora.BattleNet).Click();
        }
    }
    
}
