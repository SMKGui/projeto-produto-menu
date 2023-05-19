namespace projeto_prodtos_16_05
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca = new Marca();
        public string CadastradoPor { get; set; }
        public static List<Produto> listaProdutos = new List<Produto>();

        public Produto()
        {

        }

        public Produto(int _codigo, string _nomeProduto, float _preco)
        {
            Codigo = _codigo;
            NomeProduto = _nomeProduto;
            Preco = _preco;
            DataCadastro = DateTime.Today;
            Usuario user = new Usuario();
            CadastradoPor = user.Nome;
        }

        public static void Cadastrar()
        {
            Console.WriteLine($"\nDigite o código do produto:");
            int codigoDigitado = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nDigite o nome do produto:");
            string nomeDigitado = Console.ReadLine();

            Console.WriteLine($"\nDigite o preço do produto:");
            float precoDigitado = float.Parse(Console.ReadLine());

            listaProdutos.Add(
                new Produto(codigoDigitado, nomeDigitado, precoDigitado)
                );
        }

       public static void Listar()
        {
            if (listaProdutos.Count > 0)
            {
                foreach (Produto p in listaProdutos)
                {
                    Console.WriteLine(@$"
                    Codigo = {p.Codigo}
                    NomeProduto = {p.NomeProduto}
                    Preco = {p.Preco:C2}
                    DataCadastro = {p.DataCadastro}
                    Marca = {p.Marca.NomeMarca}
                    CadastradoPor = {p.CadastradoPor}");
                }
            }
            else
            {
                Console.WriteLine($"\nLista Vazia!");
            }
        }

        public static void Deletar(int codigo)
        {
            Produto removido = listaProdutos.Find(x => x.Codigo == codigo);
            int index = listaProdutos.IndexOf(removido);
            listaProdutos.RemoveAt(index);

            Console.WriteLine($"Produto excluido");
        }

        internal static void Deletar()
        {
            throw new NotImplementedException();
        }
    }
}