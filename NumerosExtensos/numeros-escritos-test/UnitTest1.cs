using System;
using Xunit;
using numeros_escritos;

namespace numeros_escritos_test
{

    public class UnitTest1
    {
        //Teste do método ------------------------------------------------------------------------------
        //Aceita números inteiros até 999999 -----------------------------------------------------------
        //Digitar o número desejado no método 'Converter()' --------------------------------------------
        //Para números fora da faixa descrita o retorno esperado é a frase 'Número não mapeado no método'
        [Fact]
        public void Test1()
        {
            var numb = new Numeros().Converter(-123);


            Assert.Equal("menos cento e vinte e tres", numb);
        }
    }

}