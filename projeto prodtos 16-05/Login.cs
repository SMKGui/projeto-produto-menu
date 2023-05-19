namespace projeto_prodtos_16_05
{
    public class Login
    {
        public bool Logado { get; set; }

        public Login()
        {
            Usuario user = new Usuario();

            Logar(user);

            if (this.Logado == true)
            {
                GerarMenu();
            }
        }

        public void Logar(Usuario usuario)
        {
            Console.WriteLine($"Informe o email: ");
            string emailDigitado = Console.ReadLine();

            Console.WriteLine($"Informe a senha: ");
            string senhaDigitada = Console.ReadLine();

            if (emailDigitado == usuario.Email && senhaDigitada == usuario.Senha)
            {
                this.Logado = true;
                Console.WriteLine($"Login efetuado com sucesso!");

            }
            else
            {
                this.Logado = false;
                Console.WriteLine($"Falha ao logar!");

            }
        }

        public void Deslogar()
        {
            this.Logado = false;
        }

        public void GerarMenu()
        {
            Produto produto = new Produto();
            Marca marca = new Marca();

            string opcao;

            do
            {
                 Console.WriteLine(@$"
            [1] - Cadastrar Produto
            [2] - Listar Produtos
            [3] - Remover Produto
            -----------------------
            [4] - Cadastrar Marca
            [5] - Listar Marcas
            [6] - Remover Marca

            [0] - Sair
            ");

            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Produto.Cadastrar();
                    break;
                case "2":
                    Produto.Listar();
                    break;
                case "3":
                    Console.WriteLine($"Informe o codigo a ser excluido: ");
                    int codigoProduto = int.Parse(Console.ReadLine());
                    Produto.Deletar();
                    break;
                case "4":
                    Marca.Cadastrar();
                    break;
                case "5":
                    Marca.Listar();
                    break;
                case "6":
                    Console.WriteLine($"Informe o codigo a ser excluido: ");
                    int codigoMarca = int.Parse(Console.ReadLine());
                    Marca.Deletar(codigoMarca);
                    break;
                case "0":
                    Console.WriteLine($"App encerrado!");
                    break;
                default:
                    Console.WriteLine($"Opcao invalida!");
                    break;
            }
            } while (opcao != "0");
        }
    }
}