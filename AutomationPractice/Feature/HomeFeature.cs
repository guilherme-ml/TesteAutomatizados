using AutomationPractice.Base;
using AutomationPractice.Steps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace AutomationPractice.Feature
{
   public class HomeFeature : BaseTests
    {
        public HomeFeature(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }

        [Fact]
        public void TesteCompleto()
        {
            Usuarios = Utils.BuscarUsuario("1");
            HomePageSteps.ClicarNoProduto1();
            HomePageSteps.ClicarEmAddCart();
            CartSteps.ProsseguirParaCarrinho();
            CartSteps.Prosseguir();
            SignInSteps.CriarEmail();
            SignInSteps.CriarConta(Usuarios[1].ToString(),Usuarios[2].ToString(), Usuarios[3].ToString(), Usuarios[4].ToString(), Usuarios[5].ToString(), Usuarios[6].ToString(), Usuarios[7].ToString(), Usuarios[8].ToString(), Usuarios[9].ToString(), Usuarios[10].ToString(), Usuarios[11].ToString(), Usuarios[12].ToString(), Usuarios[13].ToString());
            AddressSteps.EscolherEndereco();
            ShoppingSteps.ProsseguirCompra();
            PaymentSteps.FormaDePagamentoCartao();
            PaymentSteps.MudarFormaDePagamento();
            PaymentSteps.FormaDePagamentoCheck();
            PaymentSteps.FinalizarCompra();
            HomePageSteps.ContaLogada();
            MyAccountSteps.AcessarHistoricoDecompras();            

        }
        [Fact]
        public void TesteAtualizarEndereco()
        {
            Usuarios = Utils.BuscarUsuario("2");
            HomePageSteps.ClicarEmSignIn();
            AutentificacaoSteps.LogarConta();
            MyAccountSteps.ClicarEmMeuEndereco();
            MyAccountSteps.MudarEndereco();
            MyAccountSteps.MudarInformacoes(Usuarios[1].ToString(), Usuarios[2].ToString(), Usuarios[3].ToString(), Usuarios[4].ToString(), Usuarios[5].ToString(), Usuarios[6].ToString(), Usuarios[7].ToString(), Usuarios[8].ToString(), Usuarios[9].ToString(), Usuarios[10].ToString(), Usuarios[11].ToString(), Usuarios[12].ToString(), Usuarios[13].ToString());

        }
    }
}
