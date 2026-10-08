using System.Text.Json;
using desafio_1.Models;

namespace desafio_1.Services;

public static class VendaJsonService
{
    public static List<Venda> LerArquivoJson(string caminhoArquivo)
    {
        var json = File.ReadAllText(caminhoArquivo);

        var vendasResponse = JsonSerializer.Deserialize<VendasResponse>(json);

        return vendasResponse?.vendas ?? [];
    }
}