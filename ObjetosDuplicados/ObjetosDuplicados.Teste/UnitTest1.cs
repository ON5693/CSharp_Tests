using FluentAssertions;
using ObjetosDuplicados;
using System.Linq;

namespace ObjetosDuplicados.Teste
{
    public class UnitTest1
    {
        //Teste do método --------------------
        //Retorna nova lista sem as duplicatas 
        [Fact]
        public void Test1()
        {
            List<Objetos> list = new List<Objetos>();
            list.Add(new Objetos("João", "Estudante"));
            list.Add(new Objetos("João", "Estudante"));
            list.Add(new Objetos("José", "Empresario"));
            list.Add(new Objetos("Maria", "Enfermeira"));
            list.Add(new Objetos("Maria", "Enfermeira"));
            List<Objetos> actualList = list.Distinct(new CompareObjects()).ToList();

            List<Objetos> expectedList = new List<Objetos>();
            expectedList.Add(new Objetos("João", "Estudante"));
            expectedList.Add(new Objetos("José", "Empresario"));
            expectedList.Add(new Objetos("Maria", "Enfermeira"));

            expectedList.Should().BeEquivalentTo(actualList);

        }
    }
}