using CalculoString;

namespace CalculoString.Teste
{
    public class UnitTest1
    {
        //Teste do método ------------------------------------------------------------
        //Aceita números inteiros ----------------------------------------------------
        //Digitar o calculo desejado em formato string no método 'Eval()'
        //Retorna o valor esperado em formato de string' -----------------------------
        //Retorna erros validados para expressões complexas ou entradas fora do padrão
        [Fact]
        public void Test1()
        {
            var numb = new Calcular().Eval("9/8+9-8*2");


            Assert.Equal("9", numb);
        }
    }
}