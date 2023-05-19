namespace projeto_prodtos_16_05
{
    public class Marca
    {
        //atributos
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }
        //metodos
        public static List<Marca> listaMarcas = new List<Marca>();

        public Marca(int _codigo, string _nomeMarca)
        {
            Codigo = _codigo;
            NomeMarca = _nomeMarca;
            DataCadastro = DateTime.Today;
        }

        public Marca()
        {
        }

        public static void Cadastrar()
        {
            Console.WriteLine($"\nDigite o código da marca:");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nDigite o nome da marca:");
            string nome = Console.ReadLine();

            listaMarcas.Add(new Marca(codigo, nome));
        }

        public static void Listar()
        {
            if (listaMarcas.Count > 0)
            {
                foreach (Marca marca in listaMarcas)
                {
                    Console.WriteLine(@$"
                    Lista de Marcas
                    Código: {marca.Codigo}
                    Nome: {marca.NomeMarca}
                    Data de cadastro: {marca.DataCadastro}");

                }
            }
        }

        public static void Deletar(int codigo)
        {
            Marca removida = listaMarcas.Find(x => x.Codigo == codigo);
            int index = listaMarcas.IndexOf(removida);
            listaMarcas.RemoveAt(index);

            Console.WriteLine($"\nMarca excluida.");

        }
    }
}