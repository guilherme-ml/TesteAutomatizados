using System;
using TestesAPIGuilherme.Base;
using TestesAPIGuilherme.Steps;
using Xunit;
using Xunit.Abstractions;

namespace TestesAPIGuilherme
{
    public class UnitTest1 : BaseTests
    {

        public UnitTest1(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }

        [Fact]
        public void TesteNavegador()
        {
            HomePageSteps.ClicarAssistirAoTrailer();
            AssistirTrailerSteps.AssistirAoTrailer("05","01","2006");
            TestStatusResult = true;
        }
    }
}

