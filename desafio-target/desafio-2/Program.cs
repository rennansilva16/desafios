using desafio_2.Services;
using desafio_2.Utils;

try
{
    var caminhoArquivoEstoque = "estoque.json";
    var caminhoArquivoMovimentacoes = "movimentacoes.json";

    var produtos = EstoqueJsonService.LerArquivoJson(
        caminhoArquivoEstoque);

    var movimentacoes = MovimentacaoJsonService.LerMovimentacoes(
        caminhoArquivoMovimentacoes);


    var tipo = ConsoleService.ObterTipoMovimentacao();

    ConsoleService.ExibirProdutos(produtos);
    var codigoProduto = ConsoleService.ObterCodigoProduto();

    var quantidade = ConsoleService.ObterQuantidade();

    var descricao = ConsoleService.ObterDescricao(tipo);

    var proximoId = MovimentacaoJsonService.ObterProximoId(
        movimentacoes);

    var movimentacao = EstoqueService.MovimentarEstoque(
        produtos,
        codigoProduto,
        tipo,
        descricao,
        quantidade,
        proximoId);

    movimentacoes.Add(movimentacao);

    EstoqueJsonService.SalvarArquivoJson(
        caminhoArquivoEstoque,
        produtos);

    MovimentacaoJsonService.SalvarMovimentacoes(
        caminhoArquivoMovimentacoes,
        movimentacoes);

    var produtoMovimentado = produtos.First(
        p => p.CodigoProduto == codigoProduto);

    ConsoleService.ExibirResultado(
        movimentacao,
        produtoMovimentado);
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}