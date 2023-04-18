using System;
using Xunit;
using numeros_escritos;

namespace numeros_escritos_test
{

    public class UnitTest1
    {
        //Teste do m�todo ------------------------------------------------------------------------------
        //Aceita n�meros inteiros at� 999999 -----------------------------------------------------------
        //Digitar o n�mero desejado no m�todo 'Converter()' --------------------------------------------
        //Para n�meros fora da faixa descrita o retorno esperado � a frase 'N�mero n�o mapeado no m�todo'
        [Fact]
        public void Test1()
        {
            var numb = new Numeros().Converter(-123);


            Assert.Equal("menos cento e vinte e tres", numb);
        }
    }

}