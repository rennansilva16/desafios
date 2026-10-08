namespace desafio_2.Utils;

public class ConsoleService
{
    public static string ObterTipoMovimentacao()
    {
        while (true)
        {
            Console.WriteLine("---- Menu ----");
            Console.WriteLine("1. Entrada");
            Console.WriteLine("2. Saída");
            Console.Write("Escolha uma opção: ");

            var opcao = Console.ReadLine();

            if (opcao == "1")
            {
                return "Entrada";
            }

            if (opcao == "2")
            {
                return "Saída";
            }

            Console.WriteLine("Opção inválida.");
        }
    }

    public static int ObterCodigoProduto()
    {
        while (true)
        {
            Console.Write("Informe o código do produto: ");

            if (int.TryParse(Console.ReadLine(), out var codigo))
            {
                return codigo;
            }

            Console.WriteLine("Código inválido.");
        }
    }

    public static int ObterQuantidade()
    {
        while (true)
        {
            Console.Write("Informe a quantidade que deseja movimentar: ");

            if (int.TryParse(Console.ReadLine(), out var quantidade)
                && quantidade > 0)
            {
                return quantidade;
            }

            Console.WriteLine("Quantidade inválida.");
        }
    }

    public static string ObterDescricao(string tipo)
    {
        var descricoes = tipo == "Entrada"
            ? new List<string>
            {
                "Compra de produtos",
                "Devolução de produtos",
                "Ajuste de estoque",
                "Outros"
            }
            : new List<string>
            {
                "Venda de produtos",
                "Ajuste de estoque",
                "Outros"
            };

        Console.WriteLine();
        Console.WriteLine($"Opções de {tipo.ToLower()}:");

        for (int i = 0; i < descricoes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {descricoes[i]}");
        }

        while (true)
        {
            Console.Write("Escolha uma opção: ");

            if (int.TryParse(Console.ReadLine(), out var opcao)
                && opcao >= 1
                && opcao <= descricoes.Count)
            {
                if (descricoes[opcao - 1] == "Outros")
                {
                    Console.Write("Informe a descrição da movimentação: ");
                    return Console.ReadLine() ?? string.Empty;
                }

                return descricoes[opcao - 1];
            }

            Console.WriteLine("Opção inválida.");
        }
    }

    public static void ExibirProdutos(
        List<desafio_2.Models.Produto> produtos)
    {
        Console.WriteLine();
        Console.WriteLine("Produtos disponíveis no estoque:");
        Console.WriteLine("---------------------------------");

        foreach (var produto in produtos)
        {
            Console.WriteLine(
                $"Código: {produto.CodigoProduto}, " +
                $"Descrição: {produto.DescricaoProduto}, " +
                $"Estoque: {produto.Estoque}");
        }

        Console.WriteLine("---------------------------------");
    }

    public static void ExibirResultado(
        desafio_2.Models.MovimentacaoEstoque movimentacao,
        desafio_2.Models.Produto produto)
    {
        Console.WriteLine();
        Console.WriteLine("Movimentação realizada com sucesso!");
        Console.WriteLine(
            $"ID: {movimentacao.Id}");
        Console.WriteLine(
            $"Código do Produto: {movimentacao.CodigoProduto}");
        Console.WriteLine(
            $"Descrição: {movimentacao.Descricao}");
        Console.WriteLine(
            $"Tipo: {movimentacao.Tipo}");
        Console.WriteLine(
            $"Quantidade: {movimentacao.Quantidade}");

        Console.WriteLine();
        Console.WriteLine(
            $"Quantidade atualizada em estoque do produto " +
            $"{produto.DescricaoProduto}: {produto.Estoque}");
    }
}