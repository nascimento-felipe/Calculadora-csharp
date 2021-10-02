using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int operacaoEscolhida;

                do
                {

                    Calculos c1 = new Calculos();

                    Console.WriteLine("Escolha uma operação:\n 1. Soma\n 2. Diferença\n 3. Multiplicação\n 4. Divisão\n -1. Sair ");
                    operacaoEscolhida = int.Parse(Console.ReadLine());

                    if (operacaoEscolhida != -1)
                    {

                    
                    Console.WriteLine("------------------------------------------------");

                        switch (operacaoEscolhida)
                        {
                            case 1:
                                Console.WriteLine("\nDigite o valor de a: ");
                                c1.setA(float.Parse(Console.ReadLine()));

                                Console.WriteLine("Digite o valor de b: ");
                                c1.setB(float.Parse(Console.ReadLine()));


                                Console.WriteLine($"O valor da soma de {c1.getA()} + {c1.getB()} é: {c1.Soma()}");
                                break;

                            case 2:

                                Console.WriteLine("\nDigite o valor de a: ");
                                c1.setA(float.Parse(Console.ReadLine()));

                                Console.WriteLine("Digite o valor de b: ");
                                c1.setB(float.Parse(Console.ReadLine()));


                                Console.WriteLine($"O valor da diferença de {c1.getA()} - {c1.getB()} é: {c1.Diferenca()}");
                                break;

                            case 3:

                                Console.WriteLine("\nDigite o valor de a: ");
                                c1.setA(float.Parse(Console.ReadLine()));

                                Console.WriteLine("Digite o valor de b: ");
                                c1.setB(float.Parse(Console.ReadLine()));

                                Console.WriteLine($"O valor da multiplicação de {c1.getA()} * {c1.getB()} é: {c1.Multiplicacao()}");

                                break;

                            case 4:

                                Console.WriteLine("\nDigite o valor de a: ");
                                c1.setA(float.Parse(Console.ReadLine()));

                                Console.WriteLine("Digite o valor de b: ");
                                c1.setB(float.Parse(Console.ReadLine()));

                                if (c1.getB() == 0)
                                {
                                    throw new DivideByZeroException();
                                }

                                Console.WriteLine($"O valor da divisão de {c1.getA()} / {c1.getB()} é: {c1.Divisao()}");

                                break;

                            default:
                                Console.WriteLine("Por favor, digite um valor válido!");
                                break;
                        }

                        Console.WriteLine("------------------------------------------------");
                    }

                } while (operacaoEscolhida != -1);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possível dividir por 0!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exceção lançada. Mensagem: {e.Message}");
            }

        }
    }
}
