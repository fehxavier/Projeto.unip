using System;

namespace LoginFormConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem-vindo ao Sanja Farm!");

            string username = "";
            string password = "";

            bool loggedIn = false;
            while (!loggedIn)
            {
                // Solicitar nome de usuário
                Console.Write("Nome de usuário: ");
                username = Console.ReadLine();

                // Solicitar senha
                Console.Write("Senha: ");
                password = Console.ReadLine();

                loggedIn = CheckCredentials(username, password);

                if (!loggedIn)
                {
                    Console.WriteLine("Nome de usuário ou senha incorretos. Por favor, tente novamente.");
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
                    case "produtos":
                        DisplayProducts();
                        break;
                    case "clientes":
                        DisplayClientes();
                        break;
                    case "fornecedores":
                        DisplayFornecedores();
                        break;
                    case "ajuda":
                        DisplayAjuda();
                        break;
                    case "perfil":
                        DisplayPerfil();
                        break;
                    case "sair":
                        Console.WriteLine("Saindo do programa...");
                        return; // Termina a execução do programa
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
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

            // Exibir mensagem de boas-vindas
            Console.WriteLine("Seja bem-vindo ao Sanja Farm!");
            Console.WriteLine();

            // Exibir desenho do Sanja Farm
            Console.WriteLine(@"     _______
    /       \
   /  _   _  \
  /  /_\_/ \  \
 /   \_/ \_/   \
/_______________\
|      ___      |
|     /   \     |
|    /     \    |
|   /       \   |
|  /_________\  |
|_______________|");
            Console.WriteLine();

            // Exibir opções de menu
            Console.WriteLine("Menu:");
            Console.WriteLine("- Produtos");
            Console.WriteLine("- Clientes");
            Console.WriteLine("- Fornecedores");
            Console.WriteLine("- Ajuda");
            Console.WriteLine("- Perfil");
            Console.WriteLine("- Sair");
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

            // Exibir opções de menu para retornar ao menu principal ou sair
            Console.WriteLine("Opções:");
            Console.WriteLine("- Retornar ao Menu Principal");
            Console.WriteLine("- Sair");

            // Aguardar retorno ao menu principal
            Console.ReadLine();
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

            // Exibir opções de menu para retornar ao menu principal ou sair
            Console.WriteLine("Opções:");
            Console.WriteLine("- Retornar ao Menu Principal");
            Console.WriteLine("- Sair");

            // Aguardar retorno ao menu principal
            Console.ReadLine();
            DisplayMenu();
        }

        // Método para exibir os fornecedores
        private static void DisplayFornecedores()
        {
            Console.Clear(); // Limpar a tela

            // Exibir mensagem de boas-vindas
            Console.WriteLine("Seja bem-vindo à página de Fornecedores do Sanja Farm!");
            // Resto da implementação da página de fornecedores

            // Aguardar retorno ao menu principal
            Console.ReadLine();
            DisplayMenu();
        }

        // Método para exibir a ajuda
        private static void DisplayAjuda()
        {
            Console.Clear(); // Limpar a tela

            // Exibir mensagem de boas-vindas
            Console.WriteLine("Seja bem-vindo à página de Ajuda do Sanja Farm!");
            // Resto da implementação da página de ajuda

            // Aguardar retorno ao menu principal
            Console.ReadLine();
            DisplayMenu();
        }

        // Método para exibir o perfil
        private static void DisplayPerfil()
        {
            Console.Clear(); // Limpar a tela

            // Exibir mensagem de boas-vindas
            Console.WriteLine("Seja bem-vindo à página de Perfil do Sanja Farm!");
            // Resto da implementação da página de perfil

            // Aguardar retorno ao menu principal
            Console.ReadLine();
            DisplayMenu();
        }
    }
}
