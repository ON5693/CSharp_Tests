using System;

namespace numeros_escritos
{
    public class Numeros
    {
        List<string> unidades = new List<string> { "zero", "um", "dois", "tres", "quatro", "cinco", "seis", "sete", "oito", "nove" };

        List<string> dezenas1 = new List<string> { "dez", "onze", "doze", "treze", "quartoze", "quinze", "dezeseis", "dezesete", "dezoito", "dezenove" };

        List<string> dezenas2 = new List<string> { "", "", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };

        List<string> centos = new List<string> { "", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seissentos", "setecentos", "oitocentos", "novecentos" };


        string words = "";

        //Método para converter numerais em números escritos por extenso
        public string Converter(int number) {

            int temp = number;

            if (number < 0)
            {
                number = -number;
            }


            if (number < 10) 
            {
                getUnits(number);
            }

            else if (number < 20) 
            {
                getFirstDozens(number);
            }

            else if (number == 100)
            {
                return "cem";
            }

            else if (number < 100) 
            {
                getSecondDozens(number);
            }

            else if (number < 1000) 
            {
                getCents(number);
            }

            else if (number < 1000000)
            {
                getMilhar(number);
            }

            else 
            {
                return "Número não mapeado pelo método";
            }

            if (temp < 0)
            {
                words = "menos " + words;
            }

            return words;

        }

        //Retorna unidades
        string getUnits(int number) {

            words = unidades[number];
            return words;
        }

        //Retorna numeros entre 10 e 19
        string getFirstDozens(int number)
        {

            words = dezenas1[number - 10];
            return words;
        }

        //Retorna numeros entre 20 e 99
        string getSecondDozens(int number)
        {

            words = dezenas2[number / 10] + ((number % 10 != 0) ? " e " + getUnits(number % 10) : "");
            return words;
        }

        //Retorna as centenas
        string getCents(int number)
        {
            //Verifica os casos de centenas + unidades, centenas + dezenas + unidades e somente centenas
            if (number % 100 != 0 && number % 100 < 10)
            {
                words = centos[number / 100] + " e " + getUnits(number % 100);
            }
            else if (number % 100 != 0 && number % 100 >= 10 && number % 100 < 20)
            {
                words = centos[number / 100] + " e " + getFirstDozens(number % 100);
            }
            else
            {
                words = centos[number / 100] + ((number % 100 != 0) ? " e " + Converter(number % 100) : ""); 
            }

            return words;
        }

        //Retorna os milhares chamando o métono novamente
        string getMilhar(int number)
        {
            words = Converter(number / 1000) + " mil" +  ((number % 1000 != 0) ? " e " + Converter(number % 1000) : "");
            return words;
        }

    }

}
