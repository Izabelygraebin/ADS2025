int opcao;
do
{
    Console.Clear();
    Console.WriteLine("Menu de Exercícios:");
    Console.WriteLine("1 – Fatorial");
    Console.WriteLine("2 – Primos e Números Redondos");
    Console.WriteLine("3 – Números com resto 5 (divisão por 11)");
    Console.WriteLine("4 – Soma de Pares/Ímpares");
    Console.WriteLine("5 – Médias em Turma");
    Console.WriteLine("6 – Pesquisa Física");
    Console.WriteLine("7 - Sair");
    Console.Write("Escolha uma opção: ");
    opcao =Convert.ToInt32(Console.ReadLine());

    switch(opcao)
    {
        case 1:
            {
                int num;
                int fatorial = 1;
                Console.Clear();
                Console.Write("Informe um número para calcular o fatorial: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num < 0)
                {
                    Console.WriteLine("Número inválido. O fatorial só é definido para números não negativos.");

                }
                else if (num == 0 || num == 1)
                {
                    Console.WriteLine($"O fatorial de {num} é 1.");

                }
                else
                {
                    for (int i = num; i > 0; i--)
                    {
                        fatorial = fatorial * i;
                    }

                    Console.WriteLine($"O fatorial de {num} é {fatorial}.");
                }
                Console.WriteLine("\nPressione qualquer tecla para voltar ao MENU...");    
                Console.ReadKey();
            }
            break;
        case 2:
            {
                Random Ale = new Random();
                int ContGlobal = 1;

                Console.Clear();
                Console.Write("===== Gerando 50 números aleatórios entre 1 e 300 =====\n");

                Console.Write("Analisando");
                for (int k = 0; k < 3; k++) 
                {
                    Console.Write(".");     
                    Thread.Sleep(700);
                    Console.Beep();
                }
                Console.WriteLine("\n");   

                for (int i = 0; i < 50; i++)


                {
                    Thread.Sleep(35);
                    int a = 0;
                    int num = Convert.ToInt32(Ale.Next(1, 301));
                    Console.Write($"\n{ContGlobal}° :");
                    for (int j = 1; j <= num; j++)
                    {
                        if (num % j == 0)
                        {
                            a++;
                        }
                    }
                    if (a == 2)
                    {
                        Console.WriteLine($" O número {num} é Primo.\n");
                    }
                    else if (num % 10 == 0)
                    {
                        Console.WriteLine($" O número {num} é Redondo.\n");
                    }
                    else
                    {
                        Console.WriteLine($" O número {num} não é primo nem redondo.\n");
                    }

                    ContGlobal++;
                }
                Console.WriteLine("Pressione qualquer tecla para voltar ao MENU...");
                Console.ReadKey();
            }

            break;
        case 3:
            {
                int num_39999;
                int cont_11_5 = 0;

                Console.WriteLine("===== Números entre 1 e 3999 que, divididos por 11, dão resto 5 =====\n");
                Console.Write("Analisando");
                for (int k = 0; k < 3; k++)
                {
                    Console.Write(".");
                    Thread.Sleep(700);
                    Console.Beep(600,600);
                }
                Console.WriteLine("\n");

                for (int i = 1; i <= 3999; i++)
                {
                    num_39999 = i % 11;
                    if (num_39999 == 5)
                    {
                        Console.Write($"{i},");

                        cont_11_5++;
                    }

                }
                Console.WriteLine($"\n\nEsses são os {cont_11_5} que divididos por 11 de dão resto 5.");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao MENU...");
                Console.ReadKey();
            }

            break;
        case 4:
            {
                int num;
                int somaPares = 0;
                int somaImpares = 0;
                int cont_PI = 0;

                Console.Clear(); 
                Console.Write("Soma dos números pares maiores que 100 e dos ímpares menores que 500\n");
                Console.Write("Obs.: O programa encerra quando um número maior que 1000 é informado.\n");
                do
                {
                    
                    cont_PI++;
                    Console.Write($"\nDigite o {cont_PI}° número: ");
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num <= 1000)
                    {
                        if (num % 2 == 0 && num > 100)
                            somaPares += num;

                        else if (num % 2 != 0 && num < 500)
                            somaImpares += num;
                    }
                    else
                    {
                        Console.WriteLine("\nNúmero maior que 1000 informado. Encerrando o programa.");
                    }

                } while (num <= 1000);

                Console.WriteLine($"\nSoma dos números pares maiores que 100: {somaPares}");
                Console.WriteLine($"Soma dos números ímpares menores que 500: {somaImpares}");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao MENU...");
                Console.ReadKey();
            }

            break;
        case 5:
            {
                double altura = 0;
                double anos = 0;
                double soma_altura = 0;
                double soma_idade = 0;
                int cont_altura = 0;
                int cont_idade = 0;

                Console.Clear();
                for (int i = 0; i < 45; i++)
                {
                    // Validação da altura
                    do
                    {
                        Console.Write($"Informe a {i + 1}ª  ALTURA(ex.:1,80): ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        if (altura < 0 || altura > 3)
                        {
                            Console.WriteLine("Altura inválida! Digite um valor entre 0 e 3 metros.");
                        }
                    } while (altura < 0 || altura > 3);
                    do
                    {
                        Console.Write($"Informe a {i + 1}ª IDADE: ");
                        anos = Convert.ToDouble(Console.ReadLine());
                        if (anos < 0 || anos > 120)
                        {
                            Console.WriteLine("Idade inválida! Digite um valor entre 0 e 120 anos.");
                        }
                    } while (anos < 0 || anos > 120);

                    Console.WriteLine("----------------------------");

                    if (altura < 1.60)
                    {
                        soma_altura += altura;
                        cont_altura++;
                    }
                    if (anos > 18)
                    {
                        soma_idade += anos;
                        cont_idade++;
                    }
                }
                Console.WriteLine("\n===== Resultados =====\n");  
                
                if (cont_altura > 0)
                    Console.WriteLine($"A média das alturas (< 1.60 m) é: {soma_altura / cont_altura:F2}");
                else
                    Console.WriteLine("Nenhuma altura menor que 1.60 m foi informada.");

                if (cont_idade > 0)
                    Console.WriteLine($"A média das idades (> 18 anos) é: {soma_idade / cont_idade:F2}");
                else
                    Console.WriteLine("Nenhuma idade maior que 18 anos foi informada.");

                Console.WriteLine("\nPressione qualquer tecla para voltar ao MENU...");
                Console.ReadKey();
            }
            break;
        case 6:
            {

                int repetir = 0;

                char sexo;
                int cont_sexoF = 0;
                int cont_sexoM = 0;
                char olhos;
                int cont_olhosA = 0;
                int cont_olhosV = 0;
                int cont_olhosC = 0;
                char cabelhos;
                int cont_cabelhosL = 0;
                int cont_cabelhosC = 0;
                int cont_cabelhosP = 0;
                double idade = 0;
                int cont_idade = 0;
                double maior_idade = 0;
                double menor_idade_mulher = 121;
                int cont_idade_F_20_30 = 0;
                double soma_idade_PC = 0;
                int cont_idade_PC = 0;
                int cont_olhosV_cabelosL = 0;

                Console.Clear();
                do
                {
                    do
                    {
                        Console.Clear();
                        Console.Write("Informe a seu sexo (M ou F):  ");//masculino e feminino
                        sexo = Convert.ToChar(Console.ReadLine());

                        if (sexo == 'F' || sexo == 'f')
                        {
                            cont_sexoF++;
                        }
                        else if (sexo == 'M' || sexo == 'm')
                        {
                            cont_sexoM++;
                        }
                        else
                        {
                            Console.WriteLine("Sexo inválido. Por favor, informe M ou F.");
                        }
                    } while (sexo != 'M' && sexo != 'm' && sexo != 'F' && sexo != 'f');

                    do
                    {
                        Console.Write("Informe a cor dos olhos (A - azuis, V - verdes, C - castanhos): ");
                        olhos = Convert.ToChar(Console.ReadLine());

                        if (olhos == 'A' || olhos == 'a')
                        {
                            cont_olhosA++;
                        }
                        else if (olhos == 'V' || olhos == 'v')
                        {
                            cont_olhosV++;
                        }
                        else if (olhos == 'C' || olhos == 'c')
                        {
                            cont_olhosC++;
                        }
                        else
                        {
                            Console.WriteLine("Cor de olhos inválida. Por favor, informe A, V ou C.");
                        }

                    } while (olhos != 'A' && olhos != 'a' && olhos != 'V' && olhos != 'v' && olhos != 'C' && olhos != 'c');

                    do
                    {
                        Console.Write("Informe a cor dos cabelos (L - Loiros, C - Castanhos, P - Pretos): ");
                        cabelhos = Convert.ToChar(Console.ReadLine());

                        if (cabelhos == 'L' || cabelhos == 'l')
                        {
                            cont_cabelhosL++;
                        }
                        else if (cabelhos == 'C' || cabelhos == 'c')
                        {
                            cont_cabelhosC++;
                        }
                        else if (cabelhos == 'P' || cabelhos == 'p')
                        {
                            cont_cabelhosP++;
                        }
                        else
                        {
                            Console.WriteLine("Cor dos cabelos inválida. Por favor, informe L, C ou P.");
                        }

                    } while (cabelhos != 'L' && cabelhos != 'l' && cabelhos != 'C' && cabelhos != 'c' && cabelhos != 'P' && cabelhos != 'p');


                    do
                    {
                        Console.Write("Informe a idade : ");
                        idade = Convert.ToDouble(Console.ReadLine());
                        {
                            if ((idade > 0) && (idade <= 120))
                            {
                                cont_idade++;

                                if (idade > maior_idade)
                                {
                                    maior_idade = idade;
                                }
                                if (sexo == 'F' || sexo == 'f')
                                {
                                    if (idade >= 20 && idade <= 30)
                                    {
                                        cont_idade_F_20_30++;
                                    }
                                    if (idade < menor_idade_mulher)
                                    {
                                        menor_idade_mulher = idade;
                                    }
                                }
                                if ((cabelhos == 'P' || cabelhos == 'p') && (olhos == 'C' || olhos == 'c'))
                                {
                                    soma_idade_PC += idade;
                                    cont_idade_PC++;
                                }
                                if ((cabelhos == 'L' || cabelhos == 'l') && (olhos == 'V' || olhos == 'v'))
                                {
                                    cont_olhosV_cabelosL++;
                                }
                            }

                            else
                            {
                                Console.WriteLine("Idade inválida. Por favor, informe uma maior que 0 e <= a 120.");
                            }
                        }
                    } while ((idade < 0) || (idade > 120));

                    Console.Write("\nDeseja realizar outra entrevista? Digite 0 para sim ou um número negativo para encerrar: ");
                    repetir = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                } while (repetir == 0);
                
                Console.WriteLine("\n===== Resultados =====\n");


                if (cont_idade > 0)
                {
                    Console.WriteLine($"A maior idade informada foi: {maior_idade} anos");
                }
                else
                {
                    Console.WriteLine("Nenhuma idade foi registrada.");
                }

                if (cont_sexoF > 0)
                {
                    Console.WriteLine($"A menor idade informada entre as mulheres foi: {menor_idade_mulher} anos");
                }
                else
                {
                    Console.WriteLine("Nenhuma mulher foi registrada.");
                }

                if (cont_idade_F_20_30 > 0)
                {
                    Console.WriteLine($"A quantidade de mulheres com idade entre 20 e 30 anos: {cont_idade_F_20_30}");
                }
                else
                {
                    Console.WriteLine("Nenhuma mulher com idade entre 20 e 30 anos foi registrada.");
                }

                if (cont_idade_PC > 0)
                {
                    Console.WriteLine($"Média de idade de indivíduos com cabelos pretos e olhos castanhos: {soma_idade_PC / cont_idade_PC:F2} anos");
                }
                else
                {
                    Console.WriteLine("Nenhum indivíduo com cabelos pretos e olhos castanhos foi registrado.");
                }

                if (cont_olhosV_cabelosL > 0)
                {
                    Console.WriteLine($"Quantidade de indivíduos com olhos verdes e cabelos louros: {cont_olhosV_cabelosL}");
                }
                else
                {
                    Console.WriteLine("Nenhum indivíduo com olhos verdes e cabelos louros foi registrado.");
                }
                Console.WriteLine("\nPressione qualquer tecla para voltar ao MENU...");
                Console.ReadKey();
            }
            break;
        case 7:
            Console.WriteLine("Saindo do programa...");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
} while (opcao != 7);
Console.ReadKey();