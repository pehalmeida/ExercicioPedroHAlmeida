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
                              "11. Exercício 11\n" +
                              "12. Exercício 12\n" +
                              "13. Exercício 13\n" +
                              "14. Exercício 14\n" +
                              "15. Exercício 15\n" +
                              "16. Exercício 16\n" +
                              "17. Exercício 17\n" +
                              "18. Exercício 18\n" +
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
                        
                    case 9:
                        int numP;
                        do
                        {
                            Console.WriteLine("Digite um número: ");
                            numP = Convert.ToInt32(Console.ReadLine());
                            if (exercicio.Validar(numP) == false)
                            {
                                Console.WriteLine("Insira um valor válido!");
                            }
                        } while (exercicio.Validar(numP) == false);

                        if (exercicio.ParImpar(numP) == 0)
                        {
                            Console.WriteLine("O número: " + numP + " é PAR!");
                        }
                        else
                        {
                            Console.WriteLine("O número: " + numP + " é ÍMPAR!");
                        }
                        break;
                    case 10:
                        int idade;
                        do
                        {
                            Console.WriteLine("Informe a idade: ");
                            idade = int.Parse(Console.ReadLine());
                            if (exercicio.Validar(idade) == false)
                            {
                                Console.WriteLine("A idade informada é inválida!");
                            }
                        } while (exercicio.Validar(idade) == false);

                        if (idade >= 18)
                        {
                            Console.WriteLine("É maior de idade!");
                        }
                        else
                        {
                            Console.WriteLine("É menor de idade!");
                        }
                        break;
                    case 11:
                        int maior = 0;
                        for (int i = 1; i < 4; i++) {
                            Console.WriteLine("Informe o " + i + "° número: ");
                            num = int.Parse(Console.ReadLine());
                            if (num > maior)
                            {
                                maior = num;
                            }
                        }
                        Console.WriteLine("O maior número é: " + maior);
                        break;
                    case 12:
                        int ano;
                        do
                        {
                            Console.WriteLine("Informe o ano: ");
                            ano = int.Parse(Console.ReadLine());
                            if (exercicio.Validar(ano) == false)
                            {
                                Console.WriteLine("O ano informado é inválido!");
                            }
                        } while (exercicio.Validar(ano) == false);

                        if (exercicio.AnoBi(ano) == 0)
                        {
                            Console.WriteLine("O ano é Bissexto!");
                        }
                        else
                        {
                            Console.WriteLine("O ano não é Bissexto");
                        }
                        break;
                    case 13:
                        double notaM1;
                        double notaM2;
                         do
                        {
                            Console.WriteLine("Informe a primeira nota: ");
                            notaM1 = int.Parse(Console.ReadLine());
                            if (exercicio.Validar(notaM1) == false)
                            {
                                Console.WriteLine("A nota informada é inválida!");
                            }
                        } while (exercicio.Validar(notaM1) == false);

                        do
                        {
                            Console.WriteLine("Informe a segunda nota: ");
                            notaM2 = int.Parse(Console.ReadLine());
                            if (exercicio.Validar(notaM2) == false)
                            {
                                Console.WriteLine("A nota informada é inválida!");
                            }
                        } while (exercicio.Validar(notaM2) == false);

                        if (exercicio.MediaProva(notaM1, notaM2) >= 7)
                        {
                            Console.WriteLine("O aluno está aprovado!");
                        }
                        else
                        {
                            Console.WriteLine("O aluno está reprovado!");
                        }
                        break;
                    case 14:
                        double med1;
                        double med2;
                        double med3;
                        do
                        {
                            Console.WriteLine("Informe a  1° medida: ");
                            med1 = int.Parse(Console.ReadLine());
                            if (exercicio.Validar(med1) == false)
                            {
                                Console.WriteLine("A medida informada é inválida!");
                            }
                        } while (exercicio.Validar(med1) == false);

                        do
                        {
                            Console.WriteLine("Informe a  2° medida: ");
                            med2 = int.Parse(Console.ReadLine());
                            if (exercicio.Validar(med2) == false)
                            {
                                Console.WriteLine("A medida informada é inválida!");
                            }
                        } while (exercicio.Validar(med2) == false);

                        do
                        {
                            Console.WriteLine("Informe a  3° medida: ");
                            med3 = int.Parse(Console.ReadLine());
                            if (exercicio.Validar(med3) == false)
                            {
                                Console.WriteLine("A medida informada é inválida!");
                            }
                        } while (exercicio.Validar(med3) == false);

                        if ((med1 == med2) && (med1 == med3))
                        {
                            Console.WriteLine("O triângulo é equilátero!");
                        }
                        else if ((med1 == med2) || (med1 == med3) || (med2 == med3))
                        {
                            Console.WriteLine("O triângulo é  isósceles!");
                        }
                        else
                        {
                            Console.WriteLine("O triângulo é escaleno");
                        }
                        break;
                    case 15:
                        double numPN;
                        Console.WriteLine("Digite um número: ");
                        numPN = double.Parse(Console.ReadLine());
                        if(exercicio.NegativoPositivo(numPN) == true)
                        {
                            Console.WriteLine("O número " + numPN + " é POSITIVO!");
                        }
                        else if (exercicio.NegativoPositivo(numPN) == false)
                        {
                            Console.WriteLine("O número " + numPN + " é NEGATIVO!");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é válida!");
                        break;
                }//fim do escolha
            } while (ConsultarOpcao != 0);//Fim do While
        }//fim do método

    }//Fim da classe
}//Fim do projeto
