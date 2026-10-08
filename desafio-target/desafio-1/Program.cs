using desafio_1.Models;
using desafio_1.Models.Utils;
using desafio_1.Services;

try
{
     var caminhoArquivo = "vendas.json";

    List<Venda> vendas = VendaJsonService.LerArquivoJson(caminhoArquivo);

    if (vendas.Count == 0)
    {
        Console.WriteLine("Nenhuma venda encontrada.");
        return;
    }

    var comissoes = VendaService.CalcularComissaoPorVendedor(vendas);

    TabelaConsole.ExibirComissoes(comissoes);
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}