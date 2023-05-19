namespace projeto_prodtos_16_05
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

         List<Usuario> users = new List<Usuario>();
        
        public Usuario(string _nome, string _email, string _senha)
        {
            Codigo += 1;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            DataCadastro = DateTime.Today;
        }
         public Usuario()
        {
            if (this.Nome == string.Empty)
            {
                Cadastrar();
            }
        }

        public void Cadastrar()
        {
            Console.WriteLine($"\nDigite seu nome:");
            string nomeDigitado = Console.ReadLine();

            Console.WriteLine($"\nDigite seu email:");
            string emailDigitado = Console.ReadLine();

            Console.WriteLine($"\nDigite a senha:");
            string senhaDigitada = Console.ReadLine();

            this.Nome = nomeDigitado;
            this.Email = emailDigitado;
            this.Senha = senhaDigitada;
            DataCadastro = DateTime.Now;
        }

         public void Deletar(Usuario usuario)
        {
            users.Remove(usuario);
        }
    }
}