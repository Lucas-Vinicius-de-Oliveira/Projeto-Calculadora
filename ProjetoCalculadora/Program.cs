using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculadora
{
    internal class Program                                                                      
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair };
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair) //enquanto o usuario nao(!) escolher sair, exiba o menu
            {
                Console.WriteLine("Seja bem vindo ao CALC, Selecione uma das opções: ");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisao\n4-multiplicação\n5-Potencia\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine()); //estou fazendo um cast de menu botando Menu em parentese

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;

                    case Menu.Subtracao:
                        Subtração();
                        break;

                    case Menu.Divisao:
                        Divisao();
                        break;

                    case Menu.Multiplicacao:
                        Multi();
                        break;

                    case Menu.Potencia:
                        Potencia();
                        break;

                    case Menu.Raiz:
                        Raiz();
                        break;

                    case Menu.Sair:
                        escolheuSair = true;
                        break;

                }

                Console.Clear();

            }



        }

        #region Função Soma
        static void Soma()
        {
            Console.WriteLine("Soma de dois numeros! ");
            Console.WriteLine("digite o primeiro numero :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($" o resultado e:{resultado}"); //isso e usado interpolação, usando $ no inicio junto com colchetes
            Console.WriteLine("Aperte enter para voltar ao menu");
            Console.ReadLine();
        }
        #endregion

        #region Função Subtração
        static void Subtração()
        {
            Console.WriteLine("Subtração de dois numeros! ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine(" o resultado e: " + resultado);
            Console.WriteLine("Aperte enter para voltar ao menu");
            Console.ReadLine();
        }
        #endregion

        #region Função Divisao

        static void Divisao()
        {
            Console.WriteLine("Divisao de dois numeros! ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b;  // e necessario fazer isso para que possa vir o resultado correto, sempre que for fazer divisao no c# e necessario colocar dentro de float
            Console.WriteLine(" o resultado e: " + resultado);
            Console.WriteLine("Aperte enter para voltar ao menu");
            Console.ReadLine();
        }
        #endregion

        #region Função multiplicação

        static void Multi()
        {
            Console.WriteLine("Multiplicação de dois numeros! ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine(" o resultado e: " + resultado);
            Console.WriteLine("Aperte enter para voltar ao menu");
            Console.ReadLine();
        }
        #endregion

        #region Função Potencia

        static void Potencia()
        {
            Console.WriteLine("potencia de um numero! ");
            Console.WriteLine("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expo);
            Console.WriteLine(" o resultado e: " + resultado);
            Console.WriteLine("Aperte enter para voltar ao menu");
            Console.ReadLine();
        }
        #endregion

        #region Função Raiz Quadrada

        static void Raiz()
        {
            Console.WriteLine("raiz quadrada de um numero! ");
            Console.WriteLine("Digite o numero: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine(" o resultado e: " + resultado);
            Console.WriteLine("Aperte enter para voltar ao menu");
            Console.ReadLine();
        }
        #endregion
    }
}
