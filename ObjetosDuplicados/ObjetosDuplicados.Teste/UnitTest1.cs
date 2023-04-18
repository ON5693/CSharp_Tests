using FluentAssertions;
using ObjetosDuplicados;
using System.Linq;

namespace ObjetosDuplicados.Teste
{
    public class UnitTest1
    {
        //Teste do m�todo --------------------
        //Retorna nova lista sem as duplicatas 
        [Fact]
        public void Test1()
        {
            List<Objetos> list = new List<Objetos>();
            list.Add(new Objetos("Jo�o", "Estudante"));
            list.Add(new Objetos("Jo�o", "Estudante"));
            list.Add(new Objetos("Jos�", "Empresario"));
            list.Add(new Objetos("Maria", "Enfermeira"));
            list.Add(new Objetos("Maria", "Enfermeira"));
            List<Objetos> actualList = list.Distinct(new CompareObjects()).ToList();

            List<Objetos> expectedList = new List<Objetos>();
            expectedList.Add(new Objetos("Jo�o", "Estudante"));
            expectedList.Add(new Objetos("Jos�", "Empresario"));
            expectedList.Add(new Objetos("Maria", "Enfermeira"));

            expectedList.Should().BeEquivalentTo(actualList);

        }
    }
}