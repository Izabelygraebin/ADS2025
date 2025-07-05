int opcao;

do
{
    Console.Clear();
    Console.WriteLine("\n>>> MENU DE PROGRAMAS <<<\n");
    Console.WriteLine("1 - Contagem Regressiva");
    Console.WriteLine("2 - Somatório de Números");
    Console.WriteLine("3 - Números Pares de 1 a 500");
    Console.WriteLine("4 - Média de Idades");
    Console.WriteLine("5 - Tabuada Interativa");
    Console.WriteLine("6 - Fatorial de um Número");
    Console.WriteLine("7 - Números Ímpares de 1 a 100");
    Console.WriteLine("8 - Soma dos Quadrados");
    Console.WriteLine("9 - Média Condicional");
    Console.WriteLine("10 - SAIR");
    Console.Write("\nEscolha uma opção: ");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            char repetir1;
            do
            {
                Console.Clear();
                int regressao = 10;
                int temp = 1000;
                while (regressao >= 1)
                {
                    Console.WriteLine($"Falta {regressao}");
                    Thread.Sleep(temp);
                    Console.Beep();
                    regressao--;
                    temp -= 100;
                }
                Console.WriteLine("Tá pegando FOGOO, bixo !!!!");

                Console.Write("\nDeseja repetir esta atividade? (s = sim / outra tecla = menu): ");
                repetir1 = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.Clear();

            } while (repetir1 == 's' || repetir1 == 'S');
            break;

        case 2:
            char repetir2;
            do
            {
                int armazena = 1;
                int soma = 0;
                int cont = 1;

                Console.Clear();
                while (armazena != 0)
                {

                    Console.Write($"Informe o {cont} ° numero inteiro postivo ou zero para sair:  ");
                    armazena = Convert.ToInt32(Console.ReadLine());

                    if (armazena != 0)
                    {
                        soma = soma + armazena;
                        cont++;
                    }
                }

                Console.WriteLine($"A soma dos números é {soma}");
                Console.Write("\nDeseja repetir esta atividade? (s = sim / outra tecla = menu): ");
                repetir2 = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.Clear();

            } while (repetir2 == 's' || repetir2 == 'S');
            break;

        case 3:
            char repetir3;
            do
            {
                int numero_par_500 = 1;
                int cont_par = 1;

                Console.Clear();
                Console.WriteLine("Lista de todos os números pares de 1 a 500:\n");

                while (numero_par_500 <= 500)
                {
                    if (numero_par_500 % 2 == 0)
                    {
                        Console.WriteLine($"O {cont_par}° número PAR é {numero_par_500}");
                        cont_par++;
                        Thread.Sleep(10);
                    }

                    numero_par_500++;
                }
                Console.Write("\nDeseja repetir esta atividade? (s = sim / outra tecla = menu): ");
                repetir3 = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.Clear();

            } while (repetir3 == 's' || repetir3 == 'S');
            break;

        case 4:
            char repetir4;
            do
            {
                double idade = 0;
                double soma = 0;
                int qtde = 0;
                double media = 0;

                Console.Clear();
                while (idade >= 0)
                {
                    Console.Write($"Informe a {qtde + 1} ª idade ou um número NEGATIVO para SAIR: ");
                    idade = Convert.ToDouble(Console.ReadLine());

                    if (idade >= 0)
                    {
                        soma = soma + idade;
                        qtde++;
                    }

                }
                if (qtde > 0)
                {
                    media = soma / qtde;
                    Console.WriteLine($"A média de todas as {qtde}ª  idades é {media:F2}");
                }
                else
                {
                    Console.WriteLine("Nenhuma idade válida foi informada.");
                }
                Console.Write("\nDeseja repetir esta atividade? (s = sim / outra tecla = menu): ");
                repetir4 = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.Clear();

            } while (repetir4 == 's' || repetir4 == 'S');
            break;

        case 5:
            char repetir5;

                do
                {
                    int num = 0;
                    int multi = 0;
                    int contador = 1;

                    Console.Clear();
                    Console.Write($"Qual tabuada você quer: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"Até qual índice:  ");
                    multi = Convert.ToInt32(Console.ReadLine());

                    do
                    {
                        Console.WriteLine($"{num} x {contador} = {num * contador}");
                        contador++;
                    } while (contador <= multi);

                    Console.Write("\nDeseja repetir esta atividade? (s = sim / outra tecla = menu): ");
                    repetir5 = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    Console.Clear();

                } while (repetir5 == 's' || repetir5 == 'S');
            break;

        case 6:
            char repetir6;
            do
            {
                int numero = 0;
                int fatorial = 1;
                int contador_fator = 1;

                Console.Clear();
                Console.Write("Digite um número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero < 0)
                {
                    Console.WriteLine("Fatorial não existe para números negativos.");
                }
                else if (numero == 0)
                {
                    Console.WriteLine("0! = 1 ");
                }
                else
                {
                    while (contador_fator <= numero)
                    {
                        fatorial *= contador_fator;
                        contador_fator++;
                    }
                    Console.WriteLine($"O fatorial de {numero} é {fatorial}");
                }
                Console.Write("\nDeseja repetir esta atividade? (s = sim / outra tecla = menu): ");
                repetir6 = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.Clear();

            } while (repetir6 == 's' || repetir6 == 'S');
            break;

        case 7:
            char repetir7;
            do
            {
                int numero_100_Impar = 1;
                int cont_Impares = 0;

                Console.Clear();
                while (numero_100_Impar <= 100)
                {
                    if (numero_100_Impar % 2 != 0)
                    {
                        Console.WriteLine($"  {numero_100_Impar}");
                        cont_Impares++;
                    }
                    numero_100_Impar++;
                    Thread.Sleep(25);

                    
                }
                Console.WriteLine($"\n>>>>> Esses são {cont_Impares} numeros Impares no intervalo  de 1 a 100 <<<<<<");

                Console.Write("\nDeseja repetir esta atividade? (s = sim / outra tecla = menu): ");
                repetir7 = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.Clear();

            } while (repetir7 == 's' || repetir7 == 'S');
            break;

        case 8:
            char repetir8;
            do
            {
                int num_inte = 0;
                int quadrado = 0;
                int soma_qua = 0;
                int contador = 1;

                Console.Clear();
                do
                {
                    
                    Console.Write($"Informe o {contador}° numero:  ");
                    num_inte = Convert.ToInt32(Console.ReadLine());

                    if (num_inte >= 0)
                    {
                        quadrado = num_inte * num_inte;
                        soma_qua += quadrado;
                        contador++;
                    }

                } while (num_inte > 0);

                Console.WriteLine($"A soma dos quadrados desses {contador} é: {soma_qua}");

                Console.Write("\nDeseja repetir esta atividade? (s = sim / outra tecla = menu): ");
                repetir8 = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.Clear();

            } while (repetir8 == 's' || repetir8 == 'S');
            break;

        case 9:
            char repetir9;
            do
            {
                double nota_max_10 = 1;
                double soma_nota = 0;
                double media_nota = 0;
                int qtde_nota = 0;

                Console.Clear();
                while ((nota_max_10 >= 0) && (nota_max_10 <= 10))
                {
                    Console.Write($"Informe a {qtde_nota + 1}ª nota: "); // Num sei é uma gambiarra(+1), mas  foi o que consegui e funciona ＼（〇_ｏ）／
                    nota_max_10 = Convert.ToDouble(Console.ReadLine());

                    if ((nota_max_10 >= 0) && (nota_max_10 <= 10))
                    {
                        soma_nota += nota_max_10;
                        qtde_nota++;
                    }
                }

                if (qtde_nota > 0)
                {
                    media_nota = soma_nota / qtde_nota;
                    Console.WriteLine($"A média das {qtde_nota} notas válidas é {media_nota:F2}");
                }
                else
                {
                    Console.WriteLine("Nenhuma nota válida foi inserida.");
                }

                Console.Write("\nDeseja repetir esta atividade? (s = sim / outra tecla = menu): ");
                repetir9 = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.Clear();

            } while (repetir9 == 's' || repetir9 == 'S');
            break;

        case 10:
            Console.Clear();
            Console.WriteLine("\nSaindo do programa...");
            Console.WriteLine("\nObrigada por Jogar ]~(^_^)~*...");
            break;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }

    if (opcao != 10)
    {
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

} while (opcao != 10);
Console.ReadKey();