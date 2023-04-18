using CalculoString;

namespace CalculoString.Teste
{
    public class UnitTest1
    {
        //Teste do m�todo ------------------------------------------------------------
        //Aceita n�meros inteiros ----------------------------------------------------
        //Digitar o calculo desejado em formato string no m�todo 'Eval()'
        //Retorna o valor esperado em formato de string' -----------------------------
        //Retorna erros validados para express�es complexas ou entradas fora do padr�o
        [Fact]
        public void Test1()
        {
            var numb = new Calcular().Eval("9/8+9-8*2");


            Assert.Equal("9", numb);
        }
    }
}