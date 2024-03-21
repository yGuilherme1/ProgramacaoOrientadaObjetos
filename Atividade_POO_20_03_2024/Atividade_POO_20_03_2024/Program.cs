using static System.Console;
using static System.Convert;

List<Produto> listaProdutos = new List<Produto>();

while (true)
{
    WriteLine(@" 
    1. Cadastrar Produto           
    2. Listar Produtos         
    3. Remover Produto
    4. Sair");

    WriteLine("\nEscolha uma opção: ");
    int op = ToInt32(ReadLine());

    switch (op)
    {
        case 1:
            WriteLine("Digite o id do produto: ");
            string id = ReadLine();
            WriteLine("Digite a descrição do produto: ");
            string descricao = ReadLine();
            WriteLine("Digite a unidade do produto (LT, CX, KG, UN, MT): ");
            string unidade = ReadLine().ToUpper();
            WriteLine("Digite o preço do produto: ");
            double preco = ToDouble(ReadLine());
            WriteLine("Digite a quantidade no estoque: ");
            int quantidade = ToInt32(ReadLine());

            Produto novoProduto = new Produto(id, descricao, unidade, preco, quantidade);
            listaProdutos.Add(novoProduto);
            WriteLine("Produto cadastrado com sucesso!");

            break;

        case 2:
            if (listaProdutos.Count > 0)
            {
                WriteLine("Lista de Produtos: ");
                foreach (Produto produto in listaProdutos)
                {
                    WriteLine($"Id: {produto.id}, Descrição: {produto.descricao}, Unidade: {produto.unidade} " +
                        $"Preço: {produto.preco} Quantidade: {produto.quantidade}.");
                }
            }
            else
            {
                WriteLine("Nenhum produto cadastrado.");
            }
            break;

        case 3:
            WriteLine("Digite o id do produto.");
            id = ReadLine();

            Produto remocao = listaProdutos.Find(produto => produto.id == id);
            if(remocao != null)
            {
                listaProdutos.Remove(remocao);
                WriteLine("Produto removido com sucesso!");
            }
            else
            {
                WriteLine("Produto não encontrado.");
            }
            break;

        case 4:
            return;

        default:
            Write("Opção Invalida.");
            break;
    }
}