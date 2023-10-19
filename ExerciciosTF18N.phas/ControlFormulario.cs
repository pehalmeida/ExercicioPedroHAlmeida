using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTF18N.phas
{
    class ControlFormulario
    {
        ModelExercicio exercicio;
        private int opcao;

        public ControlFormulario() 
        { 
            exercicio = new ModelExercicio();//Conecta a classe model e a control
            ConsultarOpcao = -1;
        }//Fim do método construtor

        //Métodos modificadores
        public int ConsultarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }

        public void Menu()
        {
            Console.WriteLine("\n\n ----- Menu ----- \n\n" +
                              "1. Exercício 01\n" +
                              "2. Exercício 02\n" +
                              "3. Exercício 03\n" +
                              "4. Exercício 04\n" +
                              "5. Exercício 05\n" +
                              "6. Exercício 06\n" +
                              "7. Exercício 07\n" +
                              "8. Exercício 08\n" +
                              "9. Exercício 09\n" +
                              "10. Exercício 10\n" +
                              "Escolha uma das opções acima: ");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//Fim do menu

        public void Operacao()
        {
            do
            {
                Menu();
                Console.Clear();//Limpar dados antigos
                switch (ConsultarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        double nota1 = 0;//Declarar do lado de fora
                        double nota2 = 0;
                        do
                        {
                            Console.WriteLine("Informe a primeira nota: ");
                            nota1 = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.validarNotas(nota1) == true)
                            {
                                Console.WriteLine("Informe uma nota entre 0 e 10");
                            }//Fim da validação

                        } while (exercicio.validarNotas(nota1) == true);


                        do
                        {
                            Console.WriteLine("Informe a segunda nota: ");
                            nota2 = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.validarNotas(nota2) == true)
                            {
                                Console.WriteLine("Informe uma nota entre 0 e 10");
                            }

                        } while (exercicio.validarNotas(nota2) == true);
                        //Chamar o método da média que está na classe model
                        Console.WriteLine("A média das notas digitadas é: " + exercicio.MediaDuasNotas(nota1, nota2));
                        break;

                    case 2:
                        Console.WriteLine("Informe um número: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe outro número: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        //Comparação
                        Console.WriteLine("O maior número é: " + exercicio.Comparar(num1, num2));
                        break;

                    case 3:
                        Console.WriteLine("Informe um número: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        //Mostrar o resultado
                        Console.WriteLine("O Antecessor é: " + exercicio.Antecessor(num));
                        break;
                    case 4:
                        double bas;
                        double alt;
                        do
                        {
                            Console.WriteLine("Informe a base do retângulo: ");
                            bas = Convert.ToDouble(Console.ReadLine());
                            if (bas < 0)
                            {
                                Console.WriteLine("Erro! Informe um valor positivo!");
                            }
                        } while (bas < 0);

                        do
                        {
                            Console.WriteLine("Informe a altura do retângulo: ");
                            alt = Convert.ToDouble(Console.ReadLine());
                            if (alt < 0)
                            {
                                Console.WriteLine("Erro! Informe um valor positivo");
                            }
                        } while (alt < 0);
                        //Mostrar a mensagem na tela
                        Console.WriteLine("A área do retângulo é: " + exercicio.AreaRetangulo(bas, alt));
                        break;
                    case 5:
                        double totalEleitores;
                        double validos;
                        double nulos;
                        double brancos;
                        //Total de Eleitores
                        do
                        {
                            Console.WriteLine("Informe o total de eleitores");
                            totalEleitores = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(totalEleitores) == false)
                            {
                                Console.WriteLine("Informe um valor positivo!");
                            }
                        } while (exercicio.Validar(totalEleitores) == false);
                        //Votos Brancos
                        do
                        {
                            Console.WriteLine("Informe o total de votos brancos");
                            brancos = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(brancos) == false)
                            {
                                Console.WriteLine("Informe um valor positivo!");
                            }
                        } while (exercicio.Validar(brancos) == false);
                        //Votos Validos
                        do
                        {
                            Console.WriteLine("Informe o total de votos válidos");
                            validos = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(validos) == false)
                            {
                                Console.WriteLine("Informe um valor positivo!");
                            }
                        } while (exercicio.Validar(validos) == false);
                        //Total de nulos
                        do
                        {
                            Console.WriteLine("Informe o total de votos nulos");
                            nulos = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(nulos) == false)
                            {
                                Console.WriteLine("Informe um valor positivo!");
                            }
                        } while (exercicio.Validar(nulos) == false);

                        //Fazer o cálculo
                        if (brancos + validos + nulos == totalEleitores)
                        {
                            Console.WriteLine("\nHá " + exercicio.PorcentagemVotos(brancos, totalEleitores) + "% de votos brancos"
                                            + "\nHá " + exercicio.PorcentagemVotos(nulos, totalEleitores) + "% de votos nulos"
                                            + "\nHá " + exercicio.PorcentagemVotos(validos, totalEleitores) + "% de votos validos");
                        }
                        else
                        {
                            Console.WriteLine("O total de eleitores é diferente da soma de brancos, validos e nulos.");
                        }

                        break;

                    case 6:
                        double salario;
                        double reajuste;
                        do
                        {
                            Console.WriteLine("Informe o salário:");
                            salario = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(salario) == false)
                            {
                                Console.WriteLine("Informe um valor positivo.");
                            }
                        } while (exercicio.Validar(salario) == false);
                        
                        do
                        {
                            Console.WriteLine("Informe o reajuste:");
                            reajuste = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(reajuste) == false)
                            {
                                Console.WriteLine("Informe um valor positivo.");
                            }
                        } while (exercicio.Validar(reajuste) == false);
                        break;
                    case 7:
                        double fabricacao;
                        double distri;
                        double imposto;
                        do
                        {
                            Console.WriteLine("Informe o valor de fabricação: ");
                            fabricacao = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(fabricacao) == false)
                            {
                                Console.WriteLine("Informe um valor positivo");
                            }
                        } while (exercicio.Validar(fabricacao) == false);

                        do
                        {
                            Console.WriteLine("Informe o percentual do distribuidor: ");
                            distri = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(distri) == false)
                            {
                                Console.WriteLine("Informe um valor válido!");
                            }
                        } while (exercicio.Validar(distri) == false);

                        do
                        {
                            Console.WriteLine("Informe o percentual de imposto: ");
                            imposto = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(imposto) == false)
                            {
                                Console.WriteLine("Informe um valor válido!");
                            }
                        } while (exercicio.Validar(imposto) == false);
                        

                        Console.WriteLine("O valor total do carro é: " +
                                         (exercicio.CustoInicial(fabricacao, distri) +
                                         exercicio.CustoInicial(fabricacao, imposto) +
                                         fabricacao));
                        break;
                    case 8:
                        double salarioFixo;
                        double totalCarro;
                        double comFixa;
                        double valorVenda;
                        do
                        {
                            Console.WriteLine("Informe o salário fixo: ");
                            salarioFixo = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(salarioFixo) == false)
                            {
                                Console.WriteLine("Informe um valor válido!");
                            }
                        } while (exercicio.Validar(salarioFixo) == false);

                        do
                        {
                            Console.WriteLine("Informe o total de carros vendidos: ");
                            totalCarro = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(totalCarro) == false)
                            {
                                Console.WriteLine("Informe um valor válido!");
                            }
                        } while (exercicio.Validar(totalCarro) == false);

                        do
                        {
                            Console.WriteLine("Informe a comissão fixa: ");
                            comFixa = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(comFixa) == false)
                            {
                                Console.WriteLine("Informe um valor válido!");
                            }
                        } while (exercicio.Validar(comFixa) == false);

                        do
                        {
                            Console.WriteLine("Informe o valor total de vendas: ");
                            valorVenda = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(valorVenda) == false)
                            {
                                Console.WriteLine("Informe um valor válido!");
                            }
                        } while (exercicio.Validar(valorVenda) == false);

                        Console.WriteLine("O salário total é: " +
                                         (exercicio.ComicaoCarro(totalCarro, comFixa) + 
                                          exercicio.TotalComVendas(valorVenda) + salarioFixo));
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é válida!");
                        break;
                }//fim do escolha
            } while (ConsultarOpcao != 0);//Fim do While
        }//fim do método

    }//Fim da classe
}//Fim do projeto
