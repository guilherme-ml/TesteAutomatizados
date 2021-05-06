using System;
using TestesAPIGuilherme.Base;
using TestesAPIGuilherme.Steps;
using TestesUIGuilherme.Steps;
using Xunit;
using Xunit.Abstractions;

namespace TestesAPIGuilherme
{
    public class Feature : BaseTests
    {

        public Feature(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }

        [Fact]
        public void TesteNavegadorSucesso()
        {
            HomePageSteps.ClicarAssistirAoTrailer();
            AssistirTrailerSteps.AssistirAoTrailer("05","01","2000");
            AssistirTrailerSteps.ValidaIdadePermitida();
            TestStatusResult = true;
        }
       
        [Fact]
        public void TesteNavegadorFalha()
        {
            HomePageSteps.ClicarAssistirAoTrailer();
            AssistirTrailerSteps.AssistirAoTrailer("05", "01", "2006");
            AssistirTrailerSteps.ValidaIdadeNegada();
            TestStatusResult = true;
        }
        
        [Fact]
        public void TesteJogarNoPs4()
        {
            HomePageSteps.ClicarJogarGratisAgora();
            JogaGratisAgoraSteps.JogarNoPs4();
            TestStatusResult = true;
        }

        [Fact]
        public void TesteJogarNoXboxOne()
        {
            HomePageSteps.ClicarJogarGratisAgora();
            JogaGratisAgoraSteps.JogarNoXboxOne();
        }

        [Fact]
        public void TesteJogarNoPc()
        {
            HomePageSteps.ClicarJogarGratisAgora();
            JogaGratisAgoraSteps.JogarNoPc();
        }
    }
}

