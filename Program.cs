using System;
using System.Collections.Generic;

namespace LoginFormConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "";
            string password = "";

            bool loggedIn = false;
            while (!loggedIn)
            {
                Console.ForegroundColor = ConsoleColor.Green; // Definir a cor do texto como verde
                Console.WriteLine(" ▄▄▄▄▄▄▄ ▄▄▄▄▄▄▄ ▄▄   ▄▄    ▄▄   ▄▄ ▄▄▄ ▄▄    ▄ ▄▄▄▄▄▄  ▄▄▄▄▄▄▄");
                Console.WriteLine("█  ▄    █       █  █▄█  █  █  █ █  █   █  █  █ █      ██       █");
                Console.WriteLine("█ █▄█   █    ▄▄▄█       █  █  █▄█  █   █   █▄█ █  ▄    █   ▄   █");
                Console.WriteLine("█       █   █▄▄▄█       █  █       █   █       █ █ █   █  █ █  █");
                Console.WriteLine("█  ▄   ██    ▄▄▄█       █  █       █   █  ▄    █ █▄█   █  █▄█  █");
                Console.WriteLine("█ █▄█   █   █▄▄▄█ ██▄██ █   █     ██   █ █ █   █       █       █");
                Console.WriteLine("█▄▄▄▄▄▄▄█▄▄▄▄▄▄▄█▄█   █▄█    █▄▄▄█ █▄▄▄█▄█  █▄▄█▄▄▄▄▄▄██▄▄▄▄▄▄▄█");
                // Logo da empresa 
                Console.WriteLine(@"                                                                                                                                                                                                      
                                     ........                                    
                            ..++::::::::::::::::::..                            
                        --::::::::::::::::::::::::::::--                        
                      ::::::::::::::::::::::::::::::::::::                      
                    ::::::::::::::::::::::::::::::::::::::::..                  
                ..::::::::::::::::::::::::::::::::::::::::::::..                
                ::::::::::::::::::::::----::::::::::::::::::::::                
              ::::::::::::::::::::::        ::::::::::::::::::::::              
            ::::::::::::::::::::    --          ::::::::::::::::::::            
            ::::::::::::::::..  ....              ..::::::::::::::::            
          --::::::::::::::    ::                      ::::::::::::::::          
          ::::::::::::::++  ..      ++    ..          mm::::::::::::::          
          ::::::::::::::..            ..    ..        --++::::::::::::          
        --::::::::::::::  ++          ----              ++++::::::::::--        
        --::::::::::::::  ++          ++++              ++++++::::::::::        
        ::::::::::::::..  ..                            ..++++mm::::::::        
        ::::::::::::::  ..          ::    ..              ++++++++::::::        
        ::::::::::::::  ++                                ++++++++++::::        
        --::::::::::    ++                                  ++++++++++--        
        ..::::::::::::++--                ..--++++++mmmm++++++++++++++..        
          ::::::::::::::..                            ..++++++++++++++          
          ::::::::::::::..      ::      --    ::      ..++++++++++++++          
          ..::::::::::::..      ::      ::    ::      ..++++++++++++--          
            ::::::::::::..      ::      ..    ::      ..++++++++++++            
            ..::::::::::..      ::      ..    ::      ..++++++++++..            
              ::::::::::::++++++++++mm++++++mm++mmmm++++++++++++mm              
                ::::::::::::++++++++++++++++++++++++++++++++++++                
                  ::::::::::::++++++++++++++++++++++++++++++++                  
                    ::::::::::::++++++++++++++++++++++++++++                    
                      ..::::::::::++++++++++++++++++mm++::                      
                          --::::::::++++++++++++++++::                          
                                --++::++++++mm::                                ");
                Console.ResetColor(); // Resetar a cor para o padrão
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Por favor, insira seu usario e senha abaixo!");
                Console.WriteLine("--------------------------------------------");
                // Solicitar nome de usuário
                Console.Write("Nome de usuário: ");
                username = Console.ReadLine();

                // Solicitar senha
                Console.Write("Senha: ");
                password = Console.ReadLine();               
                loggedIn = CheckCredentials(username, password);      
                if (!loggedIn)
                {
                    Console.ForegroundColor = ConsoleColor.Red; // Destaca a mensagem de erro em vermelho
                    Console.WriteLine("Nome de usuário ou senha incorretos. Por favor, tente novamente.");
                    Console.ResetColor(); // Resetar a cor para o padrão
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey(); // Espera até que o usuário pressione uma tecla para continuar
                    Console.Clear(); // Limpar a tela antes de solicitar as credenciais novamente

                }
            }

            Console.WriteLine("Login realizado com sucesso!");

            // Exibir o menu
            DisplayMenu();

            // Aguardar entrada do usuário e redirecionar para a página correspondente
            string option;
            while (true)
            {
                Console.Write("Digite a opção desejada: ");
                option = Console.ReadLine();

                switch (option.ToLower())
                {
                    case "1":
                        DisplayProducts();
                        break;
                    case "2":
                        DisplayClientes();
                        break;
                    case "3":
                        DisplayFornecedores();
                        break;
                    case "4":
                        DisplayAjuda();
                        break;
                    case "5":
                        DisplayPerfil();
                        break;
                    case "6":
                        Console.WriteLine("Saindo do programa...");
                        return; // Termina a execução do programa
                    default:
                        Console.ForegroundColor = ConsoleColor.Yellow; // Destaca a mensagem de erro em amarelo
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                        Console.ResetColor(); // Resetar a cor para o padrão
                        break;
                }
            }
        }

        // Método para verificar as credenciais (simulação simples)
        private static bool CheckCredentials(string username, string password)
        {
            // Implementar lógica real de verificação de credenciais aqui
            // Neste exemplo, simulamos que o nome de usuário e a senha são "admin"
            return (username == "admin" && password == "admin");
        }

        // Método para exibir o menu
        private static void DisplayMenu()
        {
            Console.Clear(); // Limpar a tela

            Console.ForegroundColor = ConsoleColor.Green; // Definir a cor do texto como verde
            Console.WriteLine(" ▄▄   ▄▄ ▄▄▄▄▄▄▄ ▄▄    ▄ ▄▄   ▄▄");
            Console.WriteLine("█  █▄█  █       █  █  █ █  █ █  █");
            Console.WriteLine("█       █    ▄▄▄█   █▄█ █  █ █  █");
            Console.WriteLine("█       █   █▄▄▄█       █  █▄█  █");
            Console.WriteLine("█       █    ▄▄▄█  ▄    █       █");
            Console.WriteLine("█ ██▄██ █   █▄▄▄█ █ █   █       █");
            Console.WriteLine("█▄█   █▄█▄▄▄▄▄▄▄█▄█  █▄▄█▄▄▄▄▄▄▄█");
            Console.ResetColor(); // Resetar a cor para o padrão

            Console.WriteLine();

            // Exibir opções de menu
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1. Produtos");
            Console.WriteLine("2. Clientes");
            Console.WriteLine("3. Fornecedores");
            Console.WriteLine("4. Ajuda");
            Console.WriteLine("5. Perfil");
            Console.WriteLine("6. Sair");
            Console.WriteLine("---------------------------------");
        }

        // Método para exibir os produtos 
        private static void DisplayProducts()
        {
            Console.Clear(); // Limpar a tela

            // Exibir mensagem de boas-vindas em verde
            Console.WriteLine("--------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Seja bem-vindo à página de Produtos do Sanja Farm!");
            Console.ResetColor(); // Resetar a cor para o padrão
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();

            // Exibir lista de produtos
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Escolha um dos produtos abaixo:");
            Console.ResetColor(); // Resetar a cor para o padrão
            Console.WriteLine();


            Console.WriteLine("1. Hortaliças");
            Console.WriteLine("2. Frutas");
            Console.WriteLine("3. Ervas Medicinais");
            Console.WriteLine("4. Plantas Aromáticas");
            Console.WriteLine("5. Voltar ao Menu Principal");
            Console.WriteLine("");

            // Aguardar entrada do usuário
            Console.Write("Digite o número correspondente à opção desejada: ");
            string option = Console.ReadLine();

            // Verificar a opção escolhida
            switch (option)
            {
                case "1":
                    DisplayHortalicas();
                    break;
                case "2":
                    DisplayFrutas();
                    break;
                case "3":
                    DisplayErvasMedicinais();
                    break;
                case "4":
                    DisplayPlantasAromaticas();
                    break;
                case "5":
                    DisplayMenu();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Yellow; // Destaca a mensagem de erro em amarelo
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    Console.ResetColor(); // Resetar a cor para o padrão
                    DisplayProducts(); // Mostrar o menu de produtos novamente
                    break;
            }
        }

        private static void DisplayHortalicas()
        {
            Console.Clear(); // Limpar a tela

            // Exibir mensagem de boas-vindas em verde
            Console.WriteLine("----------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bem-vindo à seção de Hortaliças do Sanja Farm!");
            Console.ResetColor(); // Resetar a cor para o padrão
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();

            // Descrição geral das hortaliças
            Console.WriteLine("Nossas hortaliças são cultivadas de forma orgânica e frescas, trazendo o melhor sabor e qualidade para sua mesa.");
            Console.WriteLine("Oferecemos uma variedade de hortaliças frescas e saudáveis, cultivadas com cuidado e atenção.");
            Console.WriteLine();

            // Exibir opções específicas para tipos de alface
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Tipos de Alface:");
            Console.ResetColor(); // Resetar a cor para o padrão
            Console.WriteLine();

            Console.WriteLine("1. Alface Lisa");
            Console.WriteLine("2. Alface Americana");
            Console.WriteLine("3. Alface Crespa");
            Console.WriteLine("4. Alface Mimosa");
            Console.WriteLine("5. Alface Romana");
            Console.WriteLine("0. Voltar ao Menu Principal");
            Console.WriteLine("");

            // Aguardar entrada do usuário para escolher uma opção
            Console.Write("Digite o número correspondente ao tipo de alface ou 0 para voltar: ");
            string input = Console.ReadLine();

            // Direcionar para a função correspondente com base na escolha do usuário
            switch (input)
            {
                case "1":
                    DisplayAlfaceLisa();
                    break;
                case "2":
                    DisplayAlfaceAmericana();
                    break;
                case "3":
                    DisplayAlfaceCrespa();
                    break;
                case "4":
                    DisplayAlfaceMimosa();
                    break;
                case "5":
                    DisplayAlfaceRomana();
                    break;
                case "0":
                    DisplayMenu();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Yellow; // Destaca a mensagem de erro em amarelo
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    Console.ResetColor(); // Resetar a cor para o padrão
                    DisplayHortalicas(); // Redirecionar para a lista de hortaliças novamente
                    break;
            }
        }

        // Funções para exibir informações sobre os diferentes tipos de alface
        private static void DisplayAlfaceLisa(string id = "", string fornecedor = "", string dataColeheita = "", string estoque = "", string vendido = "", string paraVenda = "", string vendaMes = "", string vendasSemana = "")
        {
            Console.Clear(); // Limpar a tela

            // Exibir mensagem de boas-vindas em verde
            Console.WriteLine("---------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bem-vindo à seção de Alface Lisa!");
            Console.ResetColor(); // Resetar a cor para o padrão
            Console.WriteLine("---------------------------------");
            Console.WriteLine();

            // Descrição da alface lisa
            Console.WriteLine("A alface lisa é uma variedade de alface de folhas macias e lisas.");
            Console.WriteLine("É muito utilizada em saladas e sanduíches devido à sua textura suave.");
            Console.WriteLine();

            // Mostrar informações inseridas pelo usuário
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Informações do Produto:");
            Console.ResetColor(); // Resetar a cor para o padrão
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Fornecedor: {fornecedor}");
            Console.WriteLine($"Data de Colheita: {dataColeheita}");
            Console.WriteLine($"Estoque: {estoque}");
            Console.WriteLine($"Vendido: {vendido}");
            Console.WriteLine($"Para Venda: {paraVenda}");
            Console.WriteLine($"Venda do Mês: {vendaMes}");
            Console.WriteLine($"Vendas Semana: {vendasSemana}");
            Console.WriteLine();

            // Opções de entrada para ver mais informações
            Console.WriteLine("Opções:");
            Console.WriteLine("1. Adicionar Informações do Produto");
            Console.WriteLine("0. Retornar ao Menu Principal");
            Console.Write("Digite a opção desejada: ");

            // Loop para garantir que o usuário escolha uma opção válida
            string option;
            do
            {
                option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        DisplayMenu();
                        return;
                    case "1":
                        // Abrir outra tela para adicionar informações adicionais do produto
                        AdicionarProduto(ref id, ref fornecedor, ref dataColeheita, ref estoque, ref vendido, ref paraVenda, ref vendaMes, ref vendasSemana);
                        // Voltar à tela de Alface Lisa com as informações adicionadas
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Yellow; // Destaca a mensagem de erro em amarelo
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                        Console.ResetColor(); // Resetar a cor para o padrão
                        Console.Write("Digite a opção desejada: ");
                        break;
                }
            } while (true);
        }

        private static void AdicionarProduto(ref string id, ref string fornecedor, ref string dataColeheita, ref string estoque, ref string vendido, ref string paraVenda, ref string vendaMes, ref string vendasSemana)
        {
            Console.Clear(); // Limpar a tela

            Console.WriteLine("Adicionar Informações do Produto:");
            Console.Write("ID: ");
            id = Console.ReadLine();
            Console.Write("Fornecedor: ");
            fornecedor = Console.ReadLine();
            Console.Write("Data de Colheita: ");
            dataColeheita = Console.ReadLine();
            Console.Write("Estoque: ");
            estoque = Console.ReadLine();
            Console.Write("Vendido: ");
            vendido = Console.ReadLine();
            Console.Write("Para Venda: ");
            paraVenda = Console.ReadLine();
            Console.Write("Venda do Mês: ");
            vendaMes = Console.ReadLine();
            Console.Write("Vendas Semana: ");
            vendasSemana = Console.ReadLine();

            // Mostrar informações inseridas pelo usuário na tela de Alface Lisa
            DisplayAlfaceLisa(id, fornecedor, dataColeheita, estoque, vendido, paraVenda, vendaMes, vendasSemana);
        }




        // Implementar funções semelhantes para os outros tipos de alface: Americana, Crespa, Mimosa, Romana
        private static void DisplayAlfaceAmericana()
        {
            Console.Clear(); // Limpar a tela

            // Exibir mensagem de boas-vindas em verde
            Console.WriteLine("-------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bem-vindo à seção de Alface Americana");
            Console.ResetColor(); // Resetar a cor para o padrão
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();

            // Descrição da alface Americana
            Console.WriteLine("A alface Americana é conhecida por suas folhas crocantes e sabor suave.");
            Console.WriteLine("É uma ótima opção para saladas e sanduíches, adicionando textura e frescor.");
            Console.WriteLine();

            // Aguardar entrada do usuário para retornar à lista de hortaliças
            Console.WriteLine("Pressione qualquer tecla para voltar à lista de Hortaliças...");
            Console.ReadKey();
            DisplayHortalicas();
        }
        private static void DisplayAlfaceCrespa()
        {
            Console.Clear(); // Limpar a tela

            // Exibir mensagem de boas-vindas em verde
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bem-vindo à seção de Alface Crespa");
            Console.ResetColor(); // Resetar a cor para o padrão
            Console.WriteLine("----------------------------------");
            Console.WriteLine();

            // Descrição da alface crespa
            Console.WriteLine("A alface Crespa é conhecida por suas folhas frisadas e textura crocante.");
            Console.WriteLine("É uma escolha popular para saladas devido ao seu sabor suave e refrescante.");
            Console.WriteLine();

            // Aguardar entrada do usuário para retornar à lista de hortaliças
            Console.WriteLine("Pressione qualquer tecla para voltar à lista de Hortaliças...");
            Console.ReadKey();
            DisplayHortalicas();
        }
        // Funções semelhantes para os outros tipos de alface: Mimosa, Romana
        private static void DisplayAlfaceMimosa()
        {
            Console.Clear(); // Limpar a tela

            // Exibir mensagem de boas-vindas em verde
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bem-vindo à seção de Alface Mimosa");
            Console.ResetColor(); // Resetar a cor para o padrão
            Console.WriteLine("----------------------------------");
            Console.WriteLine();

            // Descrição da alface Americana
            Console.WriteLine("A alface Mimosa, também conhecida como alface Butterhead, tem folhas macias e suaves.");
            Console.WriteLine("É uma excelente opção para saladas e sanduíches devido à sua textura delicada e sabor suave.");
            Console.WriteLine();

            // Aguardar entrada do usuário para retornar à lista de hortaliças
            Console.WriteLine("Pressione qualquer tecla para voltar à lista de Hortaliças...");
            Console.ReadKey();
            DisplayHortalicas();
        }
        private static void DisplayAlfaceRomana()
        {
            Console.Clear(); // Limpar a tela

            // Exibir mensagem de boas-vindas em verde
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bem-vindo à seção de Alface Romana");
            Console.ResetColor(); // Resetar a cor para o padrão
            Console.WriteLine("----------------------------------");
            Console.WriteLine();

            // Descrição da alface Americana
            Console.WriteLine("A alface Romana, também conhecida como alface Romaine, tem folhas longas e crocantes.");
            Console.WriteLine("É amplamente utilizada em saladas César e outras receitas devido à sua textura firme e sabor robusto.");
            Console.WriteLine();

            // Aguardar entrada do usuário para retornar à lista de hortaliças
            Console.WriteLine("Pressione qualquer tecla para voltar à lista de Hortaliças...");
            Console.ReadKey();
            DisplayHortalicas();
        }
        private static void DisplayFrutas()
        {
            Console.Clear(); // Limpar a tela

            // Exibir mensagem de boas-vindas em verde
            Console.WriteLine("------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bem-vindo à seção de Frutas do Sanja Farm!");
            Console.ResetColor(); // Resetar a cor para o padrão
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();

            // Descrição das frutas
            Console.WriteLine("Nossas frutas são frescas, saborosas e provenientes de produtores locais.");
            Console.WriteLine("Oferecemos uma ampla variedade de frutas da estação, incluindo maçãs, bananas, laranjas e muito mais.");
            Console.WriteLine();


            // Aguardar entrada do usuário para retornar ao menu de produtos
            Console.WriteLine("Pressione qualquer tecla para voltar à página de Produtos...");
            Console.ReadKey();
            DisplayProducts();
        }
        private static void DisplayErvasMedicinais()
        {
            Console.Clear(); // Limpar a tela

            // Exibir mensagem de boas-vindas em verde
            Console.WriteLine("----------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bem-vindo à seção de Ervas Medicinais do Sanja Farm!");
            Console.ResetColor(); // Resetar a cor para o padrão
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();


            // Conteúdo específico de 
            Console.WriteLine("Nossas ervas medicinais são cultivadas organicamente e são selecionadas cuidadosamente para garantir sua qualidade.");
            Console.WriteLine("Oferecemos uma variedade de ervas para diferentes usos, incluindo chá de camomila, hortelã-pimenta, e muito mais.");
            Console.WriteLine("");

            Console.WriteLine("Produto Principal");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                                                                \r\n                                        mm                                      \r\n                                        mm                                      \r\n                                        mmmm                                    \r\n                                        mmmmmm                                  \r\n                                        MMMMmmmm                    --          \r\n                                        mmmmmmmm                    mm          \r\n                                        MMMMMMMMMM                  MM          \r\n                                        mmMMMMmmmm                MMmm          \r\n                                        MMMMmmmmmmmm            mmMMMM          \r\n                                        mmMMMMmmmm++            mm::MM--        \r\n      ++mm                              MM++MMMMMM++MM          MMMM++MM        \r\n        MMMMmmmm                          mmmmMMMM++::          mm@@MM++        \r\n          mmMM@@MMmm++MM                  ..mmMMMM::mmmm      --mmMMMMMM        \r\n            MMmmmmmmmmMMMMmm              mmmm++::mm++--        MM@@MMmm        \r\n              ++MMMMMMmmMMMMmm              MMmmMMmm::++mm    MMmmmmMM@@        \r\n              mmmmmmmm--MMMMmmMMMM          ++mmmm::----++    MMmm--MMmm        \r\n                  mmmmmm++MMMMMMMM            MM++mmmm..--mm  ++++MMmmMM        \r\n                    mm::MMMM++++mmMMMM          mmMMmmmm++++  ::mmMMmm        mm\r\n                    ::mmMMMMmmmmMMMMMM++MM        mmMMmmmm::  ++mmmmMMmm    mm  \r\n                        mmmmMMMMmmMMMMMMMM        mm::mmmmmm  ::::++mmMM  ++::  \r\n                          ++mm++MMMMmmMMmmMMmm      --++mmmm  ::mmmmMMmmmm++::  \r\n                            mmmmmmmmMMMMMMMMmmmm    mm++mm++--::::MM@@++..::    \r\n                                MMMMMMMMmm--MMMMmm    ++mm++  ++--MM++mmmm++    \r\n                                    mmmmMMmmmmmmmmmm  ++--mm::++mmmm++::++..    \r\n                                        mmmmmmmm..mmmm  ::--++mmmm  ++--++      \r\n                                            ::mmmmmm++mm  ++++::mm++++::::      \r\n                                                  mm++::++--mm++--mm++--        \r\n                                  ..  ++MM....        ++mmmm::++++++++          \r\n                  mmmmmmmmmmMMMMmmmmmm++mmmmmm++++++mm::  mmmmmm++::            \r\n          mm++++MMmm++MMMMMMMMmmmmMMmmmmMMmmmmmm::--++mmMMmmmm::                \r\n      ..mmmm++mmMMmm--MMMMMMMMMM++MMMMmmMMMMMM++mmmm++  ::--mm  ++              \r\n  mmmm++mmmmmmMMmmMMmmmmmmmmmmmm++MMmmmm++mm..::    ++mm++++++                  \r\n          mm::::mm::mm++mmmmmm::mm::::          --++::mmmm++::                  \r\n                      mm                    ++++++mm++++++mm::          ..      \r\n                                        mm++++::++++mm  ++mm::                  \r\n                                    ..mmmmmmmmmmmmmm    mm++              --    \r\n                                ..++++++::mmmmmm++      --mm                --  \r\n                              ..::::mmmm++++++::        --                      \r\n                              ::mm++mm::mm::            ::                      \r\n                            ++++++mmmm                                          \r\n                          ++mm++++                                              \r\n                        ++                                                      ");
            Console.ResetColor(); // Resetar a cor para o padrão
            Console.WriteLine();

            // Aguardar entrada do usuário para retornar ao menu de produtos
            Console.WriteLine("Pressione qualquer tecla para voltar à página de Produtos...");
            Console.ReadKey();
            DisplayProducts();
        }
        private static void DisplayPlantasAromaticas()
        {
            Console.Clear(); // Limpar a tela

            // Exibir mensagem de boas-vindas em verde
            Console.WriteLine("------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bem-vindo à seção de Plantas Aromáticas do Sanja Farm!");
            Console.ResetColor(); // Resetar a cor para o padrão
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine();

            // Conteúdo específico de Hortaliças
            Console.WriteLine("Nossas plantas aromáticas são cultivadas com cuidado para preservar seus aromas e sabores naturais.");
            Console.WriteLine("Oferecemos uma variedade de plantas aromáticas, como manjericão, alecrim, salsa e muito mais, perfeitas para temperar suas refeições.");
            Console.WriteLine();

            // Aguardar entrada do usuário para retornar ao menu de produtos
            Console.WriteLine("Pressione qualquer tecla para voltar à página de Produtos...");
            Console.ReadKey();
            DisplayProducts();
        }

        // Implemente métodos semelhantes para as outras opções de produtos (Frutas, Ervas Medicinais, Plantas Aromáticas)


        // Método para exibir os clientes
        private static void DisplayClientes()
        {
            Console.Clear(); // Limpar a tela

            // Exibir mensagem de boas-vindas
            Console.WriteLine("--------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Seja bem-vindo à página de Clientes do Sanja Farm!");
            Console.ResetColor(); // Resetar a cor para o padrão
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();


            // Exibir informações dos clientes
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Informações dos Clientes:");
            Console.ResetColor(); // Resetar a cor para o padrão
            Console.WriteLine();
            Console.WriteLine("- Jacinto Amorindo | ID: 41243532-2 | CPF: 236.512.523-41");
            Console.WriteLine("- Pedro Guedes Moras | ID: 51232313-5 | CPF: 924.152.412-42");
            Console.WriteLine("- Anthony Coelho | ID: 124633122-2 | CPF: 232.111.523-53");
            Console.WriteLine("- Julia Uchoas Paschal | ID: 633334126-7 | CPF: 554.308.577-08");
            Console.WriteLine();

            // Aguardar entrada do usuário para retornar ao menu principal
            Console.WriteLine("Pressione qualquer tecla para retornar ao Menu Principal...");
            Console.ReadKey();
            DisplayMenu();
        }

        // Método para exibir os fornecedores
        private static void DisplayFornecedores()
        {
            Console.Clear(); // Limpar a tela

            // Exibir mensagem de boas-vindas
            Console.WriteLine("------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Seja bem-vindo à página de Fornecedores do Sanja Farm!");
            Console.ResetColor(); // Resetar a cor para o padrão
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();       
            // Exibir informações dos fornecedores
            if (Fornecedores.Count > 0)
            {           
                foreach (var fornecedor in Fornecedores)
                {
                    Console.WriteLine("");
                    Console.WriteLine("---------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Fornecedores Cadastrados:");
                    Console.ResetColor(); // Resetar a cor para o padrão
                    Console.WriteLine($"-  Nome: {fornecedor.Nome}");
                    Console.WriteLine($"-  CPF/CNPJ: {fornecedor.CpfCnpj}");
                    Console.WriteLine($"-  Endereço: {fornecedor.Endereco}");
                    Console.WriteLine($"-  E-mail: {fornecedor.Email}");
                    Console.WriteLine($"-  Telefone: {fornecedor.Telefone}");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Dados de Monitoramento:");
                    Console.ResetColor(); // Resetar a cor para o padrão
                    Console.WriteLine($"-  Produtos: {fornecedor.Produtos}");
                    Console.WriteLine($"-  Licenças: {fornecedor.Licença}");
                    Console.WriteLine($"-  Classificação: {fornecedor.Classificação}");
                    Console.WriteLine("---------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("Nenhum fornecedor cadastrado.");
            }

            // Aguardar entrada do usuário para adicionar novo fornecedor ou retornar ao menu principal
            Console.WriteLine();
            Console.WriteLine("Opções:");
            Console.WriteLine("1. Adicionar Novo Fornecedor");
            Console.WriteLine("0. Retornar ao Menu Principal");
            Console.Write("Digite a opção desejada: ");
            // Loop para garantir que o usuário escolha uma opção válida
            string input;
            do
            {
                input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        DisplayMenu();
                        return;
                    case "1":
                        AdicionarFornecedor();
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Yellow; // Destaca a mensagem de erro em amarelo
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                        Console.ResetColor(); // Resetar a cor para o padrão
                        break;
                }
            } while (true);
        }

        // Método para adicionar um novo fornecedor
        private static void AdicionarFornecedor()
        {
            Console.Clear(); // Limpar a tela

            // Exibir mensagem de boas-vindas
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Adicionar Novo Fornecedor");
            Console.ResetColor(); // Resetar a cor para o padrão
            Console.WriteLine();

            // Solicitar dados do fornecedor
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("CPF/CNPJ: ");
            string cpfCnpj = Console.ReadLine();
            Console.Write("Endereço: ");
            string endereco = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();      
            Console.Write("Produtos: ");
            string produtos = Console.ReadLine();
            Console.Write("Licença: ");
            string licenças = Console.ReadLine();
            Console.Write("Classificação: ");
            string classificação = Console.ReadLine();

            // Adicionar o novo fornecedor à lista de fornecedores
            Fornecedor fornecedor = new Fornecedor(nome, cpfCnpj, endereco, email, telefone)
            {
                Classificação = classificação,
                Produtos = produtos,
                Licença = licenças,
            };
            Fornecedores.Add(fornecedor);

            // Exibir mensagem de confirmação
            Console.ForegroundColor = ConsoleColor.Green; // Destaca a mensagem de confirmação em verde
            Console.WriteLine("Novo fornecedor adicionado com sucesso!");
            Console.ResetColor(); // Resetar a cor para o padrão
            Console.WriteLine();

            // Aguardar entrada do usuário para retornar à tela de fornecedores
            Console.WriteLine("Pressione qualquer tecla para retornar à página de Fornecedores...");
            Console.ReadKey();
            DisplayFornecedores();
        }

        // Método para exibir a ajuda
        private static void DisplayAjuda()
        {
            Console.Clear(); // Limpar a tela

            // Exibir mensagem de boas-vindas
            Console.WriteLine("-----------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Seja bem-vindo à página de Ajuda do Sanja Farm!");
            Console.ResetColor(); // Resetar a cor para o padrão
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();

            // Exibir informações de ajuda
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Central de Ajuda:");
            Console.ResetColor(); // Resetar a cor para o padrão
            Console.WriteLine();
            Console.WriteLine("- Sobre fornecedores");
            Console.WriteLine("- Problemas com produtos");
            Console.WriteLine("- Sobre produtos (valores e informações)");
            Console.WriteLine("- Termos de serviço, políticas de privacidade e termos de uso");
            Console.WriteLine("- Entre em contato");
            Console.WriteLine("- Nossa equipe disponível de segunda a sexta das 7h às 18h, exceto feriados.");
            Console.WriteLine("- Email de contato: sanjadevs@gmail.com");
            Console.WriteLine("- Número de contato: (12) 4002-8922");
            Console.WriteLine();

            // Aguardar entrada do usuário para retornar ao menu principal
            Console.WriteLine("Pressione qualquer tecla para retornar ao Menu Principal...");
            Console.ReadKey();
            DisplayMenu();
        }

        // Método para exibir o perfil
        // Método para exibir o perfil
        private static void DisplayPerfil()
        {
            Console.Clear(); // Limpar a tela

            // Exibir mensagem de boas-vindas
            Console.WriteLine("------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Bem-vindo! Marcos");
            Console.ResetColor(); // Resetar a cor para o padrão
            Console.WriteLine("------------------");
            Console.WriteLine();

            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Você está logado como gerente.");
                Console.ResetColor(); // Resetar a cor para o padrão
                Console.WriteLine();

                Console.WriteLine("Privilégios de gerente:");
                Console.WriteLine("- Adicionar fornecedor");
                Console.WriteLine("- Adicionar produtos");
                Console.WriteLine("- Alterar informações");
                Console.WriteLine("- Implementar novas funções");
                Console.WriteLine("- Excluir conta ");
            }
            Console.ResetColor(); // Resetar a cor para o padrão
            Console.WriteLine();

            // Aguardar entrada do usuário para retornar ao menu principal
            Console.WriteLine("Pressione qualquer tecla para retornar ao Menu Principal...");
            Console.ReadKey();
            DisplayMenu();
        }


        // Classe para representar um fornecedor
        class Fornecedor
        {
            public string Nome { get; }
            public string CpfCnpj { get; }
            public string Endereco { get; }
            public string Email { get; }
            public string Telefone { get; }
            public string Classificação { get; set; }
            public string Produtos { get; set; }
            public string Licença { get; set; }

            public Fornecedor(string nome, string cpfCnpj, string endereco, string email, string telefone)
            {
                Nome = nome;
                CpfCnpj = cpfCnpj;
                Endereco = endereco;
                Email = email;
                Telefone = telefone;
            }
        }

        // Lista de fornecedores
        static List<Fornecedor> Fornecedores = new List<Fornecedor>();
        
    }
}
