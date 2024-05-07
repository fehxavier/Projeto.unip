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
                Console.ResetColor(); // Resetar a cor para o padrão

                Console.WriteLine();

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
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("1. Produtos");
            Console.WriteLine("2. Clientes");
            Console.WriteLine("3. Fornecedores");
            Console.WriteLine("4. Ajuda");
            Console.WriteLine("5. Perfil");
            Console.WriteLine("6. Sair");
        }

        // Método para exibir os produtos
        private static void DisplayProducts()
        {
            Console.Clear(); // Limpar a tela

            // Exibir mensagem de boas-vindas
            Console.WriteLine("Seja bem-vindo à página de Produtos do Sanja Farm!");
            Console.WriteLine();

            // Exibir lista de produtos
            Console.WriteLine("Produtos Disponíveis:");
            Console.WriteLine("- Café");
            Console.WriteLine("- Hortaliças");
            Console.WriteLine("- Queijo");
            Console.WriteLine("- Leite");
            Console.WriteLine("- Vinho");
            Console.WriteLine();

            // Aguardar entrada do usuário para retornar ao menu principal
            Console.WriteLine("Pressione qualquer tecla para retornar ao Menu Principal...");
            Console.ReadKey();
            DisplayMenu();
        }

        // Método para exibir os clientes
        private static void DisplayClientes()
        {
            Console.Clear(); // Limpar a tela

            // Exibir mensagem de boas-vindas
            Console.WriteLine("Seja bem-vindo à página de Clientes do Sanja Farm!");
            Console.WriteLine();

            // Exibir informações dos clientes
            Console.WriteLine("Informações dos Clientes:");
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
            Console.WriteLine("Seja bem-vindo à página de Fornecedores do Sanja Farm!");
            Console.WriteLine();

            // Exibir informações dos fornecedores
            if (Fornecedores.Count > 0)
            {
                Console.WriteLine("Fornecedores Cadastrados:");
                foreach (var fornecedor in Fornecedores)
                {
                    Console.WriteLine($"- Nome: {fornecedor.Nome}");
                    Console.WriteLine($"  CPF/CNPJ: {fornecedor.CpfCnpj}");
                    Console.WriteLine($"  Endereço: {fornecedor.Endereco}");
                    Console.WriteLine($"  E-mail: {fornecedor.Email}");
                    Console.WriteLine($"  Telefone: {fornecedor.Telefone}");
                    Console.WriteLine("  Dados de Monitoramento:");
                    Console.WriteLine($"  - Data de Entrega: {fornecedor.DataEntrega}");
                    Console.WriteLine($"  - Qualidade dos Produtos: {fornecedor.QualidadeProdutos}");
                    Console.WriteLine($"  - Feedback dos Clientes: {fornecedor.FeedbackClientes}");
                    Console.WriteLine();
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
            Console.WriteLine("Adicionar Novo Fornecedor");
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
            Console.Write("Data de Entrega: ");
            string dataEntrega = Console.ReadLine();
            Console.Write("Qualidade dos Produtos: ");
            string qualidadeProdutos = Console.ReadLine();
            Console.Write("Feedback dos Clientes: ");
            string feedbackClientes = Console.ReadLine();

            // Adicionar o novo fornecedor à lista de fornecedores
            Fornecedor fornecedor = new Fornecedor(nome, cpfCnpj, endereco, email, telefone)
            {
                DataEntrega = dataEntrega,
                QualidadeProdutos = qualidadeProdutos,
                FeedbackClientes = feedbackClientes
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
            Console.WriteLine("Seja bem-vindo à página de Ajuda do Sanja Farm!");
            Console.WriteLine();

            // Exibir informações de ajuda
            Console.WriteLine("Central de Ajuda:");
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
        private static void DisplayPerfil()
        {
            Console.Clear(); // Limpar a tela

            // Exibir mensagem de boas-vindas
            Console.WriteLine("Seja bem-vindo à página de Perfil do Sanja Farm!");
            // Resto da implementação da página de perfil

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
            public string DataEntrega { get; set; }
            public string QualidadeProdutos { get; set; }
            public string FeedbackClientes { get; set; }

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
