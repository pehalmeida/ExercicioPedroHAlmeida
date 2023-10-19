using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTF18N.phas
{
    class ModelExercicio
    {

        public ModelExercicio()
        {

        }//Fim do construtor

        //Exercicio 01 - A média de duas notas

        public double MediaDuasNotas(double nota1, double nota2)
        { 
            return (nota1 + nota2) / 2;
        }//Fim do método média

        //Método de validação
        public Boolean validarNotas(double nota)
        {
            if ((nota < 0) || (nota > 10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }//Fim do validação

        

         //Exercício 02
        public int Comparar(int num1, int num2)
        {
            if(num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }//Fim do comparar

        //Exercício 03 - Mostrar o antecessor
        public int Antecessor(int num)
        {
            return num - 1;
        }//fim do antecessor


        //Exercício 04 - Área do retangulo
        public double AreaRetangulo(double bas, double alt)
        {
            return bas * alt;
        }//fim do método

        //Exercício 05 - Votos
        public double PorcentagemVotos(double votos, double total)
        {
            return (votos * 100) / total;
        }//fim do método de porcentagem

        //Exercício 06 - Reajuste de salário
        public double ReajusteSalario(double salario, double reajuste)
        {
            return salario * (reajuste / 100) + salario;
        }//Fim do Reajuste

        //Exercício 07 - Custo do carro
        public double CustoInicial(double fabricacao, double valor)
        {
            return fabricacao * (valor / 100);
        }//Fim do Custo Inicial


        //Exercício 08 - Salário + comissão
        public double ComicaoCarro(double totalCarro, double comFixa)
        {
            return totalCarro * comFixa;
        }//Fim do Comicao Carro

        public double TotalComVendas(double valorVenda)
        {
            return valorVenda * 0.05;
        }//Fim do Total - Comissão - Vendas

        public Boolean Validar(double num)
        {
            if (num < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }//fim da validação
    }//Fim da classe

}//Fim do projeto
