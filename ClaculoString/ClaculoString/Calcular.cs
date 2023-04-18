using System.Text.RegularExpressions;

namespace CalculoString
{
    /// <summary>
    /// Classe para calcular expressoes matematicas simples com entrada em formato de string
    /// </summary>
    public class Calcular
    {
        //Método de chamada
        public string Eval(string input)
        {
            var ans = Evaluate(input);
            return ans;
        }

        //Método para verificar a expressão de entrada
        public static string Evaluate(string input)
        {

            //Verifica se a string é uma expressão matematica valida
            if (!Regex.Match(input, @"^[-+/*0-9]+$").Success) 
            { 
                return "Expressão inválida";  
            }

            //Define as variaveis de operação e valores em pilhas 
            String expr = "(" + input + ")";
            Stack<String> oprd = new Stack<String>();
            Stack<Double> values = new Stack<Double>();

            //Função que percorre todos os valores da expressão e executa o calculo fazendo a leitura reversa na pilha
            for (int i = 0; i < expr.Length; i++)
            {
                String s = expr.Substring(i, 1);
                if (s.Equals("(")) { }
                else if (s.Equals("+"))
                {
                    oprd.Push(s);
                }
                else if (s.Equals("-"))
                {
                    oprd.Push(s);
                }
                else if (s.Equals("*"))
                {
                    oprd.Push(s);
                }
                else if (s.Equals("/"))
                {
                    oprd.Push(s);
                }
                else if (s.Equals(")"))
                {
                    int count = oprd.Count;
                    while (count > 0)
                    {
                        String op = oprd.Pop();
                        double v = values.Pop();
                        if (op.Equals("+")) v = values.Pop() + v;
                        else if (op.Equals("-")) v = values.Pop() - v;
                        else if (op.Equals("*")) v = values.Pop() * v;

                        else if (op.Equals("/"))
                        {

                            if (v == 0)
                            {
                                return "Divisão por 0. A função não executa calculos complexos";
                            }

                            v = values.Pop() / (double)v;

                            if (v == 0)
                            {
                                return "Não é possível dividir por zero";
                            }
                        }

                        values.Push(v);

                        count--;
                    }
                }
                else values.Push(Double.Parse(s));
            }
            return values.Pop().ToString();
        }
    }
}