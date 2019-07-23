using System;
using Xunit;

namespace LeilaoOnline.Tests
{
    public class LeilaoTests
    {
        //public void Verifica(double esperado, double obtido)
        //{
        //    if (esperado == obtido)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Console.WriteLine("Teste OK!.");
        //    }
        //    else
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine($"TESTE FALHOU! Esperado: {esperado}, obtido: {obtido}.");
        //    }
        //}
        [Fact]
        public void LeilaoComTresClientes()
        {
        }


        [Fact]
        public void LeilaoComLancesOrdenadosPorValor()
        {
        }


        [Fact]
        public void LeilaoComVariosLances()
        {
            //Arranje - cenário || Given
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessado("Fulano", leilao);
            var maria = new Interessado("Maria", leilao);

            leilao.RecebeLance(fulano, 800);
            leilao.RecebeLance(maria, 900);
            leilao.RecebeLance(fulano, 1000);
            leilao.RecebeLance(maria, 990);

            //Act - método sob teste || When
            leilao.TerminaPregao();

            //Assert || Then
            var valorEsperado = 1000;
            var valorObtido = leilao.Ganhador.Valor;
            //Verifica(valorEsperado, valorObtido);
            Assert.Equal(valorEsperado, valorObtido);
        }

        [Fact]
        public void LeilaoComApenasUmLance()
        {
            //Arranje - cenário || Given
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessado("Fulano", leilao);
            var maria = new Interessado("Maria", leilao);

            leilao.RecebeLance(fulano, 800);


            //Act - método sob teste || When
            leilao.TerminaPregao();

            //Assert || Then
            var valorEsperado = 800;
            var valorObtido = leilao.Ganhador.Valor;
            //Verifica(valorEsperado, valorObtido);
            Assert.Equal(valorEsperado, valorObtido);
        }
    }
}
