1 - Para implementar a função criei listas com os nomes dos números, cada lista abrangendo um conjunto de números próximos. A função verifica o número de entrada valida qual é seu tamanho (ex. centena-dezena-unidade) e percorre as listas referentes. O principal desafio foi entender em como organizar o código para retornar o nome do número em como ele é pronunciado. 

2 - Para soma de um array com tamanho acima de 600000 valores, existe uma ligeira diferença no tempo de execução do código. Por isso a opção para utilizar a função que executa os calculos de forma paralela. Para valores menores o método em fila é mais eficiente.

3 - Para validar a entrada criei um expressão regular para aceitar apenas expressões matematicas simples. Para validar cálculos complexos ou inexistentes, validei a entrada do valor, na pilha de divisão, se passasse da validação ele executa o cálculo e verifica novamente se é valido. 

4 - Pela minha compreensão do problema, implementei um método que herda da interface IEqualityComparer para comparar os valores do objeto em questão e retorna valores únicos. O desafio foi entender como fazer a comparação em sí do objeto.